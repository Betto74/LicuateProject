using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTO_U3
{
    public partial class frmAEVenta : Form
    {
        frmLogin login;
        
        List<DetallesVenta> detalles = new List<DetallesVenta>();
        List<Producto> productos = new List<Producto>();

        bool edit;//true:edit / false:add
        double subtotal = 0;
        int editarInd = -1, idOrden, idUsuario;
        
        public frmAEVenta(int id, frmLogin login)
        {
            InitializeComponent();

            Redondear r = new Redondear();
            r.RedondearDgv(dgvOrden, 40);
            r.RedondearBoton(btnAceptar, 30);
            r.RedondearBoton(btnAgregar, 30);
            r.RedondearBoton(btnEditar, 30);
            r.RedondearBoton(btnEliminar, 30);
            r.RedondearBoton(btnVolver, 30);
            
           
            idOrden = new VentasDAO().getId();
            if (id >= 0) {
                DetallesVentaDAO de = new DetallesVentaDAO();
                detalles = de.getData(id);

                edit = true;
                idOrden--;
                subtotal = detalles.Sum(objeto => objeto.TOTAL);

                reloadDgv();
            }

            productos = new ProductosDAO().getAllData();
            cbxProducto.DataSource = productos;
            cbxProducto.DisplayMember = "NOMBRE";

            this.login = login;
            idUsuario = login.user.ID;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            if (detalles.Count() > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea finalizar la venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    
                    if (!edit)
                    {
                        Venta venta = new Venta()
                        {
                            ID = idOrden,
                            FECHA = DateTime.Now,
                            MONTO = subtotal * 1.16,
                            ID_USUARIO = idUsuario,
                            ID_CLIENTE = new VentasDAO().getCliente()

                        };

                        if (new VentasDAO().insert(venta)
                            && new DetallesVentaDAO().insert(detalles))
                        {
                            MessageBox.Show("Se ha producido exitosamente la venta");
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al efectuar al venta");
                        }
                    }
                    else {
                        if (new VentasDAO().update(subtotal * 1.16, detalles[0].ID_ORDEN)
                            && new DetallesVentaDAO().delete(idOrden) 
                            && new DetallesVentaDAO().insert(detalles))
                        {
                            MessageBox.Show("Se ha editado correctamente la venta");
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al editar al venta");
                        }
                    }
                    
                    detalles.Clear();
                    subtotal = 0;
                    lblPSub.Text = "$";
                    lblPIva.Text = "$";
                    lblPTotal.Text = "$";
                    dgvOrden.DataSource = null;
                }

            }
            else
            {
                MessageBox.Show("No se ha agregado ningun producto");
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dgvOrden.SelectedRows.Count > 0)
            {
                editarInd = dgvOrden.SelectedRows[0].Index;
                cbxProducto.SelectedIndex = cbxProducto.FindStringExact(detalles[editarInd].NOMBRE_PRODUCTO);
                txtCantidad.Text = detalles[editarInd].CANTIDAD.ToString();
                txtCom.Text = detalles[editarInd].COMENTARIOS.ToString();
                txtExtra.Text = "" + (detalles[editarInd].PRECIOCONEXTRA - detalles[editarInd].PRECIOUNITARIO);

   

                btnAgregar.Text = "Aceptar";
                btnEditar.Visible = false;
                btnAceptar.Visible = false;
                btnVolver.Visible = false;
                btnEliminar.Visible = false;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila.");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvOrden.SelectedRows.Count > 0)
            {

                subtotal -= detalles[dgvOrden.SelectedRows[0].Index].TOTAL;
                detalles.RemoveAt(dgvOrden.SelectedRows[0].Index);
                reloadDgv();
            }
            else
            {

                MessageBox.Show("No se ha seleccionado ninguna fila.");
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            frmVenta frm = new frmVenta(false,login);
            frm.Show();
            this.Close();
       
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (cbxProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto");
                return;
            }

            if (string.IsNullOrEmpty(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out int numero) || numero<=0)
            {
                MessageBox.Show("Debe colocar una cantidad");
                return;
            }

            if (string.IsNullOrEmpty(txtExtra.Text))
            {
                txtExtra.Text = "0";
            }

            

            //Generar detalle
            DetallesVenta dv = new DetallesVenta()
            {
                ID_ORDEN = idOrden,
                ID_PRODUCTO = ((Producto)cbxProducto.SelectedItem).ID,
                NOMBRE_PRODUCTO = ((Producto)cbxProducto.SelectedItem).NOMBRE,
                PRECIOUNITARIO = ((Producto)cbxProducto.SelectedItem).PRECIO,
                PRECIOCONEXTRA = ((Producto)cbxProducto.SelectedItem).PRECIO + Convert.ToInt32(txtExtra.Text),
                CANTIDAD = Convert.ToInt32(txtCantidad.Text),
                COMENTARIOS = txtCom.Text,
                
            };
            
            dv.TOTAL = dv.PRECIOUNITARIO*dv.CANTIDAD;
            subtotal += dv.CANTIDAD * dv.PRECIOCONEXTRA;
            

            //Editar
            if (editarInd >= 0)
            {
                dv.ID_ORDEN = detalles[editarInd].ID_ORDEN;
                subtotal -= detalles[editarInd].TOTAL;
                detalles.RemoveAt(editarInd);

                btnEditar.Visible = true;
                btnAceptar.Visible = true;
                btnVolver.Visible = true;
                btnEliminar.Visible = true;
                btnAgregar.Text = "Agregar";
                editarInd = -1;

            }

            //Verificar si existe
            int indice = detalles.FindIndex(x => x.Equals(dv));
             if (indice == -1)
             {
                 detalles.Add(dv);  
             }
             else
             {
                 detalles[indice].CANTIDAD += dv.CANTIDAD;
                 detalles[indice].TOTAL += dv.CANTIDAD*dv.PRECIOCONEXTRA;
             }
            
             reloadDgv();
        }

        


        //Recargar dgv y labels
        private void reloadDgv() {
            dgvOrden.DataSource = null;
            dgvOrden.DataSource = detalles;
            dgvOrden.AllowUserToDeleteRows = false;
            dgvOrden.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvOrden.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrden.MultiSelect = false;
            
            dgvOrden.Columns["ID_ORDEN"].Visible = false;
            dgvOrden.Columns["ID_PRODUCTO"].Visible = false;

            lblPSub.Text = "$" + subtotal;
            lblPIva.Text = "$" + subtotal * .16;
            lblPTotal.Text = "$" + subtotal * 1.16;

            txtCantidad.Text = "0";
            txtCom.Text = "";
            txtExtra.Text = "";
            cbxProducto.SelectedIndex = -1;
            cbxCategoria.SelectedIndex = -1;
        }
        //Filtro por categorias
        private void cbxCategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
            if (cbxCategoria.SelectedItem.Equals("Todas"))
            {
                cbxProducto.DataSource = productos;
                cbxProducto.DisplayMember = "NOMBRE";
            }
            else
            {
                List<Producto> filtro = productos.Where(p => p.CATEGORIA.Equals(cbxCategoria.SelectedItem)).ToList();
                cbxProducto.DataSource = filtro;
                cbxProducto.DisplayMember = "NOMBRE";
            }
        }

        private void frmAEVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }


    }
}

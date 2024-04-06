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
        bool aged;//true:agregar / false:editar
        List<DetallesVenta> detalles = new List<DetallesVenta>();
        List<Producto> productos = new List<Producto>();
        double subtotal = 0;
        public frmAEVenta(int id)
        {
            InitializeComponent();

            Redondear r = new Redondear();
            r.RedondearDgv(dgvOrden, 40);
            r.RedondearBoton(btnAceptar, 30);
            r.RedondearBoton(btnAgregar, 30);
            r.RedondearBoton(btnEditar, 30);
            r.RedondearBoton(btnEliminar, 30);
            r.RedondearBoton(btnVolver, 30);

            aged = id < 0;
       
            Initialize(id);
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVenta frm = new frmVenta(false);
            frm.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

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


            int idOrden = new VentasDAO().getId() + 1;

            if (string.IsNullOrEmpty(txtExtra.Text)) { 
                txtExtra.Text = "0";
            }
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
            dv.TOTAL = 16;
            subtotal += dv.CANTIDAD * dv.PRECIOCONEXTRA;




            int indice = detalles.FindIndex(x => x.Equals(dv));
             if (indice == -1)
             {

                 detalles.Add(dv);
                 MessageBox.Show("Cuantos: "+detalles.Count);
             }
             else
             {
                 detalles[indice].CANTIDAD += dv.CANTIDAD;
                 detalles[indice].TOTAL += dv.CANTIDAD*dv.PRECIOCONEXTRA;
                 MessageBox.Show("Indie: " + indice);
             }

          

       
            dgvOrden.DataSource = null;
            dgvOrden.DataSource = detalles;
            dgvOrden.AllowUserToDeleteRows = false;
            dgvOrden.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvOrden.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrden.Columns["ID_ORDEN"].Visible = false;
            dgvOrden.Columns["ID_PRODUCTO"].Visible = false;








        }
        private void Initialize(int id)
        {
            if (id > 0) {
                DetallesVentaDAO de = new DetallesVentaDAO();
                detalles = de.getData(id);
            }
            

            productos = new ProductosDAO().getAllData();
            cbxProducto.DataSource = productos;
            cbxProducto.DisplayMember = "NOMBRE";
    
            
            

        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("Ha cambiado a " + cbxCategoria.SelectedItem);
            if (cbxCategoria.SelectedItem == "Todas")
            {
                cbxProducto.DataSource = productos;
                cbxProducto.DisplayMember = "NOMBRE";
            }
            else 
            {
                List<Producto> filtro = productos.Where(p => p.CATEGORIA.Equals(cbxCategoria.SelectedItem)).ToList();
                //MessageBox.Show(""+filtro.Count + " - " + productos.Count);
                cbxProducto.DataSource = filtro;
                cbxProducto.DisplayMember = "NOMBRE";
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           if (dgvOrden.SelectedRows.Count > 0)
            {
                // Obtener la primera fila seleccionada (en caso de que haya múltiples filas seleccionadas)
                int index = dgvOrden.SelectedRows[0].Index;
                cbxProducto.SelectedItem = detalles[index].NOMBRE_PRODUCTO;
                txtCantidad.Text = detalles[index].CANTIDAD.ToString();
                txtCom.Text = detalles[index].COMENTARIOS.ToString();
                txtExtra.Text =""+(detalles[index].PRECIOCONEXTRA-detalles[index].PRECIOUNITARIO);




            }
            else
            {
                
                MessageBox.Show("No se ha seleccionado ninguna fila.");
            }
        }
    }
}

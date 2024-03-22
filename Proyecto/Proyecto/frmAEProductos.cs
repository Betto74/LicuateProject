using Datos;
using Modelos;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_U3
{
    public partial class frmAEProductos : Form
    {
        frmProductos frmP;
        Producto producto;
        Boolean bandera;      
        public frmAEProductos(Producto producto, frmProductos p)
        {
            InitializeComponent();
            fillData(producto);
            this.frmP = p;
            this.producto = producto;   
            bandera = false;
            
        }

        public frmAEProductos(frmProductos p)
        {
            InitializeComponent();
            this.frmP = p;
            bandera = true;
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
    
            frmP.Show();
            frmP.Initialize();
            this.Close();
        }

        private void frmAEProductos_Load(object sender, EventArgs e)
        {

        }

        private void frmAEProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            frmP.Show();
            frmP.Initialize();
        }

        private void fillData(Producto p)
        {
            txtNombre.Text = p.NOMBRE;
            txtPrecio.Text = ""+p.PRECIO;
            txtDescripcion.Text = p.DESCRIPCION;
            cbxCategoria.SelectedItem = p.CATEGORIA;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(txtNombre.Text)) {
                MessageBox.Show("El nombre no debe de se estar vacio");
                return;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("La descripcion no debe de se estar vacia");
                return;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("La descripcion no debe de se estar vacia");
                return;
            }

            if (cbxCategoria.SelectedIndex == -1) {
                MessageBox.Show("Debe escoger alguna categoria");
                return;
            }

            if (!double.TryParse(txtPrecio.Text, out double x))
            {
                MessageBox.Show("El precio deber ser un valor numerico");
                return;
            }

            Producto prd = new Producto()
            {
                NOMBRE = txtNombre.Text,
                DESCRIPCION = txtDescripcion.Text,
                CATEGORIA = cbxCategoria.SelectedItem.ToString(),
                PRECIO = Convert.ToDouble(txtPrecio.Text)

            };
            // add
            if (bandera)
            {
                if (new ProductosDAO().insert(prd))
                {
                    MessageBox.Show("Se agrego correctamente al inventario");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }

            }
            //edit
            else
            {
                prd.ID = producto.ID;
                if (new ProductosDAO().update(prd))
                {
                    MessageBox.Show("Se edito correctamente inventario");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
              

            }

            frmP.Show();
            frmP.Initialize();
            this.Hide();
        }
    }
}

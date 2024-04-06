using Datos;
using Modelos;
using System;
using System.Collections;
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
    public partial class frmProductos : Form
    {
        List<Producto> invProductos;
        frmLogin login;
        public frmProductos(frmLogin login)
        {
            InitializeComponent();
            Initialize();
            this.login = login;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAEProductos aep = new frmAEProductos(login);
            aep.Show();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                // Obtener la primera fila seleccionada (en caso de que haya múltiples filas seleccionadas)
                int index = dgvProductos.SelectedRows[0].Index;
               
                frmAEProductos aep = new frmAEProductos(invProductos[index], login);
                aep.Show();
                this.Close();
                

            }
            else
            {
                // Si no hay filas seleccionadas, manejar el caso en consecuencia
                MessageBox.Show("No se ha seleccionado ninguna fila.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {

                // Obtener la primera fila seleccionada (en caso de que haya múltiples filas seleccionadas)
                int index = dgvProductos.SelectedRows[0].Index;
                
                if (new ProductosDAO().delete(invProductos[index].ID))
                {
                    MessageBox.Show("Se ha eliminado correctamente");
                    Initialize();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
                

            }
            else
            {
                // Si no hay filas seleccionadas, manejar el caso en consecuencia
                MessageBox.Show("No se ha seleccionado ninguna fila.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu(login);
            menu.Show();
            this.Close();

        }


        public void Initialize()
        {

            
            invProductos = new ProductosDAO().getAllData();
            dgvProductos.DataSource = invProductos;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Columns["ID"].Visible = false;
            dgvProductos.ClearSelection();

        }
    }
}

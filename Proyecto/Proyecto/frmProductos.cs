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
        public frmProductos()
        {
            InitializeComponent();
            Initialize();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAEProductos aep = new frmAEProductos(this);
            aep.Show();
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                // Obtener la primera fila seleccionada (en caso de que haya múltiples filas seleccionadas)
                int index = dgvProductos.SelectedRows[0].Index;
               
                frmAEProductos aep = new frmAEProductos(invProductos[index], this);
                aep.Show();
                this.Hide();
                

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
            MessageBox.Show("Vuelve al menu XD");
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

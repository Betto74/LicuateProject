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
using System.Xml.XPath;

namespace PROYECTO_U3
{
    public partial class frmVenta : Form
    {
        List<Venta> ventas;
        public frmVenta(bool corte)
        {
            InitializeComponent();

            if (corte)
            {

            }
            else 
            {
                Initialize();
            }

        }


        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            frmAEVenta frm = new frmAEVenta(-1);
            frm.Show();
            this.Hide();
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
          //  this.Hide();
          //  frmMenu menu = new frmMenu(false);
          //  menu.Show();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            

            if (dgvVentas.SelectedRows.Count > 0)
            {
            
                int index = dgvVentas.SelectedRows[0].Index;
                int id = Convert.ToInt32(dgvVentas.Rows[index].Cells[0].Value);
                
                frmAEVenta frm = new frmAEVenta(id);
                frm.Show();
                this.Hide();

            }
            else
            {
                // Si no hay filas seleccionadas, manejar el caso en consecuencia
                MessageBox.Show("No se ha seleccionado ninguna fila.");
            }
        }

        private void frmVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
          //  this.Hide();
           // frmMenu menu = new frmMenu(false);
           // menu.Show();
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            if (checkFechas(dtpInicio.Value, dtpFin.Value))
            {
                
                dtpFin.Value = dtpInicio.Value;
            }
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            if (checkFechas(dtpInicio.Value, dtpFin.Value)) 
            {
                dtpInicio.Value = dtpFin.Value;
            }
        }

        private bool checkFechas(DateTime fecha1, DateTime fecha2)
        {
            int resultado = DateTime.Compare(fecha1, fecha2);

             
            if (resultado > 0)
            {
                MessageBox.Show("La fecha en inicial no puede ser posterior a la fecha final");
                return true;
            }
            return false;
            

        }
        public void Initialize()
        {
            ventas = new VentasDAO().getAllData();
            dgvVentas.DataSource = ventas;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Columns["ID_USUARIO"].Visible = false;
            dgvVentas.ClearSelection();


        }
    }
}

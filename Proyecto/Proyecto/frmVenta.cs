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

namespace PROYECTO_U3
{
    public partial class frmVenta : Form
    {
        List<Venta> ventas;
        public frmVenta(bool corte)
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAEVenta frm = new frmAEVenta();
            frm.Show();
        }

        public void Initialize()
        {
            ventas = new VentasDAO().getAllData();
            dgvVentas.DataSource = ventas;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Columns["ID"].Visible = false;
            dgvVentas.ClearSelection();


        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu(false);
            menu.Show();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            checkFechas(dtpInicio.Value,dtpFin.Value);
        }

        private void checkFechas(DateTime fecha1, DateTime fecha2)
        {
            // Comparar las fechas
            int resultado = DateTime.Compare(fecha1, fecha2);

            // Verificar el resultado
            if (resultado < 0)
            {
                MessageBox.Show("La fecha en dateTimePicker1 es anterior a la fecha en dateTimePicker2.");
            }
            else if (resultado > 0)
            {
                MessageBox.Show("La fecha en dateTimePicker1 es posterior a la fecha en dateTimePicker2.");
            }
            else
            {
                MessageBox.Show("Las fechas en ambos DateTimePickers son iguales.");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            

            if (dgvVentas.SelectedRows.Count > 0)
            {
                // Obtener la primera fila seleccionada (en caso de que haya múltiples filas seleccionadas)
                int index = dgvVentas.SelectedRows[0].Index;

                frmAEVenta frm = new frmAEVenta();
                frm.Show();
                this.Hide();


            }
            else
            {
                // Si no hay filas seleccionadas, manejar el caso en consecuencia
                MessageBox.Show("No se ha seleccionado ninguna fila.");
            }
        }
    }
}

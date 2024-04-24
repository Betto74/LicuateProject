using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        frmLogin login;
        bool corte;
        bool atras = true;
        public frmVenta(bool corte,frmLogin login)
        {
            InitializeComponent();
            
            if (!corte)
            {
                
                Initialize(true);
                lblCant.Visible = false;
                lblCantidad.Visible= false;
                lblPTotal.Visible= false;
                lblTotal.Visible= false;
            }
            else
            {
                btnTodo.Visible = false;
                btnAgregar.Visible = false;
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
                btnFiltrar.Text = "Generar";
            }
            this.corte = corte;
            this.login = login;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Initialize(false);
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            Initialize(true);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            atras = false;
            
            frmAEVenta frm = new frmAEVenta(-1,login);
            frm.Show();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {


            if (dgvVentas.SelectedRows.Count > 0)
            {

                int index = dgvVentas.SelectedRows[0].Index;
                int id = Convert.ToInt32(dgvVentas.Rows[index].Cells[0].Value);
                atras = false;
                frmAEVenta frm = new frmAEVenta(id, login);
                frm.Show();
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
            if (dgvVentas.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar la venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
                int index = dgvVentas.SelectedRows[0].Index;
                if (new VentasDAO().delete(ventas[index].ID))
                {
                     Initialize(true);
                    MessageBox.Show("Se ha eliminado correctamente");
                }
                else 
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
            else
            {

                MessageBox.Show("No se ha seleccionado ninguna fila.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
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
        public void Initialize(bool todas)
        {
            if (todas)
            {
                ventas = new VentasDAO().getAllData();
            }
            else {
                DateTime fechaI = dtpInicio.Value, fechaF = dtpFin.Value;
                string fechaInicio = fechaI.ToString("yyyy-MM-dd");
                string fechaFin = fechaF.ToString("yyyy-MM-dd");


                ventas = new VentasDAO().getRange(fechaInicio, fechaFin);
        

                if (corte)
                {
                    lblCant.Text = ventas.Count.ToString();
                    lblPTotal.Text = "$" + ventas.Sum(objeto => objeto.MONTO);
                }
            }
            dgvVentas.DataSource = ventas;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Columns["ID_USUARIO"].Visible = false;
            dgvVentas.ClearSelection();


        }

        private void frmVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frmVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (atras) {
                frmMenu menu = new frmMenu(login);
                menu.Show();    
            }
        }
    }
}

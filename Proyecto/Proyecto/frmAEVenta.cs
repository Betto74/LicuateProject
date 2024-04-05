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
    public partial class frmAEVenta : Form
    {
        public frmAEVenta()
        {
            InitializeComponent();
            Redondear r = new Redondear();
            r.RedondearDgv(dgvOrden, 40);
            r.RedondearBoton(btnAceptar, 30);
            r.RedondearBoton(btnAgregar, 30);
            r.RedondearBoton(btnEditar, 30);
            r.RedondearBoton(btnEliminar, 30);
            r.RedondearBoton(btnVolver, 30);
        }




        private void fillData(Venta v)
        {
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVenta frm = new frmVenta(false);
            frm.Show();
        }
    }
}

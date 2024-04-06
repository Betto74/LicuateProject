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
    public partial class frmMenu : Form
    {
        frmLogin login;
        public frmMenu(bool admin, frmLogin log)
        {
            InitializeComponent();

            Redondear r = new Redondear();
            r.RedondearBoton(btnVentas, 30);
            r.RedondearBoton(btnRegistrar, 30);
            r.RedondearBoton(btnProductos, 30);
            r.RedondearBoton(btnCorte, 30);

            if(!admin)
            {
                btnRegistrar.Visible = false;
            }
            this.login = log;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrar frmRegistrar = new frmRegistrar();
            frmRegistrar.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVenta venta = new frmVenta(false);
            venta.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.Show();
            this.Hide();
        }

        private void btnCorte_Click(object sender, EventArgs e)
        {
            frmVenta venta = new frmVenta(true);
            venta.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {     
            login.Show();
        }

        
    }
}

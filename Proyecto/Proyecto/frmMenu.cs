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
        private int cargo;
        public frmMenu(bool admin)
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
            this.Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.Show();
            this.Close();
        }

        private void btnCorte_Click(object sender, EventArgs e)
        {
            frmVenta venta = new frmVenta(true);
            venta.Show();
            this.Close();
        }
    }
}

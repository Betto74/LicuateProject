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
    public partial class frmMenu : Form
    {
        frmLogin login;
        bool atras = true;
        public frmMenu(frmLogin log)
        {
            InitializeComponent();

            Redondear r = new Redondear();
            r.RedondearBoton(btnVentas, 30);
            r.RedondearBoton(btnRegistrar, 30);
            r.RedondearBoton(btnProductos, 30);
            r.RedondearBoton(btnVolver, 30);
            r.RedondearBoton(btnCorte, 30);

            
            if(log.user.CARGO=="Admin")
            {
                btnRegistrar.Visible = true;
            }
            else
            {
                btnRegistrar.Visible = false;
            }

      
            this.login = log;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrar frmRegistrar = new frmRegistrar(login);
            frmRegistrar.Show();
            atras = false;
            this.Close();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVenta venta = new frmVenta(false, login);
            venta.Show();
            atras = false;
            this.Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos(login);
            productos.Show();
            atras = false;
            this.Close();
        }

        private void btnCorte_Click(object sender, EventArgs e)
        {
            frmVenta venta = new frmVenta(true, login);
            venta.Show();
            atras = false;
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            login.Show();
            atras = false;
            this.Close();
            
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (atras) {
                login.Show();
            }
        }
    }
}

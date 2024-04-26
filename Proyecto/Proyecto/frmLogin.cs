using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Modelos;

namespace PROYECTO_U3
{
    
    public partial class frmLogin : Form
    {
        private bool cargo;
        public Usuario user;

        frmPantallaCarga carga;
        public frmLogin(frmPantallaCarga carga)
        {
            InitializeComponent();
          
            Redondear r = new Redondear();
            r.RedondearPicture(ptbBack, 40);
            r.RedondearBoton(btnAceptar, 30);

            this.carga = carga;

            this.StartPosition = FormStartPosition.CenterScreen;

        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            aceptar();
        }

        private void aceptar()
        {

            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show(this, "No pueden existir campos vacios");
                return;
            }

            LoginDAO consultas = new LoginDAO();
            user = consultas.getUser(txtUser.Text,txtPassword.Text);
            
            if (user != null)
            {
                
                
                this.Hide();
                frmMenu frmMenu = new frmMenu(this);
                frmMenu.Show();
                
                txtPassword.Text = "";
                txtUser.Text = "";
            }
            else
            {
                MessageBox.Show(this, "El usuario o el password son incorrectos");
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            carga.Close();
        }
    }

}

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

namespace PROYECTO_U3
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
          
            Redondear r = new Redondear();
            r.RedondearPicture(ptbBack, 40);
            r.RedondearBoton(btnAceptar, 30);
      
       

            

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show(this, "No pueden existir campos vacios");
                return;
            }

            LoginDAO consultas = new LoginDAO();
            if (consultas.Login(txtUser.Text,txtPassword.Text) > 0)
            {
                frmMenu frmMenu = new frmMenu();
                frmMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show(this, "El usuario o el password son incorrectos");
            }
        }
    }

}

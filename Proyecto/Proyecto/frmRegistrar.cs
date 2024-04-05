using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace PROYECTO_U3
{
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
            Redondear r = new Redondear();
            r.RedondearPicture(ptbBack, 40);
            r.RedondearBoton(btnAceptar, 30);
        }

        private void lblTittle_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtUser.Text.Equals("") || txtPassword.Text.Equals("") || txtConfirm.Text.Equals(""))
            {
                MessageBox.Show(this,"No se puede dejar ningun espacio vacio");
                return;
            }

            if (!txtPassword.Text.Equals(txtConfirm.Text))
            {
                MessageBox.Show(this, "Las contraseñas no son iguales");
                return;
            }

            LoginDAO consultas = new LoginDAO();
            if (consultas.register(txtNombre.Text, txtUser.Text, txtPassword.Text))
            {
                MessageBox.Show(this, "Se ha registrado correctamente");
                this.Close ();
            }
            else
            {
                MessageBox.Show(this, "Algo ha salido mal");
            }
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

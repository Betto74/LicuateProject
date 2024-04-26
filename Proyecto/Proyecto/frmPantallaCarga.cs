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
    public partial class frmPantallaCarga : Form
    {
        public frmPantallaCarga()
        {
            InitializeComponent();
         
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.020;
            if (Opacity == 0.0)
            {
                timer1.Stop();
                
                frmLogin frm = new frmLogin(this);
                frm.Show();
                this.Hide();
            }
        }
    }
}

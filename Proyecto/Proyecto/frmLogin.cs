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
       
    }

}

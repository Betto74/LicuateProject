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
        public frmMenu()
        {
            InitializeComponent();

            Redondear r = new Redondear();
            r.RedondearBoton(btnVentas, 30);
            r.RedondearBoton(btnRegistrar, 30);
            r.RedondearBoton(btnProductos, 30);
            r.RedondearBoton(btnCorte, 30);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_U3
{
    internal class Redondear
    {
        public void RedondearTextBox(TextBox textbox, int radio)
        {
            // Crear un gráfico de la forma del PictureBox
       
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddArc(0, 0, radio, radio, 180, 90);
            grPath.AddArc(textbox.Width - radio, 0, radio, radio, 270, 90);
            grPath.AddArc(textbox.Width - radio, textbox.Height - radio, radio, radio, 0, 90);
            grPath.AddArc(0, textbox.Height - radio, radio, radio, 90, 90);
            grPath.CloseAllFigures();

            // Establecer la región del PictureBox como la región definida

            textbox.Region = new Region(grPath);
        }

        public void RedondearDgv(DataGridView dgv, int radio)
        {
            // Crear un gráfico de la forma del PictureBox
            
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddArc(0, 0, radio, radio, 180, 90);
            grPath.AddArc(dgv.Width - radio, 0, radio, radio, 270, 90);
            grPath.AddArc(dgv.Width - radio, dgv.Height - radio, radio, radio, 0, 90);
            grPath.AddArc(0, dgv.Height - radio, radio, radio, 90, 90);
            grPath.CloseAllFigures();

            // Establecer la región del PictureBox como la región definida

            dgv.Region = new Region(grPath);
        }

        public void RedondearBoton(Button button, int radio)
        {
            // Crear un gráfico de la forma del PictureBox
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddArc(0, 0, radio, radio, 180, 90);
            grPath.AddArc(button.Width - radio, 0, radio, radio, 270, 90);
            grPath.AddArc(button.Width - radio, button.Height - radio, radio, radio, 0, 90);
            grPath.AddArc(0, button.Height - radio, radio, radio, 90, 90);
            grPath.CloseAllFigures();

            // Establecer la región del PictureBox como la región definida

            button.Region = new Region(grPath);


        }

        public void RedondearPicture(PictureBox pictureBox, int radio)
        {
            // Crear un gráfico de la forma del PictureBox
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddArc(0, 0, radio, radio, 180, 90);
            grPath.AddArc(pictureBox.Width - radio, 0, radio, radio, 270, 90);
            grPath.AddArc(pictureBox.Width - radio, pictureBox.Height - radio, radio, radio, 0, 90);
            grPath.AddArc(0, pictureBox.Height - radio, radio, radio, 90, 90);
            grPath.CloseAllFigures();

            // Establecer la región del PictureBox como la región definida
            pictureBox.Region = new Region(grPath);
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class FormaDePago : Form
    {
        public FormaDePago()
        {
            InitializeComponent();
        }

        int PosX = 0, PosY = 0;

        private void MoverXTitulo(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                PosX = e.X;
                PosY = e.Y;
            }
            else
            {
                Left = Left + (e.X - PosX);
                Top = Top + (e.Y - PosY);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Ventas_y_Servicios F1 = Owner as Ventas_y_Servicios;
            F1.Visible = true;
            this.Close();
        }

        private void MoverXPanel(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                PosX = e.X;
                PosY = e.Y;
            }
            else
            {
                Left = Left + (e.X - PosX);
                Top = Top + (e.Y - PosY);
            }
        }
    }
}

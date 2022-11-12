using System;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class Config : Form
    {
        FormWeb Web = new FormWeb();

        public Config()
        {
            InitializeComponent();
        }

        int PosX = 0, PosY = 0;

        private void FormXTitu(object sender, MouseEventArgs e)
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

        private void Cerrar_Click(object sender, EventArgs e)
        {
            FormAdmin Admin = Owner as FormAdmin;
            Admin.Visible = true;
            this.Close();
        }

        private void btnWeb_Click(object sender, EventArgs e)
        {
            Web.Show();
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

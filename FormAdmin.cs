using System;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class FormAdmin : Form
    {
        AdminStock AS = new AdminStock();
        Login f3 = new Login();
        Turnos Tur = new Turnos();

        public FormAdmin()
        {
            InitializeComponent();
            this.AddOwnedForm(AS);
        }

        int PosY = 0;
        int PosX = 0;

        private void btnAdminServicios_Click(object sender, EventArgs e)
        {
            Ventas_y_Servicios f1 = new Ventas_y_Servicios();
            this.AddOwnedForm(f1);
            if (f1.Visible == false)
            {
                f1.Visible = true;
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
                f1.Visible = false;
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            f3.Close();
        }

        private void btnAdminStock_Click(object sender, EventArgs e)
        {
            if (AS.Visible == false)
            {
                AS.Visible = true;
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
                AS.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanelSup_MouseMove(object sender, MouseEventArgs e)
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
        } //Mover X panel

        private void MoverXTitu(object sender, MouseEventArgs e)
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

        private void btnAdminTurnos_Click(object sender, EventArgs e)
        {
            if (Tur.Visible == false)
            {
                Tur.Visible = true;
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
                Tur.Visible = false;
            }
        }
    }
}

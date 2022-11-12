using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPeluquería.Form_de_Servicios_y_Ventas
{
    public partial class FormEmpleados : Form
    {
        Login f3 = new Login();

        public FormEmpleados()
        {
            InitializeComponent();
        }

        int PosY = 0;
        int PosX = 0;

        private void btnAdminTurnos_Click(object sender, EventArgs e)
        {
            Turnos Tur = new Turnos();
            this.AddOwnedForm(Tur);
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

        private void PanelSup_MouseUp(object sender, MouseEventArgs e)
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

        private void PanelSup_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormEmpleados_FormClosed(object sender, FormClosedEventArgs e)
        {
            f3.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            this.AddOwnedForm(config);
            if (config.Visible == false)
            {
                config.Visible = true;
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
                config.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            this.AddOwnedForm(config);
            if (config.Visible == false)
            {
                config.Visible = true;
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
                config.Visible = false;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login login = Owner as Login;
            login.Visible = true;
            this.Close();
        }

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
    }
}

using System;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class FormEmpleado : Form
    {

        Turnos Tur = new Turnos();
        Login f3 = new Login();

        public FormEmpleado()
        {
            InitializeComponent();
        }

        int PosY = 0;
        int PosX = 0;

        private void btnAdminTurnos_Click(object sender, EventArgs e)
        {
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            f3.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login login = Owner as Login;
            login.Visible = true;
            this.Close();
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

        private void Hoy_Tick(object sender, EventArgs e)
        {
            Hoy.Interval = 300;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            StockEmpleado SE = new StockEmpleado();
            this.AddOwnedForm(SE);
            if (SE.Visible == false)
            {
                SE.Visible = true;
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
                SE.Visible = false;
            }
        }
    }
}

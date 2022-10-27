﻿using System;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class FormAdmin : Form
    {
        AdminStock AS = new AdminStock();
        Login f3 = new Login();

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

        private void btnAdminEmpleados_Click(object sender, EventArgs e)
        {
            Empleados emp = new Empleados();
            this.AddOwnedForm(emp);
            if (emp.Visible == false)
            {
                emp.Visible = true;
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
                emp.Visible = false;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login login = Owner as Login;
            login.Visible = true;
            this.Close();
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
    }
}

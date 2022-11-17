using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class Config : Form
    {
        DataBase DataB = new DataBase();
        public Config()
        {
            InitializeComponent();
            CrearHorarios();
        }

        int PosX = 0, PosY = 0;
        public void CrearHorarios()
        {
            for (int i = 0; i <= 24;i++)
            {
                if(i<13)
                {
                    comboBox1.Items.Add(i + ":00:00");
                    comboBox2.Items.Add(i + ":00:00");
                }
                else
                {
                    comboBox3.Items.Add(i + ":00:00");
                    comboBox4.Items.Add(i + ":00:00");
                }
            }
            comboBox1.Text = Properties.Settings.Default.HMI;
            comboBox2.Text = Properties.Settings.Default.HMF;
            comboBox3.Text = Properties.Settings.Default.HTI;
            comboBox4.Text = Properties.Settings.Default.HTF;
        }
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
            System.Diagnostics.Process.Start("log.txt");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se activara automaticamente la proxima vez que se iniciar el programa, desea continuar?", "WhatsApp API(?", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.WhatsAppStart = true;
                Properties.Settings.Default.Save();
                label6.ForeColor = Color.ForestGreen;
                label4.ForeColor = Color.Black;
            }
            else
            {
                Console.WriteLine("Tuvo miedo al exito.");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Maroon;
            label6.ForeColor = Color.Black;
            Properties.Settings.Default.WhatsAppStart = false;
            Properties.Settings.Default.Save();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HMI = comboBox1.Text;
            Properties.Settings.Default.HMF = comboBox2.Text;
            Properties.Settings.Default.HTI = comboBox3.Text;
            Properties.Settings.Default.HTF = comboBox4.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Se guardo exitosamente");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            reg.SetValue("Projecto Peluqueria", Application.ExecutablePath.ToString());
            MessageBox.Show("Inicio Automatico:Activo.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Exito = DataB.Verificacion();
            if(Exito)
            {
                MessageBox.Show("SQL Verificada y Activa");
            }
            else
            {
                MessageBox.Show("SQL Verificada. No activa");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Iniciar sesion en WhatsAppWeb, una vez inciado reiniciar programa");
            FormWeb FW = new FormWeb();
            FW.Show();
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

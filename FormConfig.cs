using Microsoft.Win32;
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
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        private void txtSQL_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(txtServer.Text);
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdmin F1 = Owner as FormAdmin;
            F1.Visible = true;
        }

        private void InicioAutomatico_Click(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            reg.SetValue("Peluqueria", Application.ExecutablePath.ToString());
            MessageBox.Show("Inicio Automatico:Activo.");
        }
    }
}

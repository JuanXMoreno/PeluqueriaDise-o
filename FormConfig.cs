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
    }
}

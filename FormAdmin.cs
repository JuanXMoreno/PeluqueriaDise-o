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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnAdminServicios_Click(object sender, EventArgs e)
        {
            Ventas_y_Servicios f1 = new Ventas_y_Servicios();
            f1.Show();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login f3 = new Login();
            f3.Close();
        }
    }
}

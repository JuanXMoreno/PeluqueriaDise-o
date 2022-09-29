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
    public partial class Form3 : Form
    {
        public Form3()
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
            Form2 f3 = new Form2();
            f3.Show();
        }
    }
}

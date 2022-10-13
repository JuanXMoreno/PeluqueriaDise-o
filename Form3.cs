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

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void btnAdminEmpleados_Click(object sender, EventArgs e)
        {
            Empleados form4 = new Empleados();
            form4.Show();
        }

        private void btnAdminTurnos_Click(object sender, EventArgs e)
        {
            Turnos turn = new Turnos();
            turn.Show();
            //this.Hide();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}

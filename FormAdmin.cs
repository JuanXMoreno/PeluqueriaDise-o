using System;
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
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login f2 = new Login();
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
            Login frm = new Login();
            frm.Show();
        }
    }
}

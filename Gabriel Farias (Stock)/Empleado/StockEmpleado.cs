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
    public partial class StockEmpleado : Form
    {
        //Clase
        DataBase DataB = new DataBase();
        public StockEmpleado()
        {
            InitializeComponent();
            Vista.DataSource = DataB.ActualizarLista(null);
            Vista.Columns[0].Visible = false;
            Vista.Columns[5].Visible = false;
        }
        int PosX = 0, PosY = 0;
        private void BuscadorContinuo_Tick(object sender, EventArgs e)
        {
            Vista.DataSource = DataB.ActualizarLista(BoxBusqueda.Text);
        }
        private void Reloj_Tick(object sender, EventArgs e)
        {
            label2.Text = DataB.InfoProductos();
            Reloj.Interval = 300000;
        }
        private void btnF5_Click(object sender, EventArgs e)
        {
            BoxBusqueda.Clear();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormEmpleado FE = Owner as FormEmpleado;
            FE.Visible = true;
            this.Close();
        }
        private void StockEmpleado_Validated(object sender, EventArgs e)
        {
            Vista.DataSource = DataB.ActualizarLista(null);
            label2.Text = DataB.InfoProductos();
            Console.WriteLine("Se actualizo la tabla del Form stock empleados");
        }
        private void BoxBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            Vista.DataSource = DataB.ActualizarLista(BoxBusqueda.Text);
        }
        public void MoverForm(object sender, MouseEventArgs e)
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

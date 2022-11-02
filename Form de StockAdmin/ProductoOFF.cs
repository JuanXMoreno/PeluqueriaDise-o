using System;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class ProductoOFF : Form
    {
        //sql
        DataBase DataB = new DataBase();
        public ProductoOFF()
        {
            InitializeComponent();
            dataGridView1.DataSource = DataB.ProductosOFF(null);
        }
        int ID = 0;
        int PosY = 0;
        int PosX = 0;


        private void BtnBusqueda_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataB.ProductosOFF(BoxBusqueda.Text);
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataB.ProductosOFF(null);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            DataB.LevantarProducto(ID.ToString());
            dataGridView1.DataSource = DataB.ActualizarLista(null);
            Seleccion.Text = "Se selecciono:";
        }

        private void SeleccionarCelda(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Seleccion.Text = "Se selecciono: " + ID;
        }

        private void Cerrar(object sender, EventArgs e)
        {
            AdminStock AS = Owner as AdminStock;
            AS.Visible = true;
            this.Close();
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
    }
}

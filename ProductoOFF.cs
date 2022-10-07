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
        }

        private void SeleccionarCelda(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Seleccion.Text = "Se selecciono: " + ID;
        }
    }
}

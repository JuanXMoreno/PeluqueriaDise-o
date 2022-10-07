using System;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class VisorDeBajas : Form
    {
        DataBase DataB = new DataBase();
        public VisorDeBajas()
        {
            InitializeComponent();
            dataGridView1.DataSource = DataB.EliminarProducto(null);
        }

        private void BtnBusqueda_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataB.ActualizarLista(TexboxBuscador.Text);
        }

        private void F5(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataB.EliminarProducto(null);
        }
    }
}

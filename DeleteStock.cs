using System;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class DeleteStock : Form
    {
        //Clase
        DataBase DataB = new DataBase();

        int DeleteID = 0;
        public DeleteStock()
        {
            InitializeComponent();
            dataGridView1.DataSource = DataB.ActualizarLista(null);
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            BoxBusqueda.Clear();
            dataGridView1.DataSource = DataB.ActualizarLista(null);
        }

        private void BtnBusqueda_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataB.ActualizarLista(BoxBusqueda.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar el Producto ID:" + DeleteID + "?", "Dar de Baja", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DataB.EliminarProducto(DeleteID.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Seleccion.Text = "Se selecciono: " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}

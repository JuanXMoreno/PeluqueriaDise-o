using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class DeleteStock : Form
    {
        DataBase DataB = new DataBase();
        public DeleteStock()
        {
            InitializeComponent();
            dataGridView1.DataSource = DataB.ActualizarLista(null);
        }

        private void Eliminar(object sender, EventArgs e)
        {
            DataB.BajaLogicaProducto(textBox1.Text);
        }

        private void Buscar(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataB.ActualizarLista(TexboxBuscador.Text);
        }

        private void SeleccionarVista(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}

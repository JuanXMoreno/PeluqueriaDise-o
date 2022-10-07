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
    public partial class VisorDeBajas : Form
    {
        DataBase DataB = new DataBase();
        public VisorDeBajas()
        {
            InitializeComponent();
            dataGridView1.DataSource = DataB.BajasProductos(null);
        }

        private void BtnBusqueda_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataB.ActualizarLista(TexboxBuscador.Text);
        }

        private void F5(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataB.BajasProductos(null);
        }
    }
}

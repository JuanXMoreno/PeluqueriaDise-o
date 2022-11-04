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
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[0].Visible = false;
        }

        int PosY = 0;
        int PosX = 0;

        private void btnF5_Click(object sender, EventArgs e)
        {
            BoxBusqueda.Clear();
        }

        private void BtnBusqueda_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataB.ActualizarLista(BoxBusqueda.Text);
        }

        private void Buscar(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar el Producto ID:" + DeleteID + "?", "Dar de Baja", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DataB.EliminarProducto(DeleteID.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex <= dataGridView1.RowCount)
                {
                    Console.Write("Se selecciono un dato");
                    DeleteID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    Seleccion.Text = "Se selecciono: " + DeleteID;
                }
            }
            catch (Exception er)
            {
                Console.WriteLine("Error: " + er);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataB.EliminarProducto(DeleteID.ToString());
            dataGridView1.DataSource = DataB.ActualizarLista(null);
            Seleccion.Text = "Se selecciono:";
        }

        private void MoverPanel(object sender, MouseEventArgs e)
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

        private void cerrar(object sender, EventArgs e)
        {
            AdminStock AS = Owner as AdminStock;
            AS.Visible = true;
            this.Close();
        }
    }
}

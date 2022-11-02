using System;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class ModStock : Form
    {
        //Clase
        DataBase dt = new DataBase();
        public ModStock()
        {
            InitializeComponent();
            Vistas.DataSource = dt.ActualizarLista(null);
            Vistas.Columns[0].Visible = false;
        }

        int PosY = 0;
        int PosX = 0;

        private void BtnBusqueda_Click(object sender, EventArgs e)
        {
            Vistas.DataSource = dt.ActualizarLista(textBox1.Text);
        }

        private void Vistas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Idtex.Text = Vistas.Rows[e.RowIndex].Cells[0].Value.ToString();
            Nombre.Text = Vistas.Rows[e.RowIndex].Cells[1].Value.ToString();
            Stock.Text = Vistas.Rows[e.RowIndex].Cells[2].Value.ToString();
            precio.Text = Vistas.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            dt.ModificarProducto(Idtex.Text, Nombre.Text, Stock.Text, precio.Text);
            Vistas.DataSource = dt.ActualizarLista(null);
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
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

        private void Cerrar(object sender, EventArgs e)
        {
            AdminStock AS = Owner as AdminStock;
            AS.Visible = true;
            this.Close();
        }
    }
}

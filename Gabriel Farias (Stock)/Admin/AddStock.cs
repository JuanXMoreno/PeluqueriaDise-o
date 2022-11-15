using System;
using System.IO;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class AddStock : Form
    {
        //Clase
        DataBase DataB = new DataBase();
        byte[] ruta = null;
        public AddStock()
        {
            InitializeComponent();
        }
        int PosY = 0;
        int PosX = 0;

        public void Limpiar()
        {
            Nombre.Clear();
            Stock.Clear();
            precio.Clear();
        }

        private void BtnAgregar(object sender, EventArgs e)
        {
            DataB.AgregarProducto(ruta, Nombre.Text, Stock.Text, precio.Text);
            Limpiar();
        }

        private void PanelSup_MouseMove(object sender, MouseEventArgs e)
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

        private void Cerrar(object sender, EventArgs e)
        {
            AdminStock AS = Owner as AdminStock;
            AS.Visible = true;
            this.Close();
        }

        private void Nombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Stock.Focus();
            }
        }

        private void Stock_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                precio.Focus();
            }
        }

        private void precio_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataB.AgregarProducto(ruta, Nombre.Text, Stock.Text, precio.Text);
                Limpiar();
            }
        }

        private void btnImagenUp_Click(object sender, EventArgs e)
        {
            if (SubirImagen.ShowDialog() == DialogResult.OK)
            {
                Stream MiStream = SubirImagen.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    MiStream.CopyTo(ms);
                    ruta = ms.ToArray();
                }
            }
        }
    }
}

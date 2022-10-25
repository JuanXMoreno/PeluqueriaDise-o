using System;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class AddStock : Form
    {
        //Clase
        DataBase DataB = new DataBase();
        public AddStock()
        {
            InitializeComponent();
        }
        int PosY = 0;
        int PosX = 0;

        private void BtnAgregar(object sender, EventArgs e)
        {
            DataB.AgregarProducto(Nombre.Text, Stock.Text, precio.Text);
            Nombre.Clear();
            Stock.Clear();
            precio.Clear();
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
            this.Visible = false;
            AdminStock AS = Owner as AdminStock;
            AS.Visible = true;
        }
    }
}

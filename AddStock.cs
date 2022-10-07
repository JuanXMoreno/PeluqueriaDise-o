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

        private void BtnAgregar(object sender, EventArgs e)
        {
            DataB.AgregarProducto(Nombre.Text, Stock.Text, precio.Text);
            Nombre.Clear();
            Stock.Clear();
            precio.Clear();
        }
    }
}

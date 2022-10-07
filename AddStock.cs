using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

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
            DataB.AgregarProducto(Nombre.Text,Stock.Text,precio.Text);
            Nombre.Clear();
            Stock.Clear();
            precio.Clear();
        }
    }
}

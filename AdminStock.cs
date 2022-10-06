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
    public partial class AdminStock : Form
    {

        //Forms
        AddStock AddS = new AddStock();
        ModStock ModS = new ModStock();
        DeleteStock DeleS = new DeleteStock();
        VisorDeBajas Baja = new VisorDeBajas();
        //Clase
        DataBase DataB=new DataBase();

        public AdminStock()
        {
            InitializeComponent();
            Vista.DataSource = DataB.ActualizarLista(null);
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            Vista.DataSource = DataB.ActualizarLista(textBox1.Text);
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            label2.Text = DataB.InfoProductos();
            Reloj.Interval = 300000;
        }
        private void AddPro_Click(object sender, EventArgs e)
        {
            if (AddS.Visible == false)
            {
                AddS.Visible = true;
            }
            else
            {
                AddS.Visible = false;
            }
        } // Boton Agregar

        private void ModStock_Click(object sender, EventArgs e)
        {
            if (ModS.Visible == false)
            {
                ModS.Visible = true;
            }
            else
            {
                ModS.Visible = false;
            }
        } // Boton Modificar

        private void BtnDelete(object sender, EventArgs e)
        {
            if (DeleS.Visible == false)
            {
                DeleS.Visible = true;
            }
            else
            {
                DeleS.Visible = false;
            }
        } // Boton Delete

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (Baja.Visible == false)
            {
                Baja.Visible = true;
            }
            else
            {
                Baja.Visible = false;
            }
        }
    }
}

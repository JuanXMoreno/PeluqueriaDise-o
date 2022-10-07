using System;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class AdminStock : Form
    {
        //Forms
        AddStock AddS = new AddStock();
        ModStock ModS = new ModStock();
        DeleteStock DeleS = new DeleteStock();
        ProductoOFF POFF = new ProductoOFF();
        //Clase
        DataBase DataB = new DataBase();

        public AdminStock()
        {
            InitializeComponent();
            Vista.DataSource = DataB.ActualizarLista(null);
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            Vista.DataSource = DataB.ActualizarLista(BoxBusqueda.Text);
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

        private void btnProductOff(object sender, EventArgs e)
        {
            if (POFF.Visible == false)
            {
                POFF.Visible = true;
            }
            else
            {
                POFF.Visible = false;
            }
        } //Btn Productos OFF

        private void btnF5_Click(object sender, EventArgs e)
        {
            BoxBusqueda.Clear();
            Vista.DataSource = DataB.ActualizarLista(null);
        }
    }
}

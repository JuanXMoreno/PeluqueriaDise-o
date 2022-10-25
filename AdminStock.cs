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

        int PosY = 0;
        int PosX = 0;

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
            this.AddOwnedForm(AddS);
            if (AddS.Visible == false)
            {
                AddS.Visible = true;
                this.Visible = false;
            }
            else
            {
                AddS.Visible = false;
                this.Visible = true;
            }
        } // Boton Agregar

        private void ModStock_Click(object sender, EventArgs e)
        {
            this.AddOwnedForm(ModS);
            if (ModS.Visible == false)
            {
                ModS.Visible = true;
                this.Visible = false;
            }
            else
            {
                ModS.Visible = false;
                this.Visible = true;
            }
        } // Boton Modificar

        private void BtnDelete(object sender, EventArgs e)
        {
            this.AddOwnedForm(DeleS);
            if (DeleS.Visible == false)
            {
                DeleS.Visible = true;
                this.Visible = false;
            }
            else
            {
                DeleS.Visible = false;
                this.Visible = true;
            }
        } // Boton Delete

        private void btnProductOff(object sender, EventArgs e)
        {
            this.AddOwnedForm(POFF);
            if (POFF.Visible == false)
            {
                POFF.Visible = true;
                this.Visible = false;
            }
            else
            {
                POFF.Visible = false;
                this.Visible = true;
            }
        } //Btn Productos OFF

        private void btnF5_Click(object sender, EventArgs e)
        {
            BoxBusqueda.Clear();
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


        private void Cerrar(object sender, EventArgs e)
        {
            FormAdmin FA= Owner as FormAdmin;
            this.Visible = false;
            FA.Visible = true;
        }

        private void MoverTitulo(object sender, MouseEventArgs e)
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
    }
}

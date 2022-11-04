using System;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class AdminStock : Form
    {
        //Clase
        DataBase DataB = new DataBase();

        public AdminStock()
        {
            InitializeComponent();
            Vista.DataSource = DataB.ActualizarLista(null);
            Vista.Columns[0].Visible = false;
            Vista.Columns[5].Visible = false;
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
            AddStock AddS = new AddStock();
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
            ModStock ModS = new ModStock();
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
            DeleteStock DeleS = new DeleteStock();
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
            ProductoOFF POFF = new ProductoOFF();
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
            FormAdmin FA = Owner as FormAdmin;
            FA.Visible = true;
            this.Close();
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

        private void AdminStock_Activated(object sender, EventArgs e)
        {
            Vista.DataSource = DataB.ActualizarLista(null);
            label2.Text = DataB.InfoProductos();
            Console.WriteLine("Se actualizo la tabla del Form stock");
        }
    }
}

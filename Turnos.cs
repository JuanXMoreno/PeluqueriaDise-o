using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ProyectoPeluquería
{
    public partial class Turnos : Form
    {
        private int n = 0;
        int EspacioTotales = 0;

        SqlConnection conexion = new SqlConnection(DataBase.link);
        //DataBase
        DataBase DataB = new DataBase();
        public Turnos()
        {
            InitializeComponent();
            dgvDatos.DataSource = DataB.ActualizarListaTurnos();
            cmbPeluquero.DataSource = DataB.ExtraerEmpleados();
            CargarHorarios();
        }

        int PosX = 0, PosY = 0;

        public void CargarHorarios()
        {
            String[] HMIS = Properties.Settings.Default.HMI.Split(':');
            String[] HMFS = Properties.Settings.Default.HMF.Split(':');
            String[] HTIS = Properties.Settings.Default.HTI.Split(':');
            String[] HTFS = Properties.Settings.Default.HTF.Split(':');

            int HMI = Convert.ToInt32(HMIS[0]);
            int HMF = Convert.ToInt32(HMFS[0]);
            int HTI = Convert.ToInt32(HTIS[0]);
            int HTF = Convert.ToInt32(HTFS[0]);

            int EntreMañana = HMF - HMI;
            int EntreTarde = HTF - HTI;

            DateTime InicioM = Convert.ToDateTime(HMI+":00");
            DateTime InicioT = Convert.ToDateTime(HTI + ":00");
            Horarios.Items.Add(InicioM.ToShortTimeString() + ":00");
            for (int i = 0; i<(EntreMañana);i++)
            {
                InicioM += TimeSpan.FromMinutes(60);
                Horarios.Items.Add(InicioM.ToShortTimeString()+":00");
                EspacioTotales++;
            }
            Horarios.Items.Add(InicioT.ToShortTimeString() + ":00");
            for (int i = 0; i < (EntreTarde); i++)
            {
                InicioT += TimeSpan.FromMinutes(60);
                Horarios.Items.Add(InicioT.ToShortTimeString() + ":00");
                EspacioTotales++;
            }
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            String[] ExtraEmpleado = cmbPeluquero.Text.Split('.');
            int idEmpleado = Convert.ToInt32(ExtraEmpleado[0]);
            DataB.CrearTurno(txtCliente.Text,TxtBNum.Text,FechaNac.Text.Replace("/","-"),txtDia.Text.Replace("/", "-") + " "+Horarios.Text,idEmpleado);
            FormWeb FW = Owner as FormWeb;
            if(TxtBNum.Text != null || TxtBNum.Text != string.Empty)
            {
                FW.AddCola(TxtBNum.Text);
            }
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvDatos.Rows.RemoveAt(n);
           
        }

        private void Cerrarpic_Click(object sender, EventArgs e)
        {
            FormAdmin F1 = Owner as FormAdmin;
            F1.Visible = true;
            this.Close();
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
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

        private void pbF5_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = DataB.ActualizarListaTurnos();
        }

        private void txtDia_CloseUp(object sender, EventArgs e)
        {
            VDH();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void txtDia_ValueChanged(object sender, EventArgs e)
        {
            VDH();
        }

        private void TxtBNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == '+')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void PanelSup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MoverXPanel(object sender, MouseEventArgs e)
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

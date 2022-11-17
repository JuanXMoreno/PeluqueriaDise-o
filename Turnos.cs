using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;


namespace ProyectoPeluquería
{
    public partial class Turnos : Form
    {
        private int n = 0;
        int EspacioTotales = 0;
        int ID = 0;

        SqlConnection conexion = new SqlConnection(DataBase.link);
        //DataBase
        DataBase DataB = new DataBase();
        FormWeb FW = new FormWeb();
        public Turnos()
        {
            InitializeComponent();
            dgvDatos.DataSource = DataB.ActualizarListaTurnos();
            cmbPeluquero.DataSource = DataB.ExtraerEmpleados();
            dgvDatos.Columns[0].Visible = false;
            CargarHorarios();
            AbrirWhatsApp();
        }


        public void AbrirWhatsApp()
        {
            if (Properties.Settings.Default.WhatsAppStart == true)
            {
                FW.Show(); FW.Visible = false;
            }
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
            bool Exito = DataB.CrearTurno(txtCliente.Text, TxtBNum.Text, Convert.ToDateTime(FechaNac.Text), Convert.ToDateTime(txtDia.Text+ " " + Horarios.Text), idEmpleado);
            if(Exito)
            {
                if(TxtBNum.Text != null || TxtBNum.Text != String.Empty)
                {
                    FW.AddCola(TxtBNum.Text);
                }
            }
            Reset();
        }
        
        public void Reset()
        {
            txtCliente.ResetText();
            TxtBNum.ResetText();
            FechaNac.ResetText();
            txtDia.ResetText();
            Horarios.ResetText();
            cmbPeluquero.ResetText();
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvDatos.Rows.RemoveAt(n);
           
        }

        private void Cerrarpic_Click(object sender, EventArgs e)
        {
            FormAdmin F1 = Owner as FormAdmin;
            F1.Visible = true;
            this.Hide();
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

                cmd = new SqlCommand("Select * From Turnos", Conectarse);

                Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    Console.WriteLine("Leyendo");
                    for (int i = 0; i < (Horarios.Items.Count - EspacioTotales); i++)
                    {
                        String HorarioB = Lector.GetDateTime(4).ToString();
                        //MessageBox.Show(HorarioB); // Fechas de base de datos

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

        private void Horarios_Click(object sender, EventArgs e)
        {
            VDH();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String[] ExtraEmpleado = cmbPeluquero.Text.Split('.');
            int idEmpleado = Convert.ToInt32(ExtraEmpleado[0]);
            DataB.ModificarTurnos(ID,txtCliente.Text, TxtBNum.Text, Convert.ToDateTime(FechaNac.Text), Convert.ToDateTime(txtDia.Text + " " + Horarios.Text), idEmpleado);
            Reset();
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                ID = Convert.ToInt32(dgvDatos.Rows[e.RowIndex].Cells[0].Value);
                txtCliente.Text = dgvDatos.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtBNum.Text = dgvDatos.Rows[e.RowIndex].Cells[2].Value.ToString();
                FechaNac.Text = dgvDatos.Rows[e.RowIndex].Cells[3].Value.ToString();
                DateTime FechaD = Convert.ToDateTime(dgvDatos.Rows[e.RowIndex].Cells[4].Value.ToString());
                txtDia.Text = FechaD.ToShortDateString();
                DateTime Part = Convert.ToDateTime(dgvDatos.Rows[e.RowIndex].Cells[4].Value.ToString());
                Horarios.Text = Part.ToShortTimeString()+":00";
                cmbPeluquero.Text = dgvDatos.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            else
            {
                Console.WriteLine("Se selecciono otra cosa");
            }
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

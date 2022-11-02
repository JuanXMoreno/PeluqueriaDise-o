﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ProyectoPeluquería
{
    public partial class Turnos : Form
    {
        private int n = 0;

        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-SK840FQ;database=Peluqueria; integrated security=true");
        //DataBase
        DataBase DataB = new DataBase();
        public Turnos()
        {
            InitializeComponent();
            dgvDatos.DataSource = DataB.ActualizarListaTurnos();
            cmbPeluquero.DataSource = DataB.ExtraerEmpleados();
            //cmbPeluquero.ValueMember = "Id_empleado";
            //cmbPeluquero.DisplayMember = "Nombre";
            dgvDatos.Columns[0].Visible = false;
            dgvDatos.Columns[3].Visible = false;
            dgvDatos.Columns[4].Visible = false;
        }

        int PosX = 0, PosY = 0;

        public void consulta()
        {

        }

        private void Turnos_Load(object sender, EventArgs e)
        {
            consulta();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtCliente.Text == "" || cmbPeluquero.SelectedIndex == -1)
            {
                MessageBox.Show("Faltan datos");
            }
            else
            {
                string sql = "insert into Turnos(Dia,Hora,Id_Cliente,Id_Empleado) values ('" + txtDia.Text + "','" + txtHora.Value + "')";
            }
            conexion.Close();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvDatos.Rows.RemoveAt(n);
        }

        private void txtDia_TextChanged(object sender, EventArgs e)
        {
            HabilitarBoton();
        }

        void HabilitarBoton()
        {
            if (txtDia.Text != "" && txtHora.Text != "" && txtCliente.Text != "")
                btnInsertar.Enabled = true;
            else btnInsertar.Enabled = false;
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            HabilitarBoton();
        }

        private void txtHora_ValueChanged(object sender, EventArgs e)
        {
            HabilitarBoton();
        }

        private void cmbPeluquero_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarBoton();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

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

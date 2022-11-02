﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ProyectoPeluquería
{
    public partial class Turnos : Form
    {
        private int n = 0;

        SqlConnection conexion = new SqlConnection("server=DESKTOP-SK840FQ;database=Peluqueria; integrated security=true");

        public void consulta()
        {

            String sql = "select " +  "Id_Turnos,Dia,Hora,Turnos.Id_Cliente,Id_Empleado, Clientes.Nombre AS Cliente from Turnos INNER JOIN Clientes ON Turnos.Id_Cliente = Clientes.Id_Cliente";
            conexion.Open();
            SqlDataAdapter adaptador=new SqlDataAdapter(sql,conexion);
            DataTable tabla =new DataTable();
            adaptador.Fill(tabla);
            dgvDatos.DataSource = tabla;
            dgvDatos.Columns[0].Visible = false;
            dgvDatos.Columns[3].Visible = false;
            dgvDatos.Columns[4].Visible = false;
            //dgvDatos.Columns[3].Visible= false;
            conexion.Close();
        }

        public Turnos()
        {
            InitializeComponent();
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
                string sql = "insert into Turnos(Dia,Hora,Id_Cliente,Id_Empleado,Telefono) values ('" + txtDia.Text + "','" + txtHora.Value + "' '" + txtCliente.Text + "','" + txtTelefono.Text + "')";
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class Mas : Form
    {
        public Mas()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=CELE-PC;database=Peluqueria;integrated security=true");


        private void Mas_Load(object sender, EventArgs e)
        {
            conexion.Open();

            String sql = "select Nombre, Apellido, DNI, Direccion, Telefono, FechaNac as 'Fecha de nacimiento',HorasAsignadas as 'Horas asignadas' from Empleados";
            SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            tablaMas.DataSource = tabla;

            conexion.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

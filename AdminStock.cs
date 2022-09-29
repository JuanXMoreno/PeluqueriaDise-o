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
        public AdminStock()
        {
            InitializeComponent();
        }

        public static string Cadena = @"server=DESKTOP-GGALNHK\SQLEXPRESS01;database=Peluqueria;integrated security=true";
        SqlConnection conn = null;

        public void IniciarSesion()
        {
            conn = new SqlConnection();
            conn.ConnectionString = Cadena;
            conn.Open();

            Console.WriteLine("Se inicio correctamente.");
        }

        public void CerrarSesion()
        {
            conn.Close();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }
    }
}

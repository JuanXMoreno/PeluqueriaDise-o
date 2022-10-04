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
    public partial class ModStock : Form
    {
        public ModStock()
        {
            InitializeComponent();
            MamiMehartedeprogramar();
        }
        //SQL
        public static string Cadena = @"server=DESKTOP-GGALNHK\SQLEXPRESS01;database=Peluqueria;integrated security=true";
        SqlConnection Conectarse = null;
        SqlCommand cmd = null;
        SqlDataReader Lector = null;
        SqlTransaction Tran = null;
        SqlDataAdapter Adaptador = null;

        public void MamiMehartedeprogramar()
        {
            Conectarse = new SqlConnection();
            Conectarse.ConnectionString = Cadena;
            Conectarse.Open();

            cmd = new SqlCommand();
            cmd.CommandText = "Select * From Productos";
            cmd.Connection = Conectarse;
            Adaptador = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            Adaptador.Fill(dt);

            dataGridView1.DataSource = dt;

            Conectarse.Close();
        }
    }
}

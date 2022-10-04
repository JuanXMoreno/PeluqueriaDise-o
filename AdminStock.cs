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

        //Forms
        AddStock AddS = new AddStock();
        ModStock ModS = new ModStock();
        DeleteStock DeleS = new DeleteStock();

        public AdminStock()
        {
            InitializeComponent();
        }

        //SQL
        public static string Cadena = @"server=DESKTOP-GGALNHK\SQLEXPRESS01;database=Peluqueria;integrated security=true";
        SqlConnection Conectarse = null;
        SqlCommand cmd = null;
        SqlDataReader Lector = null;
        SqlTransaction Tran = null;
        SqlDataAdapter Adaptador = null;

        public void IniciarSesion()
        {
            Conectarse = new SqlConnection();
            Conectarse.ConnectionString = Cadena;
            Conectarse.Open();


            Console.WriteLine("Se inicio correctamente.");

        }

        public void CerrarSesion()
        {
            Conectarse.Close();

            Console.WriteLine("Se cerro correctamente.");
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            IniciarSesion();

            cmd = new SqlCommand();
            cmd.CommandText = "Select * From Productos where Nombre like '%"+textBox1.Text+"%'";
            cmd.Connection = Conectarse;
            Adaptador = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            Adaptador.Fill(dt);

            dataGridView1.DataSource = dt;

            CerrarSesion();
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            reloj.Interval = 300000;
            Info();
        }

        public void Info()
        {
            IniciarSesion();

            cmd = new SqlCommand();
            cmd.CommandText = "Select count(*) From Productos";
            cmd.Connection = Conectarse;
            Lector = cmd.ExecuteReader();
            while (Lector.Read())
            {
                label2.Text = "Informacion:  Productos Cargados : " + Lector.GetInt32(0);
            }

            CerrarSesion();
        }

        private void AddPro_Click(object sender, EventArgs e)
        {
            if (AddS.Visible == false)
            {
                AddS.Visible = true;
            }
            else
            {
                AddS.Visible = false;
            }
        }

        private void ModStock_Click(object sender, EventArgs e)
        {
            if (ModS.Visible == false)
            {
                ModS.Visible = true;
            }
            else
            {
                ModS.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DeleS.Visible == false)
            {
                DeleS.Visible = true;
            }
            else
            {
                DeleS.Visible = false;
            }
        }
    }
}

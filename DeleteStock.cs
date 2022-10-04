using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class DeleteStock : Form
    {
        public DeleteStock()
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

        private void button1_Click(object sender, EventArgs e)
        {
            bool Exito = false;
            try
            {
                Conectarse = new SqlConnection();
                Conectarse.ConnectionString = Cadena;
                Conectarse.Open();

                //se inicia la transacción
                Tran = Conectarse.BeginTransaction(System.Data.IsolationLevel.Serializable);

                cmd = new SqlCommand("EliminarProducto", Conectarse, Tran);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));

                SqlParameter Parametros = new SqlParameter("@veri", SqlDbType.Int); //Comando de retorno de datos
                Parametros.Direction = ParameterDirection.Output; //Se asigna la direccion que tendra
                cmd.Parameters.Add(Parametros); //Agregamos el parametro recien creado

                cmd.ExecuteNonQuery(); //Ejecutamos el comando

                int ParametroDeEntrada = 0; //Creamos la variable que guardara el datos de retorno

                ParametroDeEntrada = Convert.ToInt32(Parametros.Value);
                if (ParametroDeEntrada == 1)
                {
                    Exito = true;
                }
            }
            catch (SqlException Errores)
            {
                MessageBox.Show("Algo salio mal..Actual normal: " + Errores);
                Console.WriteLine("Se encontraron errores: " + Errores);
            }
            finally
            {
                if (Exito)
                {
                    Console.WriteLine("Salio bien.");
                    Tran.Commit(); //Confirmacion de base de datos
                    Conectarse.Close(); // Cierro la base de datos feliz de la vida :)
                    MessageBox.Show("Se cargo el servicio con exito.", "Eso tilin :')");
                }
                else
                {
                    Console.WriteLine("Algo salio mal.");
                    Tran.Rollback(); //Se deshace la transacion
                    Conectarse.Close(); // Cierro la base de datos feliz pero enojado :(
                    MessageBox.Show("Algo no salio bien.", "Ok. Nose que mierda paso.");
                }
            }
        }
    }
}

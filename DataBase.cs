using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    class DataBase
    {
        private static string link = @"SERVER=DESKTOP-GGALNHK\SQLEXPRESS01;DATABASE=Peluqueria;integrated security=true"; //Agrege esto para no tener que cambiar manualmente la clave en cada metodo

        public SqlConnection Conectar() //metodo para conectar la base de datos al c#
        {
            SqlConnection cn = new SqlConnection(link);

            cn.Open();

            return cn;
        }

        public SqlConnection Desconectar() //metodo para desconectar la base de datos al c#
        {
            SqlConnection cn = new SqlConnection(link);

            cn.Close();

            return cn;
        }

        public Boolean Verificacion() //metodo para verificar si la base está conectada
        {
            Boolean esVerdadero;

            try
            {
                Conectar();

                esVerdadero = true;
                Console.WriteLine("Se conecto la base de datos");
            }
            catch(SqlException sqlEx)
            {
                MessageBox.Show("Error:"+sqlEx,"Error DataBase");
                esVerdadero = false;
            }
            finally
            {
                Desconectar();
            }
            return esVerdadero;

            //try //Coloco un comando simple para que interactue con la base de datos
            //{
            //    string consulta = "select * from TiposdePago";
            //    SqlCommand comando = new SqlCommand(consulta);
            //    System.Windows.Forms.MessageBox.Show("La base de datos está conectada");
            //    esVerdadero = true;
            //}
            //catch (SqlException) //En caso de no encontrar la tabla porque la bse de datos esta apagada, largará el error y con ello el msg
            //{
            //    System.Windows.Forms.MessageBox.Show("La base de datos NO está conectada");
            //    esVerdadero = false;
            //}
        }

        public DataTable ActualizarLista(String Text)
        {
            DataTable Tabla = new DataTable();
            Tabla.Clear();
            try
            {
                Conectar();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * From Productos where Nombre like '%" +Text+ "%' and Estado = 1";
                cmd.Connection = Conectar();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(Tabla);
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error:\n"+ex);
            }
            finally
            {
                Desconectar();
            }
            return Tabla;
        }

        public String InfoProductos()
        {
            String Info = string.Empty;
            try
            {
                Conectar();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select count(*) From Productos where Estado = 1";
                cmd.Connection = Conectar();
                SqlDataReader Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    Info = "Informacion:  Productos Cargados : " + Lector.GetInt32(0);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error:\n"+ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return Info;
        }

        public SqlTransaction AgregarProducto(String Nombre,String Stock,String precio)
        {
            SqlConnection Conectarse=null;
            SqlCommand cmd;
            SqlTransaction Tran = null;
            bool Exito = false;
            try
            {
                Conectarse = new SqlConnection();
                Conectarse.ConnectionString = link;
                Conectarse.Open();

                //se inicia la transacción
                Tran = Conectarse.BeginTransaction(System.Data.IsolationLevel.Serializable);

                cmd = new SqlCommand("CrearProducto", Conectarse, Tran);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(Stock));
                cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(precio));

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
                    Tran.Commit();
                    Conectarse.Close();
                    MessageBox.Show("Se cargo el servicio con exito.");
                }
                else
                {
                    Console.WriteLine("Algo salio mal.");
                    Tran.Rollback();
                    Conectarse.Close();
                    MessageBox.Show("Algo no salio bien.", "Ok");
                }
            }
            return Tran;
        }

        public SqlTransaction ModificarProducto(String ID, String Nombre, String Stock, String precio)
        {
            SqlConnection Conectarse = null;
            SqlCommand cmd;
            SqlTransaction Tran = null;
            bool Exito = false;
            try
            {
                Conectarse = new SqlConnection();
                Conectarse.ConnectionString = link;
                Conectarse.Open();

                //se inicia la transacción
                Tran = Conectarse.BeginTransaction(System.Data.IsolationLevel.Serializable);

                cmd = new SqlCommand("MdfProduct", Conectarse, Tran);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(ID));
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(Stock));
                cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(precio));

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
                    Tran.Commit();
                    Conectarse.Close();
                    MessageBox.Show("Se modifico el producto con exito.");
                }
                else
                {
                    Console.WriteLine("Algo salio mal.");
                    Tran.Rollback();
                    Conectarse.Close();
                    MessageBox.Show("Algo no salio bien.", "Ok");
                }
            }
            return Tran;
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    class DataBase
    {
        public static string link = @"SERVER=DESKTOP-COF6H2T;DATABASE=Peluqueria;integrated security=true"; //Agrege esto para no tener que cambiar manualmente la clave en cada metodo
        SqlConnection Conectarse = null;
        SqlCommand cmd = null;
        SqlTransaction Tran = null;
        SqlDataReader Lector = null;
        String Aviso = "";

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
                Aviso = "Se conecto la base de datos.";
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error:" + sqlEx, "Error DataBase");
                Aviso = "Error al conectar la base de datos.";
                esVerdadero = false;
                Environment.Exit(-1);
            }
            finally
            {
                Desconectar();
            }
            return esVerdadero;
        }

        public DataTable ActualizarLista(String Text)
        {
            DataTable Tabla = new DataTable();
            Tabla.Clear();
            try
            {
                Conectar();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * From Productos where Nombre like '%" + Text + "%' and Estado = 1";
                cmd.Connection = Conectar();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(Tabla);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:\n" + ex);
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
            catch (SqlException ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return Info;
        }

        public SqlTransaction AgregarProducto(String Nombre, String Stock, String precio)
        {
            if (Nombre != string.Empty && Stock != string.Empty && precio != string.Empty)
            {
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
                    if (EsNumero(Stock) == true)
                    {
                        cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(Stock));
                    }
                    if (EsDecimal(precio) == true)
                    {
                        cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(precio));
                    }
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
                        MessageBox.Show("Se cargo el producto con exito.");
                    }
                    else
                    {
                        Console.WriteLine("Algo salio mal.");
                        Tran.Rollback();
                        Conectarse.Close();
                        MessageBox.Show("Algo no salio bien.", "Ok");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, rellene todos los campos antes.");
            }
            return Tran;
        }

        public bool EsNumero(String Dato) //Verificar Si es un numero
        {
            int Verificarint;
            bool EsNumb = int.TryParse(Dato, out Verificarint);
            if (EsNumb)
            {
                Console.WriteLine("Es un numero: " + Verificarint);
            }
            else
            {
                Console.WriteLine("No es numero: " + Verificarint);
            }
            return EsNumb;
        }

        public bool EsDecimal(String Dato)
        {
            Decimal EsVerificar;
            bool EsDeci = decimal.TryParse(Dato, out EsVerificar);
            if (EsDeci)
            {
                Console.Write("Es un decimal: " + EsVerificar);
            }
            else
            {
                Console.Write("No es un decimal: " + EsVerificar);
            }
            return EsDeci;
        }

        public SqlTransaction ModificarProducto(String ID, String Nombre, String Stock, String precio)
        {
            bool Exito = false;
            if (ID != string.Empty && Nombre != string.Empty && precio != string.Empty)
            {
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
            }
            return Tran;
        }

        public SqlTransaction EliminarProducto(String Text)
        {
            bool Exito = false;
            if (Text != string.Empty)
            {
                try
                {
                    Conectarse = new SqlConnection();
                    Conectarse.ConnectionString = link;
                    Conectarse.Open();

                    //se inicia la transacción
                    Tran = Conectarse.BeginTransaction(System.Data.IsolationLevel.Serializable);

                    cmd = new SqlCommand("EliminarProducto", Conectarse, Tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(Text));

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
                        MessageBox.Show("Se dio de baja con exito.");
                    }
                    else
                    {
                        Console.WriteLine("Algo salio mal.");
                        Tran.Rollback(); //Se deshace la transacion
                        Conectarse.Close(); // Cierro la base de datos feliz pero enojado :(
                        MessageBox.Show("Algo no salio bien.", "Ok.");
                    }
                }
            }
            return Tran;
        }

        public DataTable ProductosOFF(String Text)
        {
            DataTable Tabla = new DataTable();
            Tabla.Clear();
            try
            {
                Conectar();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * From Productos where Nombre like '%" + Text + "%' and Estado = 0";
                cmd.Connection = Conectar();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(Tabla);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:\n" + ex);
            }
            finally
            {
                Desconectar();
            }
            return Tabla;
        }

        public SqlTransaction LevantarProducto(String ID)
        {
            bool Exito = false;
            if (ID != string.Empty)
            {
                try
                {
                    Conectarse = new SqlConnection();
                    Conectarse.ConnectionString = link;
                    Conectarse.Open();

                    Tran = Conectarse.BeginTransaction(System.Data.IsolationLevel.Serializable);

                    cmd = new SqlCommand("DarAltaProducto", Conectarse, Tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(ID));

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
            }
            return Tran;
        }

        public String Hoy(String Cancel, String Realizadas, String Servicios, String Stock)
        { //IMPORTANTE ####### LE PUSE S a las ventadetalle
            String Actuales = "", Ganancia = "";
            try
            {
                Conectar();

                cmd = new SqlCommand("Select COUNT(*) From VentasDetalles WHERE  (DATEPART(yy, FechaBaja) = " + DateTime.Now.Year + " and DATEPART(mm, FechaBaja) = " + DateTime.Now.Month + " AND DATEPART(dd, FechaBaja) = " + DateTime.Now.Day + ")", Conectar());
                Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    Actuales = "Trabajos actuales\n" + Lector.GetInt32(0);
                }

                cmd.Cancel();
                Lector.Close();

                cmd = new SqlCommand("Select SUM(Precio) From VentasDetalles WHERE (DATEPART(yy, FechaBaja) = " + DateTime.Now.Year + " and DATEPART(mm, FechaBaja) = " + DateTime.Now.Month + " AND DATEPART(dd, FechaBaja) = " + DateTime.Now.Day + ")", Conectar());
                Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    if (!Lector.IsDBNull(0))
                    {
                        Ganancia = "Ganancia Aproximada: " + Lector.GetDecimal(0).ToString();
                    }
                    else
                    {
                        Ganancia = "Ganancia Aproximada: 0";
                    }
                }

                cmd.Cancel();
                Lector.Close();
                // no arreglado aun
                // tengo que poner los turnos mas cercanos a mi horario
                cmd = new SqlCommand("Select * from TurnosActuales WHERE (DATEPART(yy, FechaBaja) = " + DateTime.Now.Year + " and DATEPART(mm, FechaBaja) = " + DateTime.Now.Month + " AND DATEPART(dd, FechaBaja) = " + DateTime.Now.Day + ")", Conectar());
                Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    //LabelTurno1.Text = "" + Lector.GetDateTime(3).ToShortTimeString() + "\n" + Lector.GetString(0) + " " + Lector.GetString(1) + "\n" + Lector.GetString(2);
                }
            }
            catch (SqlException Error)
            {
                MessageBox.Show("Error al Actualizar las listas. Se reintentara en 2 minutos.");
                Console.WriteLine("Error: \n" + Error);
            }
            finally
            {
                Desconectar();
            }
            return Ganancia;
        }

        public DataTable ActualizarListaTurnos()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();
            try
            {
                Conectar();
                String sql = "select " + "Id_Turnos,Dia,Hora,Turnos.Id_Cliente,Id_Empleado,Telefono, Clientes.Nombre AS Cliente from Turnos INNER JOIN Clientes ON Turnos.Id_Cliente = Clientes.Id_Cliente";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, Conectar());
                adaptador.Fill(tabla);
            }
            catch (SqlException er)
            {
                MessageBox.Show("Error:\n" + er);
            }
            finally
            {
                Desconectar();
            }
            return tabla;
        }

        public BindingSource ExtraerEmpleados()
        {
            BindingSource source = new BindingSource();
            source.Clear();
            try
            {
                Conectar();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select Id_Empleado,Nombre,Apellido From Empleados";
                cmd.Connection = Conectar();
                SqlDataReader Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {

                    source.Add(Lector.GetString(1));
                }
            }
            catch (SqlException er)
            {
                MessageBox.Show("Error:\n" + er);
            }
            finally
            {
                Desconectar();
            }
            return source;
        }

        public void Auth(String user, String pass)
        {
            try
            {
                Conectar();
                string consulta = "select * From Empleados where Usuario ='" + user + "' and Contraseña='" + pass + "' and EsAdmin = 'True'"; //verifico que el usuario y contraseña estan registrados en la base de datos
                SqlCommand comando = new SqlCommand(consulta, Conectar());
                SqlDataReader lector;
                lector = comando.ExecuteReader();

                if (lector.HasRows == true) //verifico que el codigo se leyó para poder abrir el form
                {
                    FormAdmin f3 = new FormAdmin();
                    f3.Show();
                }
                else //mensaje de aviso en caso de errarle
                {
                    MessageBox.Show("Por favor, ingrese un usuario y/o contraseña válidos.");
                }
            }
            catch (SqlException)
            {

            }
            finally
            {
                Desconectar();
            }
        }
    }
}

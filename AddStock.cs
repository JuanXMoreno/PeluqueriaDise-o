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
    public partial class AddStock : Form
    {
        //Clase
        DataBase DataB = new DataBase();
        public AddStock()
        {
            InitializeComponent();
        }

        private void BtnAgregar(object sender, EventArgs e)
        {
            bool Exito = false;
            try
            {
                Conectarse = new SqlConnection();
                Conectarse.ConnectionString = Cadena;
                Conectarse.Open();

                //se inicia la transacción
                Tran = Conectarse.BeginTransaction(System.Data.IsolationLevel.Serializable);

                cmd = new SqlCommand("CrearProducto", Conectarse, Tran);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", Nombre.Text);
                cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(Stock.Text));
                cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(precio.Text));

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
                    MessageBox.Show("Se cargo el producto con exito.", "OK");
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
    }
}

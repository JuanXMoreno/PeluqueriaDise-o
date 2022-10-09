using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class Login : Form
    {
        DataBase DataB = new DataBase();
        public Login()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '*';
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-COF6H2T;database=Peluqueria; integrated security=true");

        //boton para ingresar al administrador con el usuario y contraseña guardadas en la base de datos
        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "select * From Empleados where Usuario ='" + txtNombreUsuario.Text + "' and Contraseña='" + txtContraseña.Text + "' and EsAdmin = 'True'"; //verifico que el usuario y contraseña estan registrados en la base de datos
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if (lector.HasRows == true) //verifico que el codigo se leyó para poder abrir el form
            {
                FormAdmin f3 = new FormAdmin();
                f3.Show();
                this.Hide();
            }
            else //mensaje de aviso en caso de errarle
            {
                MessageBox.Show("Por favor, ingrese un usuario y/o contraseña válidos.");
            }
            conexion.Close();

        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            btn_Ocultar.BringToFront();  //traemos el boton de ocultar al frente

            txtContraseña.PasswordChar = '\0';
        }

        private void btn_Ocultar_Click(object sender, EventArgs e)
        {
            btn_Mostrar.BringToFront();

            txtContraseña.PasswordChar = '*';
        }
    }
}

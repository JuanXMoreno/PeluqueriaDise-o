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
            DataB.Verificacion();
            InitializeComponent();
        }

        int PosY = 0;
        int PosX = 0;

        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-COF6H2T;database=Peluqueria; integrated security=true");

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
                this.AddOwnedForm(f3);
                f3.Show();
                this.Hide();
            }
            else //mensaje de aviso en caso de errarle
            {
                MessageBox.Show("Por favor, ingrese un usuario y/o contraseña válidos.");
            }
            conexion.Close();
            BorrarUser();
        } //Boton para login

        private void PanelSup_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                PosX = e.X;
                PosY = e.Y;
            }
            else
            {
                Left = Left + (e.X - PosX);
                Top = Top + (e.Y - PosY);
            }
        } //Mover X Panel

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '\0';
        } //Mostrar contraseña

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
        } //Ocultar

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.whatsapp.com/send/?phone=543549633063&text=Hola+necesito+tu+ayuda%2C+me+olvide+mi+contrase%C3%B1a+de+ingreso.&type=phone_number&app_absent=0");
        } //Mensaje de Ayuda (me manda a mi whatsapp)

        private void MoverXTitu(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                PosX = e.X;
                PosY = e.Y;
            }
            else
            {
                Left = Left + (e.X - PosX);
                Top = Top + (e.Y - PosY);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void BorrarUser()
        {
            txtNombreUsuario.Clear();
            txtContraseña.Clear();
        }
    }
}

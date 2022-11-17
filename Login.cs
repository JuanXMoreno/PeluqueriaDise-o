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
            DataB.Verificacion();
        }

        int PosY = 0;
        int PosX = 0;

        //boton para ingresar al administrador con el usuario y contraseña guardadas en la base de datos
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "" && txtNombreUsuario.Text != "")
            {
                DataB.AuthEmpleado(txtNombreUsuario.Text, txtContraseña.Text);
                DataB.Auth(txtNombreUsuario.Text, txtContraseña.Text);
                if (DataB.SiHay == false)
                {
                    MessageBox.Show("Por favor, ingrese un usuario y/o contraseña correctos");
                }
                else
                {
                    BorrarUser();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete las casillas");
            }
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

        private void txtNombreUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtContraseña.Focus();
            }
        }

        private void txtContraseña_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                DataB.Auth(txtNombreUsuario.Text, txtContraseña.Text);
                this.Hide();
            }
        }
    }
}

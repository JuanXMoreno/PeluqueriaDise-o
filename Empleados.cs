using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class Empleados : Form
    {
        int indice;

        SqlConnection conexion = new SqlConnection(DataBase.link);

        int PosY = 0;
        int PosX = 0;

        public void consulta()
        {
            //Consulta a la base de datos, selecciono las columnas y las agrego al DataGridView

            String sql = "select Id_Empleado, Nombre, Apellido, DNI, Direccion as 'Dirección', Telefono as 'Teléfono', FechaNac as 'Fecha de nacimiento',HorasAsignadas as 'Hs asignadas' from Empleados";
            SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            tablaBD.DataSource = tabla;
            tablaBD.Columns[0].Visible = false;

        }
        public Empleados()
        {
            InitializeComponent();
        }

        public void limpiar_celdas()
        {
            //Limpio todo lo que contiene cada TextBox.

            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtDireccion.Clear();
            txtNumeroDeTelefono.Clear();
            txtHsAsignadas.Clear();

            txtNombre.Focus();
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //Inserto un empleado a la base de datos todo lo que contenga los TextBoxs en el caso de que las 
            //casillas estén completas.
            conexion.Open();

            if (txtNombre.Text.Equals("") || txtApellido.Text.Equals("") || txtDni.Text.Equals("") || txtDireccion.Text.Equals("") || txtNumeroDeTelefono.Text.Equals("") || txtHsAsignadas.Text.Equals(""))
            {
                MessageBox.Show("Faltan ingresar datos");
            }
            else
            {
                String sql = "insert into Empleados (Id_TurnoLaboral, Nombre, Apellido ,DNI ,Direccion ,Telefono ,FechaNac ,HorasAsignadas) values('1','" + txtNombre.Text + "','" + txtApellido.Text + "'," + txtDni.Text + ",'" + txtDireccion.Text + "'," + txtNumeroDeTelefono.Text + ",'" + txtFechaDeNacimiento.Text + "'," + txtHsAsignadas.Text + ")";
                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Empleado agregado");

                consulta();
                limpiar_celdas();


            }
            conexion.Close();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            //Llamo al método consulta para que en el DataGridView, si hay datos, se muestren las columnas 
            //seleccionadas.
            consulta();
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Modifico los datos de un empleado luego de seleccionar una fila. También pregunto antes de modificar.

            if (txtNombre.Text.Equals("") || txtApellido.Text.Equals("") || txtDni.Text.Equals("") || txtDireccion.Text.Equals("") || txtNumeroDeTelefono.Text.Equals("") || txtHsAsignadas.Text.Equals(""))
            {
                MessageBox.Show("No se puede modificar porque hay datos incompletos");
            }
            else
            {
                conexion.Open();
                String sql = "update Empleados set Id_TurnoLaboral='1', Nombre='" + txtNombre.Text + "',Apellido='" + txtApellido.Text + "',DNI=" + txtDni.Text + ",Direccion='" + txtDireccion.Text + "',Telefono=" + txtNumeroDeTelefono.Text + ",FechaNac='" + txtFechaDeNacimiento.Text + "',HorasAsignadas=" + txtHsAsignadas.Text + "where Id_Empleado=" + indice + "";
                SqlCommand comando = new SqlCommand(sql, conexion);


                DialogResult dr = MessageBox.Show("¿Realmente desea modificar a este empleado?", "Modificar empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.OK)
                {
                    comando.ExecuteNonQuery();
                }
                consulta();
                limpiar_celdas();

                conexion.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            String sql = "delete Empleados where Id_Empleado=" + indice + "";
            SqlCommand comando = new SqlCommand(sql, conexion);


            DialogResult dr = MessageBox.Show("¿Realmente desea eliminar a este empleado?", "Modificar empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dr == DialogResult.OK)
            {
                comando.ExecuteNonQuery();
            }
            consulta();
            limpiar_celdas();

            conexion.Close();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tablaBD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Envío los datos de una fila seleccionada a sus respectivos TextBoxs.

            indice = int.Parse(tablaBD.SelectedCells[0].Value.ToString());
            txtNombre.Text = tablaBD.SelectedCells[1].Value.ToString();
            txtApellido.Text = tablaBD.SelectedCells[2].Value.ToString();
            txtDni.Text = tablaBD.SelectedCells[3].Value.ToString();
            txtDireccion.Text = tablaBD.SelectedCells[4].Value.ToString();
            txtNumeroDeTelefono.Text = tablaBD.SelectedCells[5].Value.ToString();
            txtFechaDeNacimiento.Text = tablaBD.SelectedCells[6].Value.ToString();
            txtHsAsignadas.Text = tablaBD.SelectedCells[7].Value.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormAdmin F1 = Owner as FormAdmin;
            F1.Visible = true;
            this.Close();
        }

        private void MoverPanel(object sender, MouseEventArgs e)
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

        private void label1_MouseMove(object sender, MouseEventArgs e)
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
    }
}

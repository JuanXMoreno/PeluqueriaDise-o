using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class Sueldos : Form
    {
        public void consultaSueldo()
        {
            //Lo almacenado en el índice uno de la columna Sueldo de la tabla Sueldos se
            //muestra en el label de sueldo actual del día.
            conexion.Open();
            String consulSueldo = "select Sueldos from Empleados";
            SqlCommand comando = new SqlCommand(consulSueldo, conexion);
            lblSueldoActual.Text = comando.ExecuteScalar().ToString();
            conexion.Close();

            //Selecciono algunas filas de la tabla empleados y en la de HorasAsignadas 
            //multiplico las horas asignadas por el sueldo actual, sacando la suma del 
            //pago del empleado equivalente a un día.
            String sql = "select Id_Empleado, Nombre, Apellido, DNI, HorasAsignadas * '" + lblSueldoActual.Text + "' as 'Sueldo del día' from Empleados";
            SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            tablaSueldos.DataSource = tabla;
            tablaSueldos.Columns[0].Visible = false;
        }

        public Sueldos()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=CELE-PC;database=Peluqueria;integrated security=true");

        private void Sueldos_Load(object sender, EventArgs e)
        {
            //Llamo al método de consulta para que cada que se cargue el formulario
            //Sueldos se actualicen/muestren los datos.
            consultaSueldo();
        }

        private void btnModificarSueldo_Click(object sender, EventArgs e)
        {
            //Corroborar si es numero
            Boolean Corroboro = Esnumero(txtSueldoActual.Text.ToString());


            if (Corroboro == false || txtSueldoActual.Text.Equals(""))
            {
                MessageBox.Show("Falta ingresar sueldo o no hay datos válidos");
            }
            else
            {
                conexion.Open();

                String sql = "update Empleados set Sueldos=" + txtSueldoActual.Text + "where Id_Empleado= '1'";
                SqlCommand comando = new SqlCommand(sql, conexion);


                DialogResult dr = MessageBox.Show("¿Realmente desea modificar el sueldo por hora?", "Sueldo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.OK)
                {
                    lblSueldoActual.Text = comando.ExecuteNonQuery().ToString();
                }
                txtSueldoActual.Clear();
            }
            conexion.Close();
            consultaSueldo();
        }

        //Aqui se corrobora si el dato es un numero válido.
        public Boolean Esnumero(string numero)
        {
            Boolean siES = false;
            try
            {
                Int64.Parse(numero);
                siES = true;

            }
            catch (Exception)
            {
                siES = false;
            }
            return siES;
        }

        private void tablaSueldos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

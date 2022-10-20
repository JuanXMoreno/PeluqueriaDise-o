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
using System.ComponentModel.Design;

namespace ProyectoPeluquería
{   
    public partial class Empleados : Form
    {
        int indice;
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

        //Conexión a la base de datos.
        SqlConnection conexion = new SqlConnection("server=CELE-PC;database=Peluqueria;integrated security=true");

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
            }else{
                String sql = "insert into Empleados (Id_TurnoLaboral, Nombre, Apellido ,DNI ,Direccion ,Telefono ,FechaNac ,HorasAsignadas) values('1','" + txtNombre.Text + "','" + txtApellido.Text + "'," + txtDni.Text + ",'" + txtDireccion.Text + "'," + txtNumeroDeTelefono.Text + ",'" + txtFechaDeNacimiento.Text + "'," + txtHsAsignadas.Text + ")";
                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Empleado agregado");

                consulta();
                limpiar_celdas();

                conexion.Close();
            }
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            //Llamo al método consulta para que en el DataGridView, si hay datos, se muestren las columnas 
            //seleccionadas.
            consulta();
        }

        private void tablaBD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Modifico los datos de un empleado luego de seleccionar una fila. También pregunto antes de modificar.

            if (txtNombre.Text.Equals("") || txtApellido.Text.Equals("") || txtDni.Text.Equals("") || txtDireccion.Text.Equals("") || txtNumeroDeTelefono.Text.Equals("") || txtHsAsignadas.Text.Equals(""))
            {
                MessageBox.Show("No se puede modificar porque hay datos incompletos");
            }else{
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
            //Elimino un empleado de manera definitiva en la base de datos luego de seleccionar una fila y
            //confirmar la eliminación.

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

        private void tablaBD_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
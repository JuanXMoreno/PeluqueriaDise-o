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
    



    public partial class Turnos : Form
    {
        private int n=0;

        public void consulta()
        {
            String sql = "select Id_TurnoLaboral,Dias,HoraInicial,HoraFinal from TurnosLaborales";
            SqlDataAdapter adaptador=new SqlDataAdapter(sql,conexion);
            DataTable tabla =new DataTable();
            adaptador.Fill(tabla);
            dgvDatos.DataSource = tabla;
            dgvDatos.Columns[0].Visible = false;
                }

        public Turnos()
            

        {
            InitializeComponent();

           
        }
        SqlConnection conexion = new SqlConnection("server=DESKTOP-SK840FQ;database=Peluqueria; integrated security=true");

        private void Turnos_Load(object sender, EventArgs e)
        {
            consulta();
         


        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
           conexion.Open();
            if (txtCliente.Text =="" || cmbPeluquero.SelectedIndex == -1)
            {
                MessageBox.Show("Faltan datos");
           
            }else
            {
                string sql = "insert into TurnosLaborales(Dias,HoraInicial,HoraFinal) values ('" + txtDia.Text + "','" + txtHora.Value + "')";
            }




        }

        

         private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
          
          }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvDatos.Rows.RemoveAt(n);
        }

        private void txtDia_TextChanged(object sender, EventArgs e)
        {
            HabilitarBoton();
        }

        void HabilitarBoton()
        {
            if (txtDia.Text !="" && txtHora.Text != "" && txtCliente.Text !="")
                btnInsertar.Enabled = true;
            else btnInsertar.Enabled = false;
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            HabilitarBoton();
        }

        private void txtHora_ValueChanged(object sender, EventArgs e)
        {
            HabilitarBoton();
        }

        private void cmbPeluquero_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarBoton();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}

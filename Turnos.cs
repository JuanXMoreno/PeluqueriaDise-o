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



        public Turnos()
            

        {
            InitializeComponent();

           
        }

        private void Turnos_Load(object sender, EventArgs e)
        {  

            dgvDatos.Columns.Add("dia", "dia");
            dgvDatos.Columns.Add("hora", "hora");
            dgvDatos.Columns.Add("cliente", "cliente");
            dgvDatos.Columns.Add("peluquero", "peluquero");


        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            dgvDatos.Rows.Add(txtDia.Text, txtHora.Text, txtCliente.Text);
            txtDia.Text = "";
            txtHora.Text =String.Empty;
            txtCliente.Text = String.Empty;
            cmbPeluquero.Text=String.Empty; 



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
    }
}

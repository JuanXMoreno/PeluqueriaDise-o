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
    public partial class Ventas_y_Servicios : Form
    {

        SqlConnection conexion = new SqlConnection("server=DESKTOP-COF6H2T;database=Peluqueria; integrated security=true");

        int contador;
        
        int identificador;
        int valorCMBSeCortaCon;
        int valorCMBTipoDeDibujo;

        public Ventas_y_Servicios()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            switch (identificador)
            {
                case 0:
                    Sentencia(1, 2);
                    lblSOV1.Text = "Corte Clasico";
                    break;
                case 1:
                    contador = 3;
                    break;
                case 2:
                    Sentencia(4, 5);
                    break;
                case 3:
                    if (valorCMBTipoDeDibujo == 0)
                    {
                        contador = 9;
                    }
                    else if (valorCMBTipoDeDibujo == 1)
                    {
                        contador = 10;
                    }
                    break;
                case 4:
                    Sentencia(11, 12);
                    break;
                case 5:
                    contador = 6;
                    break;
                case 6:
                    contador = 7;
                    break;
                case 7:
                    contador = 8;
                    break;
                case 8:
                    contador = 13;
                    break;
            }

            SqlCommand comando = new SqlCommand("");
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_CorteClasico_Click(object sender, EventArgs e)
        {
            ColoresParejos();
            HabilitarCmb();
            cmb_TipoDeDibujo.Enabled = false;

            cmb_SeCortaCon.Items.Clear();

            CambiarTextoCMB();

            cmb_SeCortaCon.Items.Add("Maquina");
            cmb_SeCortaCon.Items.Add("Tijera");
            pnl_CorteClasico.BackColor = Color.Aqua;

            identificador = 0;
        }

        private void pnl_CorteAmericano_Click(object sender, EventArgs e)
        {
            ColoresParejos();
            HabilitarCmb();
            cmb_SeCortaCon.Enabled = false;
            cmb_TipoDeDibujo.Enabled = false;

            CambiarTextoCMB();

            pnl_CorteAmericano.BackColor = Color.Aqua;

            identificador = 1;
        }

        private void pnl_Degrade_Click(object sender, EventArgs e)
        {
            ColoresParejos();
            HabilitarCmb();
            cmb_TipoDeDibujo.Enabled = false;

            cmb_SeCortaCon.Items.Clear();

            CambiarTextoCMB();

            cmb_SeCortaCon.Items.Add("Maquina");
            cmb_SeCortaCon.Items.Add("Navaja");

            pnl_Degrade.BackColor = Color.Aqua;

            identificador = 2;

        }

        private void pnl_Dibujo_Click(object sender, EventArgs e)
        {
            ColoresParejos();
            HabilitarCmb();

            cmb_SeCortaCon.Enabled = false;

            CambiarTextoCMB();

            pnl_Dibujo.BackColor = Color.Aqua;

            identificador = 3;
        }

        private void pnl_CorteBarba_Click(object sender, EventArgs e)
        {
            ColoresParejos();
            HabilitarCmb();
            cmb_TipoDeDibujo.Enabled = false;

            cmb_SeCortaCon.Items.Clear();

            CambiarTextoCMB();

            cmb_SeCortaCon.Items.Add("Maquina");
            cmb_SeCortaCon.Items.Add("Navaja");

            pnl_CorteBarba.BackColor = Color.Aqua;

            identificador = 4;
        }

        private void pnl_Lineas_Click(object sender, EventArgs e)
        {
            ColoresParejos();
            
            pnl_Lineas.BackColor = Color.Aqua;

            CambiarTextoCMB();

            identificador = 5;
        }

        private void pnl_Cejas_Click(object sender, EventArgs e)
        {
            ColoresParejos();

            pnl_Cejas.BackColor = Color.Aqua;

            CambiarTextoCMB();

            identificador = 6;
        }

        private void pnl_Frente_Click(object sender, EventArgs e)
        {
            ColoresParejos();

            pnl_Frente.BackColor = Color.Aqua;

            CambiarTextoCMB();

            identificador = 7;
        }

        private void pnl_Lavado_Click(object sender, EventArgs e)
        {
            ColoresParejos();

            pnl_Lavado.BackColor = Color.Aqua;

            CambiarTextoCMB();

            identificador = 8;
        }

        public void HabilitarCmb()
        {
            valorCMBSeCortaCon = -1;

            cmb_SeCortaCon.Enabled = true;
            cmb_TipoDeDibujo.Enabled = true;
            cmb_Agregado1.Enabled = true;
            cmb_Agregado2.Enabled = true;
            cmb_Agregado3.Enabled = true;
        }

        public void ColoresParejos()
        {
            pnl_CorteClasico.BackColor = Color.DarkGray;
            pnl_CorteAmericano.BackColor = Color.DarkGray;
            pnl_Degrade.BackColor = Color.DarkGray;
            pnl_Lineas.BackColor = Color.DarkGray;
            pnl_Cejas.BackColor = Color.DarkGray;
            pnl_Frente.BackColor = Color.DarkGray;
            pnl_Dibujo.BackColor = Color.DarkGray;
            pnl_CorteBarba.BackColor = Color.DarkGray;
            pnl_Lavado.BackColor = Color.DarkGray;
        }

        public void Sentencia(int a, int b)
        {
            if (valorCMBSeCortaCon == 0)
            {
                contador = a;
            }
            else if (valorCMBSeCortaCon == 1)
            {
                contador = b;
            }
        }

        public void CambiarTextoCMB() 
        {
            cmb_TipoDeDibujo.Text = "Seleccionar";
            cmb_SeCortaCon.Text = "Seleccionar";
        }

        private void cmb_SeCortaCon_SelectedIndexChanged(object sender, EventArgs e)
        {
            valorCMBSeCortaCon = cmb_SeCortaCon.SelectedIndex;
            lblSOV2.Text = valorCMBSeCortaCon.ToString();
        }

        private void cmb_TipoDeDibujo_SelectedIndexChanged(object sender, EventArgs e)
        {
            valorCMBTipoDeDibujo = cmb_TipoDeDibujo.SelectedIndex;
            lblSOV2.Text = valorCMBTipoDeDibujo.ToString();
        }
    }
}

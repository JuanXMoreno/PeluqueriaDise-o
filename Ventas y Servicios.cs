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
        int contador;
        int contadorVentas;

        int cantidad;

        int identificador;
        int valorCMBSeCortaCon;
        int valorCMBTipoDeDibujo = -1;

        float valorbdd;
        float valorbddVentas;
        int precio;

        public Ventas_y_Servicios()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-COF6H2T;database=Peluqueria; integrated security=true");


        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            switch (identificador)
            {
                case 0:
                    Sentencia(1, 2,"Corte Clasico Maquina","Corte Clasico Tijera");
                    break;
                case 1:
                    contador = 3;
                    LlenarSOV("Corte Americano", valorbdd);
                    precio = precio + (int)valorbdd;
                    break;
                case 2:
                    Sentencia(4, 5,"Degrade Maquina","Degrade Navaja");
                    break;
                case 3:
                    if (valorCMBTipoDeDibujo == 0)
                    {
                        contador = 9;
                        BddBajaPrecio();
                        LlenarSOV("Dibujo Simple", valorbdd);
                        precio = precio + (int)valorbdd;
                    }
                    else if (valorCMBTipoDeDibujo == 1)
                    {
                        contador = 10;
                        BddBajaPrecio();
                        LlenarSOV("Dibujo Doble", valorbdd);
                        precio = precio + (int)valorbdd;
                    }
                    valorCMBTipoDeDibujo = -1;
                    break;
                case 4:
                    Sentencia(11, 12,"Corte Barba Maquina","Corte Barba Navaja");
                    break;
                case 5:
                    contador = 6;
                    BddBajaPrecio();
                    LlenarSOV("Lineas", valorbdd);
                    precio = precio + (int)valorbdd;
                    break;
                case 6:
                    contador = 7;
                    BddBajaPrecio();
                    LlenarSOV("Cejas", valorbdd);
                    precio = precio + (int)valorbdd;
                    break;
                case 7:
                    contador = 8;
                    BddBajaPrecio();
                    LlenarSOV("Frente", valorbdd);
                    precio = precio + (int)valorbdd;
                    break;
                case 8:
                    contador = 13;
                    BddBajaPrecio();
                    LlenarSOV("Lavado", valorbdd);
                    precio = precio + (int)valorbdd;
                    break;
            }
            if (contador == -1)
            {
                MessageBox.Show("por favor, seleccione una opción");
            }

            lblTotal.Text = precio.ToString();
        }

        private void btn_AgregarVentas_Click(object sender, EventArgs e)
        {
            switch (contadorVentas)
            {
                case 1:
                    LlenarSOV("Espuma / Afeitar Foamy Sensitive", valorbddVentas);
                    precio = precio + (int)valorbddVentas;
                    cantidad = 0;
                    break;
                case 2:
                    LlenarSOV("ESpuma / Afeitar Foamy Regular", valorbddVentas);
                    precio = precio + (int)valorbddVentas;
                    cantidad = 0;
                    break;
                case 3:
                    LlenarSOV("Shampoo Elvive Loreal Paris Arcilla Purificante", valorbddVentas);
                    precio = precio + (int)valorbddVentas;
                    cantidad = 0;
                    break;
                case 4:
                    LlenarSOV("Shampoo Elvive Reparación Total Extreme Keratin Xs", valorbddVentas);
                    precio = precio + (int)valorbddVentas;
                    cantidad = 0;
                    break;
                case 5:
                    LlenarSOV("Acondicionador Elvive Loreal Hidratación Hialurónico", valorbddVentas);
                    precio = precio + (int)valorbddVentas;
                    cantidad = 0;
                    break;
                case 6:
                    LlenarSOV("Acondicionador Elvive Loreal Reparación Total Extreme", valorbddVentas);
                    precio = precio + (int)valorbddVentas;
                    cantidad = 0;
                    break;
                case 7:
                    LlenarSOV("Gel Capilar Fijación Fuerte Algabo", valorbddVentas);
                    precio = precio + (int)valorbddVentas;
                    cantidad = 0;
                    break;
                case 8:
                    LlenarSOV("Gel Capilar Efecto Húmedo Algabo", valorbddVentas);
                    precio = precio + (int)valorbddVentas;
                    cantidad = 0;
                    break;
                case 9:
                    LlenarSOV("Iyosei Cera Capilar Hydro H2O Hard", valorbddVentas);
                    precio = precio + (int)valorbddVentas;
                    cantidad = 0;
                    break;
                case 10:
                    LlenarSOV("Iyosei Cera Capilar Hydro Clásica", valorbddVentas);
                    precio = precio + (int)valorbddVentas;
                    cantidad = 0;
                    break;
            }
            lblTotal.Text = precio.ToString();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_CorteClasico_Click(object sender, EventArgs e)
        {
            contador = -1;
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
            contador = -1;
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
            contador = -1;
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
            contador = -1;
            ColoresParejos();
            HabilitarCmb();

            cmb_SeCortaCon.Enabled = false;

            cmb_TipoDeDibujo.Items.Clear();

            CambiarTextoCMB();

            cmb_TipoDeDibujo.Items.Add("Simple");
            cmb_TipoDeDibujo.Items.Add("Doble");

            pnl_Dibujo.BackColor = Color.Aqua;

            identificador = 3;
        }

        private void pnl_CorteBarba_Click(object sender, EventArgs e)
        {
            contador = -1;
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

        private void pnl_EspumaFS_Click(object sender, EventArgs e)
        {
            ColoresParejosVentas();
            pnl_EspumaFS.BackColor = Color.Aqua;
            contadorVentas = 1;
            bddBajaPrecioProducto();

        }

        private void pnl_EspumaFR_Click(object sender, EventArgs e)
        {
            ColoresParejosVentas();
            pnl_EspumaFR.BackColor = Color.Aqua;
            contadorVentas = 2;
            bddBajaPrecioProducto();

        }

        private void pnl_ShampooAP_Click(object sender, EventArgs e)
        {
            ColoresParejosVentas();
            pnl_ShampooAP.BackColor = Color.Aqua;
            contadorVentas = 3;
            bddBajaPrecioProducto();

        }

        private void pnl_ShampooEK_Click(object sender, EventArgs e)
        {
            ColoresParejosVentas();
            pnl_ShampooEK.BackColor = Color.Aqua;
            contadorVentas = 4;
            bddBajaPrecioProducto();

        }

        private void pnl_AcondicionadorHH_Click(object sender, EventArgs e)
        {
            ColoresParejosVentas();
            pnl_AcondicionadorHH.BackColor = Color.Aqua;
            contadorVentas = 5;
            bddBajaPrecioProducto();
        }

        private void pnl_AcondicionadorTE_Click(object sender, EventArgs e)
        {
            ColoresParejosVentas();
            pnl_AcondicionadorTE.BackColor = Color.Aqua;
            contadorVentas = 6;
        }

        private void pnl_GelFF_Click(object sender, EventArgs e)
        {
            ColoresParejosVentas();
            pnl_GelFF.BackColor = Color.Aqua;
            contadorVentas = 7;
        }

        private void pnl_GelEH_Click(object sender, EventArgs e)
        {
            ColoresParejosVentas();
            pnl_GelEH.BackColor = Color.Aqua;
            contadorVentas = 8;
        }

        private void pnl_CeraHH_Click(object sender, EventArgs e)
        {
            ColoresParejosVentas();
            pnl_CeraHH.BackColor = Color.Aqua;
            contadorVentas = 9;
        }

        private void pnl_CeraHC_Click(object sender, EventArgs e)
        {
            ColoresParejosVentas();
            pnl_CeraHC.BackColor = Color.Aqua;
            contadorVentas = 10;
        }

        public void HabilitarCmb() //todos los cmb estan 
        {
            valorCMBSeCortaCon = -1;

            cmb_SeCortaCon.Enabled = true;
            cmb_TipoDeDibujo.Enabled = true;
        }

        public void ColoresParejos() //para volver a poner el panel a su color una vez se seleccione otro
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

        public void ColoresParejosVentas()
        {
            pnl_ShampooAP.BackColor = Color.DarkGray;
            pnl_ShampooEK.BackColor = Color.DarkGray;
            pnl_AcondicionadorHH.BackColor = Color.DarkGray;
            pnl_AcondicionadorTE.BackColor = Color.DarkGray;
            pnl_EspumaFR.BackColor = Color.DarkGray;
            pnl_EspumaFS.BackColor = Color.DarkGray;
            pnl_GelEH.BackColor = Color.DarkGray;
            pnl_GelFF.BackColor = Color.DarkGray;
            pnl_CeraHC.BackColor = Color.DarkGray;
            pnl_CeraHH.BackColor = Color.DarkGray;
        }

        public void Sentencia(int a, int b, string valor1, string valor2) //interactua con el contador y el label cuando el dan esos valores
        {
            if (valorCMBSeCortaCon == 0)
            {
                contador = a;
                BddBajaPrecio();
                LlenarSOV(valor1, valorbdd);
                precio = precio + (int)valorbdd;
            }
            else if (valorCMBSeCortaCon == 1)
            {
                contador = b;
                BddBajaPrecio();
                LlenarSOV(valor2, valorbdd);
                precio = precio + (int)valorbdd;
            }
        }


        public void CambiarTextoCMB() //algo visual, solo hace que el texto de los cmb sea seleccionar cada vez que se seleccione un servicio
        {
            cmb_TipoDeDibujo.Text = "Seleccionar";
            cmb_SeCortaCon.Text = "Seleccionar";
        }

        private void cmb_SeCortaCon_SelectedIndexChanged(object sender, EventArgs e)
        {
            valorCMBSeCortaCon = cmb_SeCortaCon.SelectedIndex;
        }

        private void cmb_TipoDeDibujo_SelectedIndexChanged(object sender, EventArgs e)
        {
            valorCMBTipoDeDibujo = cmb_TipoDeDibujo.SelectedIndex;            
        }

        public void LlenarSOV(string valor, float ValorVentaServicio)
        {
            if (lblSOV1.Text.Equals("."))
            {
                lblSOV1.Text = valor;
                lblPrecio1.Text = ValorVentaServicio.ToString();
            }
            else if (!lblSOV1.Text.Equals(".") && lblSOV2.Text.Equals("."))
            {
                lblSOV2.Text = valor;
                lblPrecio2.Text = ValorVentaServicio.ToString();
            }
            else if (!lblSOV2.Text.Equals(".") && lblSOV3.Text.Equals("."))
            {
                lblSOV3.Text = valor;
                lblPrecio3.Text = ValorVentaServicio.ToString();
            }
            else if (!lblSOV3.Text.Equals(".") && lblSOV4.Text.Equals("."))
            {
                lblSOV4.Text = valor;
                lblPrecio4.Text = ValorVentaServicio.ToString();
            }
            else if (!lblSOV4.Text.Equals(".") && lblSOV5.Text.Equals("."))
            {
                lblSOV5.Text = valor;
                lblPrecio5.Text = ValorVentaServicio.ToString();
            }
            else if (!lblSOV5.Text.Equals(".") && lblSOV6.Text.Equals("."))
            {
                lblSOV6.Text = valor;
                lblPrecio6.Text = ValorVentaServicio.ToString();
            }
        }

        public void BddBajaPrecio()
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("select Precio From Servicios where Id_Servicio ='" + contador + "'", conexion);
            SqlDataReader lector = comando.ExecuteReader();

            if (lector.HasRows == true)
            {
                while (lector.Read())
                {
                    valorbdd = float.Parse(lector.GetString(0));                   
                }
            }
            conexion.Close();
        }

        public void bddBajaPrecioProducto()
        {
            conexion.Open();
            SqlCommand comandoProd = new SqlCommand("select Precio From Productos where Id_Producto ='" + contadorVentas + "'", conexion);
            SqlDataReader lector = comandoProd.ExecuteReader();

            if (lector.HasRows == true)
            {
                while (lector.Read())
                {
                    valorbddVentas = float.Parse(lector.GetString(0));
                }
            }
            conexion.Close();
        }

        

        
    }
}

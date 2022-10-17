using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class Ventas_y_Servicios : Form
    {
        int contador;
        int contadorVentas;

        int indiceCeldasDGV;

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
                    Sentencia(1, 2, "Corte Clasico Maquina", "Corte Clasico Tijera");
                    break;
                case 1:
                    CodigoRepetidoCaseServicios(3,"Corte Americano");
                    break;
                case 2:
                    Sentencia(4, 5, "Degrade Maquina", "Degrade Navaja");
                    break;
                case 3:
                    if (valorCMBTipoDeDibujo == 0)
                    {
                        CodigoRepetidoCaseServicios(9, "Dibujo Simple");
                    }
                    else if (valorCMBTipoDeDibujo == 1)
                    {
                        CodigoRepetidoCaseServicios(10, "Dibujo Doble");
                    }
                    valorCMBTipoDeDibujo = -1;
                    break;
                case 4:
                    Sentencia(11, 12, "Corte Barba Maquina", "Corte Barba Navaja");
                    break;
                case 5:
                    CodigoRepetidoCaseServicios(6, "Lineas");
                    break;
                case 6:
                    CodigoRepetidoCaseServicios(7, "Cejas");
                    break;
                case 7:
                    CodigoRepetidoCaseServicios(8, "Frente");
                    break;
                case 8:
                    CodigoRepetidoCaseServicios(13, "Lavado");
                    break;
            }
            if (contador == -1)
            {
                MessageBox.Show("por favor, seleccione una opción");
            }

            lblTotal.Text ="Precio Total: " + precio.ToString();
        }

        private void btn_AgregarVentas_Click(object sender, EventArgs e)
        {
            

            switch (contadorVentas)
            {
                case 1:
                    CodigoRepetidoCaseVentas("Espuma/Afeitar Foamy Sensitive");
                    break;
                case 2:
                    CodigoRepetidoCaseVentas("Espuma/Afeitar Foamy Regular");
                    break;
                case 3:
                    CodigoRepetidoCaseVentas("Shampoo Elvive Loreal Paris Arcilla Purificante");
                    break;
                case 4:
                    CodigoRepetidoCaseVentas("Shampoo Elvive Reparación Total Extreme Keratin Xs");
                    break;
                case 5:
                    CodigoRepetidoCaseVentas("Acondicionador Elvive Loreal Hidratación Hialurónico");
                    break;
                case 6:
                    CodigoRepetidoCaseVentas("Acondicionador Elvive Loreal Reparación Total Extreme");
                    break;
                case 7:
                    CodigoRepetidoCaseVentas("Gel Capilar Fijación Fuerte Algabo");
                    break;
                case 8:
                    CodigoRepetidoCaseVentas("Gel Capilar Efecto Húmedo Algabo");
                    break;
                case 9:
                    CodigoRepetidoCaseVentas("Iyosei Cera Capilar Hydro H2O Hard");
                    break;
                case 10:
                    CodigoRepetidoCaseVentas("Iyosei Cera Capilar Hydro Clásica");
                    break;
            }
            lblTotal.Text = "Precio Total " + precio.ToString();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_CorteClasico_Click(object sender, EventArgs e)
        {
            CodigoRepetidoServicios(0);

            cmb_TipoDeDibujo.Enabled = false;

            cmb_SeCortaCon.Items.Add("Maquina");
            cmb_SeCortaCon.Items.Add("Tijera");
            pnl_CorteClasico.BackColor = Color.Aqua;
            label9.Enabled = true;
        }

        private void pnl_CorteAmericano_Click(object sender, EventArgs e)
        {
            CodigoRepetidoServicios(1);

            cmb_SeCortaCon.Enabled = false;
            cmb_TipoDeDibujo.Enabled = false;

            pnl_CorteAmericano.BackColor = Color.Aqua;

            label10.Enabled = true;
        }

        private void pnl_Degrade_Click(object sender, EventArgs e)
        {
            CodigoRepetidoServicios(2);

            cmb_TipoDeDibujo.Enabled = false;
            cmb_SeCortaCon.Items.Add("Maquina");
            cmb_SeCortaCon.Items.Add("Navaja");

            pnl_Degrade.BackColor = Color.Aqua;

            label11.Enabled = true;
        }

        private void pnl_Dibujo_Click(object sender, EventArgs e)
        {
            CodigoRepetidoServicios(3);

            cmb_SeCortaCon.Enabled = false;

            cmb_TipoDeDibujo.Items.Add("Simple");
            cmb_TipoDeDibujo.Items.Add("Doble");

            pnl_Dibujo.BackColor = Color.Aqua;

            label24.Enabled = true;
        }

        private void pnl_CorteBarba_Click(object sender, EventArgs e)
        {
            CodigoRepetidoServicios(4);

            cmb_TipoDeDibujo.Enabled = false;

            cmb_SeCortaCon.Items.Add("Maquina");
            cmb_SeCortaCon.Items.Add("Navaja");

            pnl_CorteBarba.BackColor = Color.Aqua;

            label13.Enabled = true;
        }

        private void pnl_Lineas_Click(object sender, EventArgs e)
        {
            ColoresParejos();

            pnl_Lineas.BackColor = Color.Aqua;

            CambiarTextoCMB();

            identificador = 5;
            label15.Enabled = true;
            cantidad = 1;
        }

        private void pnl_Cejas_Click(object sender, EventArgs e)
        {
            ColoresParejos();

            pnl_Cejas.BackColor = Color.Aqua;

            CambiarTextoCMB();

            identificador = 6;
            label16.Enabled = true;
            cantidad = 1;
        }

        private void pnl_Frente_Click(object sender, EventArgs e)
        {
            ColoresParejos();

            pnl_Frente.BackColor = Color.Aqua;

            CambiarTextoCMB();

            identificador = 7;
            label17.Enabled = true;
            cantidad = 1;
        }

        private void pnl_Lavado_Click(object sender, EventArgs e)
        {
            ColoresParejos();

            pnl_Lavado.BackColor = Color.Aqua;

            CambiarTextoCMB();

            identificador = 8;
            label14.Enabled = true;
            cantidad = 1;
        }

        private void pnl_EspumaFS_Click(object sender, EventArgs e)
        {
            ColoresParejosVentas();
            pnl_EspumaFS.BackColor = Color.Aqua;
            contadorVentas = 1;
            bddBajaPrecioProducto();
            cantidad = 1;
            lblCantidad.Text = "1";
            label6.Enabled = true;
        }

        private void pnl_EspumaFR_Click(object sender, EventArgs e)
        {
            ColoresParejosVentas();
            pnl_EspumaFR.BackColor = Color.Aqua;
            contadorVentas = 2;
            bddBajaPrecioProducto();
            cantidad = 1;
            lblCantidad.Text = "1";
            label7.Enabled = true;
        }

        private void pnl_ShampooAP_Click(object sender, EventArgs e)
        {
            ColoresParejosVentas();
            pnl_ShampooAP.BackColor = Color.Aqua;
            contadorVentas = 3;
            bddBajaPrecioProducto();
            cantidad = 1;
            lblCantidad.Text = "1";
            label8.Enabled = true;
        }

        private void pnl_ShampooEK_Click(object sender, EventArgs e)
        {
            ColoresParejosVentas();
            pnl_ShampooEK.BackColor = Color.Aqua;
            contadorVentas = 4;
            bddBajaPrecioProducto();
            cantidad = 1;
            lblCantidad.Text = "1";
            label21.Enabled = true;
        }

        private void pnl_AcondicionadorHH_Click(object sender, EventArgs e)
        {
            ColoresParejosVentas();
            pnl_AcondicionadorHH.BackColor = Color.Aqua;
            contadorVentas = 5;
            bddBajaPrecioProducto();
            cantidad = 1;
            lblCantidad.Text = "1";
            label26.Enabled = true;
        }

        private void pnl_AcondicionadorTE_Click(object sender, EventArgs e)
        {
            ColoresParejosVentas();
            pnl_AcondicionadorTE.BackColor = Color.Aqua;
            contadorVentas = 6;
            bddBajaPrecioProducto();
            cantidad = 1;
            lblCantidad.Text = "1";
            label28.Enabled = true;
        }

        private void pnl_GelFF_Click(object sender, EventArgs e)
        {
            ColoresParejosVentas();
            pnl_GelFF.BackColor = Color.Aqua;
            contadorVentas = 7;
            bddBajaPrecioProducto();
            cantidad = 1;
            lblCantidad.Text = "1";
            label30.Enabled = true;
        }

        private void pnl_GelEH_Click(object sender, EventArgs e)
        {
            ColoresParejosVentas();
            pnl_GelEH.BackColor = Color.Aqua;
            contadorVentas = 8;
            bddBajaPrecioProducto();
            cantidad = 1;
            lblCantidad.Text = "1";
            label32.Enabled = true;
        }

        private void pnl_CeraHH_Click(object sender, EventArgs e)
        {
            ColoresParejosVentas();
            pnl_CeraHH.BackColor = Color.Aqua;
            contadorVentas = 9;
            bddBajaPrecioProducto();
            cantidad = 1;
            lblCantidad.Text = "1";
            label34.Enabled = true;
        }

        private void pnl_CeraHC_Click(object sender, EventArgs e)
        {
            ColoresParejosVentas();
            pnl_CeraHC.BackColor = Color.Aqua;
            contadorVentas = 10;
            bddBajaPrecioProducto();
            cantidad = 1;
            lblCantidad.Text = "1";
            label23.Enabled = true;
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
                CodigoRepetidoCaseServicios(a, valor1);
            }
            else if (valorCMBSeCortaCon == 1)
            {
                CodigoRepetidoCaseServicios(b, valor2);
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

        public void LlenarSOV(string valor, float valorVentaServicio, float calculoMultiplicado)
        {
            int rowEscribir = dgv_VentasServicios.Rows.Count - 1;

            dgv_VentasServicios.Rows.Add(1);

            dgv_VentasServicios.Rows[rowEscribir].Cells[0].Value = valor;
            dgv_VentasServicios.Rows[rowEscribir].Cells[1].Value = cantidad;
            dgv_VentasServicios.Rows[rowEscribir].Cells[2].Value = valorVentaServicio;
            dgv_VentasServicios.Rows[rowEscribir].Cells[3].Value = calculoMultiplicado;
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

        public void CodigoRepetidoServicios(int valorId)
        {
            contador = -1;
            ColoresParejos();
            HabilitarCmb();
            CambiarTextoCMB();
            identificador = valorId;
            cantidad = 1;
            cmb_TipoDeDibujo.Items.Clear();
            cmb_SeCortaCon.Items.Clear();
        }

        public void CodigoRepetidoCaseServicios(int contadorId, string nombre)
        {
            contador = contadorId;
            BddBajaPrecio();
            LlenarSOV(nombre, valorbdd, valorbdd);
            precio = precio + (int)valorbdd;
        }

        public void CodigoRepetidoCaseVentas(string nombre)
        {
            int calculoMultiplicado = Convert.ToInt32(valorbddVentas) * cantidad;
            LlenarSOV(nombre, valorbddVentas, (float)calculoMultiplicado);
            precio = precio + calculoMultiplicado;
            cantidad = 0;

        }

        private void btn_AceptarCantidad_Click(object sender, EventArgs e)
        {
            cantidad = Convert.ToInt32(txt_Cantidad.Text);
            lblCantidad.Text = cantidad.ToString();
            txt_Cantidad.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cantidad = cantidad + 1;
            lblCantidad.Text = cantidad.ToString();
        }

        private void btn_RestarCantidad_Click(object sender, EventArgs e)
        {
            cantidad = cantidad - 1;
            lblCantidad.Text = cantidad.ToString();
        }

        private void btn_EliminarTablaVentas_Click(object sender, EventArgs e)
        {
            dgv_VentasServicios.Rows.RemoveAt(indiceCeldasDGV);
        }

        private void dgv_VentasServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceCeldasDGV = dgv_VentasServicios.CurrentRow.Index;
        }
    }
}
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

        //CLASE DATA BASE
        //DataBase DataB = new DataBase();
        public Ventas_y_Servicios()
        {
            InitializeComponent();
        }


        int PosX = 0, PosY = 0;

        SqlConnection conexion = new SqlConnection(DataBase.link);

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
            CodigoRepetidoVentas(1);
            pnl_EspumaFS.BackColor = Color.Aqua;
            label6.Enabled = true;
        }

        private void pnl_EspumaFR_Click(object sender, EventArgs e)
        {
            CodigoRepetidoVentas(2);
            pnl_EspumaFR.BackColor = Color.Aqua;
            label7.Enabled = true;
        }

        private void pnl_ShampooAP_Click(object sender, EventArgs e)
        {
            CodigoRepetidoVentas(3);
            pnl_ShampooAP.BackColor = Color.Aqua;
            label8.Enabled = true;
        }

        private void pnl_ShampooEK_Click(object sender, EventArgs e)
        {
            CodigoRepetidoVentas(4);
            pnl_ShampooEK.BackColor = Color.Aqua;
            label21.Enabled = true;
        }

        private void pnl_AcondicionadorHH_Click(object sender, EventArgs e)
        {
            CodigoRepetidoVentas(5);
            pnl_AcondicionadorHH.BackColor = Color.Aqua;
            label26.Enabled = true;
        }

        private void pnl_AcondicionadorTE_Click(object sender, EventArgs e)
        {
            CodigoRepetidoVentas(6);
            pnl_AcondicionadorTE.BackColor = Color.Aqua;
            label28.Enabled = true;
        }

        private void pnl_GelFF_Click(object sender, EventArgs e)
        {
            CodigoRepetidoVentas(7);
            pnl_GelFF.BackColor = Color.Aqua;
            label30.Enabled = true;
        }

        private void pnl_GelEH_Click(object sender, EventArgs e)
        {
            CodigoRepetidoVentas(8);
            pnl_GelEH.BackColor = Color.Aqua;
            label32.Enabled = true;
        }

        private void pnl_CeraHH_Click(object sender, EventArgs e)
        {
            CodigoRepetidoVentas(9);
            pnl_CeraHH.BackColor = Color.Aqua;
            label34.Enabled = true;
        }

        private void pnl_CeraHC_Click(object sender, EventArgs e)
        {
            CodigoRepetidoVentas(10);
            pnl_CeraHC.BackColor = Color.Aqua;
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
            InhabilitarNombres();
            contador = -1;
            ColoresParejos();
            HabilitarCmb();
            CambiarTextoCMB();
            identificador = valorId;
            cantidad = 1;
            cmb_TipoDeDibujo.Items.Clear();
            cmb_SeCortaCon.Items.Clear();
        }

        public void CodigoRepetidoVentas(int contadorventas)
        {
            InhabilitarNombres();
            ColoresParejosVentas();
            contadorVentas = contadorventas;
            bddBajaPrecioProducto();
            cantidad = 1;
            lblCantidad.Text = "1";
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

        public void InhabilitarNombres()
        {
            label9.Enabled = false;
            label10.Enabled = false;
            label11.Enabled = false;
            label24.Enabled = false;
            label13.Enabled = false;
            label15.Enabled = false;
            label16.Enabled = false;
            label17.Enabled = false;
            label14.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;
            label21.Enabled = false;
            label26.Enabled = false;
            label28.Enabled = false;
            label30.Enabled = false;
            label32.Enabled = false;
            label34.Enabled = false;
            label23.Enabled = false;
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

        private void btn_EliminarTablaServicios_Click(object sender, EventArgs e)
        {
            dgv_VentasServicios.Rows.RemoveAt(indiceCeldasDGV);
        }

        private void MoverxPanel(object sender, MouseEventArgs e)
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

        private void Cerrar(object sender, EventArgs e)
        {
            FormAdmin F1 = Owner as FormAdmin;
            F1.Visible = true;
            this.Close();
        }


        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            FormaDePago fdp = new FormaDePago();
            this.AddOwnedForm(fdp);
            if (fdp.Visible == false)
            {
                fdp.Show();
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
                fdp.Close();
            }
        }
    }
}
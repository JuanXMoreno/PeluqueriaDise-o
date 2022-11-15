using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class Ventas_y_Servicios : Form
    {
        int contador;
        int contadorVentas = -1;

        string[] ventasRealizadas = new string[11];
        string[] serviciosRealizados = new string[10];
        string buscado = "a";
        string[] valorNombres = new string[11];

        int[] cantidadXVenta = new int[11];
        int[] indiceVBDD = new int[11];
        int[] indiceSBDD = new int[10];

        int posicionVR = 0;
        int posicionSR = 0;
        int ypanel = 890;

        int indiceCeldasDGV = -1;

        int cantidad;

        int identificador = -1;
        int valorCMBSeCortaCon;
        int valorCMBTipoDeDibujo = -1;

        float valorbdd;
        float valorbddVentas;
        float valorIdProductos;
        int precio;

        //CLASE DATA BASE
        DataBase DataB = new DataBase();

        //
        string dataso = "";
        int nStocks = 0;
        public Ventas_y_Servicios()
        {
            InitializeComponent();
            Vista.DataSource = DataB.ActualizarLista(null);
            Vista.Columns[0].Visible = false;
            Vista.Columns[1].Visible = false;
            Vista.Columns[3].Visible = false;
            Vista.Columns[5].Visible = false;
            Vista.Columns[6].Visible = false;
            //CrearPanel("panelcito", "fff", "ggg");
        }

        int PosX = 0, PosY = 0;

        SqlConnection conexion = new SqlConnection(DataBase.link);

        //EN ESTA PARTE ENCONTRAMOS TODOS LOS EVENTOS DEL CODIGO

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int indice;

            switch (identificador)
            {
                case -1:
                    MessageBox.Show("Por favor seleccione una opción de la izquierda");
                    break;
                case 0:
                    FiltroDeNombres("Corte Clasico Maquina", "Corte Clasico Tijera");
                    break;
                case 1:
                    buscado = "Corte Americano";
                    break;
                case 2:
                    FiltroDeNombres("Degrade Maquina", "Degrade Navaja");
                    break;
                case 3:
                    if (valorCMBTipoDeDibujo == 0)
                    {
                        buscado = "Dibujo Simple";
                    }
                    else if (valorCMBTipoDeDibujo == 1)
                    {
                        buscado = "Dibujo Doble";
                    }
                    break;
                case 4:
                    FiltroDeNombres("Corte Barba Maquina", "Corte Barba Navaja");
                    break;
                case 5:
                    buscado = "Lineas";
                    break;
                case 6:
                    buscado = "Cejas";
                    break;
                case 7:
                    buscado = "Frente";
                    break;
                case 8:
                    buscado = "Lavado";
                    break;
            }

            for (indice = 0; indice <= 8 && serviciosRealizados[indice] != buscado; indice++)
            {
            }

            if (serviciosRealizados[indice] != buscado)
            {
                if (MessageBox.Show("Seguro que quieres agregar esto?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    switch (identificador)
                    {
                        case -1:
                            MessageBox.Show("Por favor seleccione una opción de la izquierda");
                            break;
                        case 0:
                            Sentencia(1, 2, "Corte Clasico Maquina", "Corte Clasico Tijera");
                            break;
                        case 1:
                            CodigoRepetidoCaseServicios(3, "Corte Americano");
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
                    lblTotal.Text = "Precio Total: " + precio.ToString();
                }
            }
            else
            {
                MessageBox.Show("No se pueden ingresar dos veces el mismo producto");
            }
        }

        private void btn_AgregarVentas_Click(object sender, EventArgs e)
        {

            //int indice;

            //switch (contadorVentas)
            //{
            //    case -1:
            //        MessageBox.Show("Por favor seleccione una opción de la izquierda");
            //        break;
            //    case 1:
            //        buscado = "Espuma/Afeitar Foamy Sensitive";
            //        break;
            //    case 2:
            //        buscado = "Espuma/Afeitar Foamy Regular";
            //        break;
            //    case 3:
            //        buscado = "Shampoo Elvive Loreal Paris Arcilla Purificante";
            //        break;
            //    case 4:
            //        buscado = "Shampoo Elvive Reparación Total Extreme Keratin Xs";
            //        break;
            //    case 5:
            //        buscado = "Acondicionador Elvive Loreal Hidratación Hialurónico";
            //        break;
            //    case 6:
            //        buscado = "Acondicionador Elvive Loreal Reparación Total Extreme";
            //        break;
            //    case 7:
            //        buscado = "Gel Capilar Fijación Fuerte Algabo";
            //        break;
            //    case 8:
            //        buscado = "Gel Capilar Efecto Húmedo Algabo";
            //        break;
            //    case 9:
            //        buscado = "Iyosei Cera Capilar Hydro H2O Hard";
            //        break;
            //    case 10:
            //        buscado = "Iyosei Cera Capilar Hydro Clásica";
            //        break;
            //}

            //for (indice = 0; indice <= 9 && ventasRealizadas[indice] != buscado; indice++)
            //{
            //}

            //if (ventasRealizadas[indice] != buscado)
            //{
            //    if (MessageBox.Show("Seguro que quieres agregar esto?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        switch (contadorVentas)
            //        {
            //            case -1:
            //                MessageBox.Show("Por favor seleccione una opción de la izquierda");
            //                break;
            //            case 1:
            //                CodigoRepetidoCaseVentas(1, "Espuma/Afeitar Foamy Sensitive");
            //                break;
            //            case 2:
            //                CodigoRepetidoCaseVentas(2, "Espuma/Afeitar Foamy Regular");
            //                break;
            //            case 3:
            //                CodigoRepetidoCaseVentas(3, "Shampoo Elvive Loreal Paris Arcilla Purificante");
            //                break;
            //            case 4:
            //                CodigoRepetidoCaseVentas(4, "Shampoo Elvive Reparación Total Extreme Keratin Xs");
            //                break;
            //            case 5:
            //                CodigoRepetidoCaseVentas(5, "Acondicionador Elvive Loreal Hidratación Hialurónico");
            //                break;
            //            case 6:
            //                CodigoRepetidoCaseVentas(6, "Acondicionador Elvive Loreal Reparación Total Extreme");
            //                break;
            //            case 7:
            //                CodigoRepetidoCaseVentas(7, "Gel Capilar Fijación Fuerte Algabo");
            //                break;
            //            case 8:
            //                CodigoRepetidoCaseVentas(8, "Gel Capilar Efecto Húmedo Algabo");
            //                break;
            //            case 9:
            //                CodigoRepetidoCaseVentas(9, "Iyosei Cera Capilar Hydro H2O Hard");
            //                break;
            //            case 10:
            //                CodigoRepetidoCaseVentas(10, "Iyosei Cera Capilar Hydro Clásica");
            //                break;
            //        }
            //        lblTotal.Text = "Precio Total " + precio.ToString();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No se pueden ingresar dos veces el mismo producto");
            //}
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

            cmb_SeCortaCon.Enabled = false;
            cmb_TipoDeDibujo.Enabled = false;

            identificador = 5;
            label15.Enabled = true;
            cantidad = 1;
        }

        private void pnl_Cejas_Click(object sender, EventArgs e)
        {
            ColoresParejos();
            pnl_Cejas.BackColor = Color.Aqua;

            CambiarTextoCMB();

            cmb_SeCortaCon.Enabled = false;
            cmb_TipoDeDibujo.Enabled = false;

            identificador = 6;
            label16.Enabled = true;
            cantidad = 1;
        }

        private void pnl_Frente_Click(object sender, EventArgs e)
        {
            ColoresParejos();
            pnl_Frente.BackColor = Color.Aqua;

            CambiarTextoCMB();

            cmb_SeCortaCon.Enabled = false;
            cmb_TipoDeDibujo.Enabled = false;

            identificador = 7;
            label17.Enabled = true;
            cantidad = 1;
        }

        private void pnl_Lavado_Click(object sender, EventArgs e)
        {
            ColoresParejos();
            pnl_Lavado.BackColor = Color.Aqua;

            CambiarTextoCMB();

            cmb_SeCortaCon.Enabled = false;
            cmb_TipoDeDibujo.Enabled = false;

            identificador = 8;
            label14.Enabled = true;
            cantidad = 1;
        }

        //private void pnl_EspumaFS_Click(object sender, EventArgs e)
        //{
        //    CodigoRepetidoVentas(1);
        //    pnl_EspumaFS.BackColor = Color.Aqua;
        //    label6.Enabled = true;
        //}

        //private void pnl_EspumaFR_Click(object sender, EventArgs e)
        //{
        //    CodigoRepetidoVentas(2);
        //    pnl_EspumaFR.BackColor = Color.Aqua;
        //    label7.Enabled = true;
        //}

        //private void pnl_ShampooAP_Click(object sender, EventArgs e)
        //{
        //    CodigoRepetidoVentas(3);
        //    pnl_ShampooAP.BackColor = Color.Aqua;
        //    label8.Enabled = true;
        //}

        //private void pnl_ShampooEK_Click(object sender, EventArgs e)
        //{
        //    CodigoRepetidoVentas(4);
        //    pnl_ShampooEK.BackColor = Color.Aqua;
        //    label21.Enabled = true;
        //}

        //private void pnl_AcondicionadorHH_Click(object sender, EventArgs e)
        //{
        //    CodigoRepetidoVentas(5);
        //    pnl_AcondicionadorHH.BackColor = Color.Aqua;
        //    label26.Enabled = true;
        //}

        //private void pnl_AcondicionadorTE_Click(object sender, EventArgs e)
        //{
        //    CodigoRepetidoVentas(6);
        //    pnl_AcondicionadorTE.BackColor = Color.Aqua;
        //    label28.Enabled = true;
        //}

        //private void pnl_GelFF_Click(object sender, EventArgs e)
        //{
        //    CodigoRepetidoVentas(7);
        //    pnl_GelFF.BackColor = Color.Aqua;
        //    label30.Enabled = true;
        //}

        //private void pnl_GelEH_Click(object sender, EventArgs e)
        //{
        //    CodigoRepetidoVentas(8);
        //    pnl_GelEH.BackColor = Color.Aqua;
        //    label32.Enabled = true;
        //}

        //private void pnl_CeraHH_Click(object sender, EventArgs e)
        //{
        //    CodigoRepetidoVentas(9);
        //    pnl_CeraHH.BackColor = Color.Aqua;
        //    label34.Enabled = true;
        //}

        //private void pnl_CeraHC_Click(object sender, EventArgs e)
        //{
        //    CodigoRepetidoVentas(10);
        //    pnl_CeraHC.BackColor = Color.Aqua;
        //    label23.Enabled = true;
        //}

        private void btn_AceptarCantidad_Click(object sender, EventArgs e)
        {
            if (txt_Cantidad.Text != "")
            {
                cantidad = Convert.ToInt32(txt_Cantidad.Text);
                lblCantidad.Text = cantidad.ToString();
                txt_Cantidad.Clear();
            }
            else
            {
                MessageBox.Show("Por favor ingrese la cantidad");
            }
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
            string buscadoEliminar = dgv_VentasServicios.Rows[indiceCeldasDGV].Cells[0].Value.ToString();
            int indice = 0;

            for (indice = 0; indice <= 8; indice++)
            {
                if (buscadoEliminar == ventasRealizadas[indice])
                {
                    EliminarTabla();
                    ventasRealizadas[indice] = ventasRealizadas[indice + 1];
                }
            }
        }

        private void dgv_VentasServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceCeldasDGV = dgv_VentasServicios.CurrentRow.Index;
        }

        private void btn_EliminarTablaServicios_Click(object sender, EventArgs e)
        {
            string buscadoEliminar = dgv_VentasServicios.Rows[indiceCeldasDGV].Cells[0].Value.ToString();
            int indice = 0;

            for (indice = 0; indice <= 9; indice++)
            {
                if (buscadoEliminar == serviciosRealizados[indice])
                {
                    EliminarTabla();
                    serviciosRealizados[indice] = serviciosRealizados[indice + 1];
                }
            }
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
            // FormAdmin F1 = Owner as FormAdmin;
            //  F1.Visible = true;
            this.Close();
        }

        private void FiltrarNumeros(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            FormaDePago fdp = new FormaDePago();
            this.AddOwnedForm(fdp);
            if (fdp.Visible == false)
            {
                fdp.precioTotal = precio;
                for (int i = 0; i < posicionVR; i++)
                {
                    fdp.indiceVBDDFDP[i] = indiceVBDD[i];
                    fdp.cantidadXVentaFDP[i] = cantidadXVenta[i];
                }

                for (int i = 0; i < posicionSR; i++)
                {
                    fdp.indiceSBDDFDP[i] = indiceSBDD[i];
                }
                fdp.Show();
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
                fdp.Close();
            }
        }

        // ACA ESTAN TODOS LOS METODOS QUE YO CREE

        private void HabilitarCmb() //se habilitan todos los cmb 
        {
            valorCMBSeCortaCon = -1;

            cmb_SeCortaCon.Enabled = true;
            cmb_TipoDeDibujo.Enabled = true;
        }

        private void ColoresParejos() //para volver a poner el panel a su color una vez se seleccione otro
        {
            pnl_CorteClasico.BackColor = Color.FromArgb(149, 150, 167);
            pnl_CorteAmericano.BackColor = Color.FromArgb(149, 150, 167);
            pnl_Degrade.BackColor = Color.FromArgb(149, 150, 167);
            pnl_Lineas.BackColor = Color.FromArgb(149, 150, 167);
            pnl_Cejas.BackColor = Color.FromArgb(149, 150, 167);
            pnl_Frente.BackColor = Color.FromArgb(149, 150, 167);
            pnl_Dibujo.BackColor = Color.FromArgb(149, 150, 167);
            pnl_CorteBarba.BackColor = Color.FromArgb(149, 150, 167);
            pnl_Lavado.BackColor = Color.FromArgb(149, 150, 167);
        }

        //private void ColoresParejosVentas()
        //{
        //    pnl_ShampooAP.BackColor = Color.FromArgb(149, 150, 167);
        //    pnl_ShampooEK.BackColor = Color.FromArgb(149, 150, 167);
        //    pnl_AcondicionadorHH.BackColor = Color.FromArgb(149, 150, 167);
        //    pnl_AcondicionadorTE.BackColor = Color.FromArgb(149, 150, 167);
        //    pnl_EspumaFR.BackColor = Color.FromArgb(149, 150, 167);
        //    pnl_EspumaFS.BackColor = Color.FromArgb(149, 150, 167);
        //    pnl_GelEH.BackColor = Color.FromArgb(149, 150, 167);
        //    pnl_GelFF.BackColor = Color.FromArgb(149, 150, 167);
        //    pnl_CeraHC.BackColor = Color.FromArgb(149, 150, 167);
        //    pnl_CeraHH.BackColor = Color.FromArgb(149, 150, 167);
        //}

        private void Sentencia(int a, int b, string valor1, string valor2) //interactua con el contador y el label cuando el dan esos valores
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

        private void CambiarTextoCMB() //algo visual, solo hace que el texto de los cmb sea seleccionar cada vez que se seleccione un servicio
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

        private void LlenarSOV(string valor, float valorVentaServicio, float calculoMultiplicado) //lleno la tabla de servicios y ventas
        {
            int rowEscribir = dgv_VentasServicios.Rows.Count;

            dgv_VentasServicios.Rows.Add(1);

            dgv_VentasServicios.Rows[rowEscribir].Cells[0].Value = valor;
            dgv_VentasServicios.Rows[rowEscribir].Cells[1].Value = cantidad;
            dgv_VentasServicios.Rows[rowEscribir].Cells[2].Value = valorVentaServicio;
            dgv_VentasServicios.Rows[rowEscribir].Cells[3].Value = calculoMultiplicado;
        }

        private void BddBajaPrecio() //traigo los precios de los servicios de la base de datos
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

        private void BddBajaNombreProductos() //traigo los precios de los servicios de la base de datos
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("select Nombre From Productos where Id_Producto ='" + contador + "'", conexion);
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

        private void BddBajaIdProductos() //traigo los precios de los servicios de la base de datos
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("select Id From Productos where Id_Producto ='" + contador + "'", conexion);
            SqlDataReader lector = comando.ExecuteReader();

            if (lector.HasRows == true)
            {
                while (lector.Read())
                {
                    valorIdProductos = float.Parse(lector.GetString(0));
                }
            }
            conexion.Close();
        }

        private void bddBajaPrecioProducto() //traigo los precios de los productos de la base de datos
        {
            conexion.Open();
            SqlCommand comandoProd = new SqlCommand("select Precio From Productos where Id_Producto ='" + contadorVentas + "'", conexion);
            SqlDataReader lector = comandoProd.ExecuteReader();

            if (lector.HasRows == true)
            {
                while (lector.Read())
                {
                    valorbddVentas = (float)lector.GetDecimal(0);
                }
            }
            conexion.Close();
        }

        private void CodigoRepetidoServicios(int valorId) //codigo repetido para cada evento de presionar un panel
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

        //private void CodigoRepetidoVentas(int contadorventas) //codigo repetido para cada evento de presionar un panel
        //{
        //    //InhabilitarNombres();
        //    ColoresParejosVentas();
        //    contadorVentas = contadorventas;
        //    bddBajaPrecioProducto();
        //    cantidad = 1;
        //    lblCantidad.Text = "1";
        //}

        private void CodigoRepetidoCaseServicios(int contadorId, string nombre) //codigo repetido para el boton agregar con sus respectivos "case"
        {
            contador = contadorId;
            BddBajaPrecio();
            LlenarSOV(nombre, valorbdd, valorbdd);
            serviciosRealizados[posicionSR] = nombre;
            precio = precio + (int)valorbdd;
            indiceSBDD[posicionSR] = contadorId;
            posicionSR = posicionSR + 1;
        }

        private void CodigoRepetidoCaseVentas(int contadorId, string nombre) //codigo repetido para el boton agregar con sus respectivos "case"
        {
            int calculoMultiplicado = Convert.ToInt32(valorbddVentas) * cantidad;
            LlenarSOV(nombre, valorbddVentas, calculoMultiplicado);
            ventasRealizadas[posicionVR] = nombre;
            precio = precio + calculoMultiplicado;
            cantidadXVenta[posicionVR] = cantidad;
            cantidad = 0;
            indiceVBDD[posicionVR] = contadorId;
            posicionVR = posicionVR + 1;
        }
        private void EliminarTabla() //verifico si quiere eliminar esa fila y la elimino de la tabla
        {
            if (indiceCeldasDGV >= 0)
            {
                if (MessageBox.Show("Seguro que quieres eliminar esto?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    precio = precio - Convert.ToInt32(dgv_VentasServicios.Rows[indiceCeldasDGV].Cells[3].Value.ToString());
                    lblTotal.Text = "Precio Total: " + precio.ToString();
                    dgv_VentasServicios.Rows.RemoveAt(indiceCeldasDGV);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una opcion de la tabla");
            }
        }

        private void FiltroDeNombres(string valor1, string valor2)
        {
            if (valorCMBSeCortaCon == 0)
            {
                buscado = valor1;
            }
            else if (valorCMBSeCortaCon == 1)
            {
                buscado = valor2;
            }
        }

        private void CrearPanel(string nombre, string nombre1, string nombre2)
        {
            dataso = DataB.InfoProductos().Replace("Informacion:  Productos Cargados : ", String.Empty);
            nStocks = Convert.ToInt32(dataso);

            for (int i = 0; i <= nStocks; i++)
            {
                Panel panel = new Panel();
                PictureBox picture = new PictureBox();
                Label label = new Label();

                label.Location = new Point(103, 0);
                label.Size = new Size(309, 66);
                label.Visible = true;
                label.Enabled = false;
                label.Text = nombre + i.ToString();
                label.Dock = System.Windows.Forms.DockStyle.Right;
                label.Font = new System.Drawing.Font("Kelly Slab", 12F);
                label.RightToLeft = System.Windows.Forms.RightToLeft.No;
                label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                label.Name = nombre1 + i.ToString();

                picture.Location = new Point(3, 3);
                picture.Size = new Size(89, 62);
                picture.Visible = true;
                picture.Enabled = true;
                picture.Name = nombre2 + i.ToString();

                panel.Location = new Point(18, ypanel);
                panel.Size = new Size(414, 68);
                panel.BackColor = System.Drawing.Color.FromArgb(149, 150, 167);
                panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                panel.Name = nombre + i.ToString();
                panel.Visible = true;
                panel.Enabled = true;
                ypanel = ypanel + 88;

                tbp_Ventas.Controls.Add(panel);
                panel.Click += Estilo;
                panel.Controls.Add(label);
                panel.Controls.Add(picture);
            }
        }

        private void Ventas_y_Servicios_Validated(object sender, EventArgs e)
        {
            Vista.DataSource = DataB.ActualizarLista(null);
        }

        private void BtnBusqueda_Click(object sender, EventArgs e)
        {
            Vista.DataSource = DataB.ActualizarLista(BoxBusqueda.Text);
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            BoxBusqueda.Clear();
        }

        private void BoxBusqueda_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Vista.DataSource = DataB.ActualizarLista(BoxBusqueda.Text);
        }

        private void Vista_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Estilo(object sender, EventArgs e)
        {
            MessageBox.Show("GG");
            //.BackColor = Color.FromArgb(155,155,155);
            //CodigoRepetidoVentas(2);
            //for (int i = 0; i < nStocks; i++)
            //{
            //    .BackColor = Color.Aqua;
            //    label7.Enabled = true;
            //}
        }
    }
}
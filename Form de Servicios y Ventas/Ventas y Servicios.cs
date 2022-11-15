﻿using System;
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

        string[] ventasRealizadas = new string[22];
        string[] serviciosRealizados = new string[10];
        string buscado = "a";
        

        int[] cantidadXVenta = new int[11];
        int[] indiceVBDD = new int[11];
        int[] indiceSBDD = new int[10];

        int posicionVR = 0;
        int posicionSR = 0;
     

        int indiceCeldasDGV = -1;
        int indiceCeldasLST = -1;

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
            dgv_Vista.DataSource = DataB.ActualizarLista(null);
            dgv_Vista.Columns[0].Visible = false;
            dgv_Vista.Columns[1].Visible = false;
            dgv_Vista.Columns[3].Visible = false;
            dgv_Vista.Columns[5].Visible = false;
            dgv_Vista.Columns[6].Visible = false;
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

            int indice;

            

            for (indice = 0; indice <= 20 && ventasRealizadas[indice] != buscado; indice++)
            {
            }

            if (ventasRealizadas[indice] != buscado)
            {
                if (MessageBox.Show("Seguro que quieres agregar esto?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    switch (contadorVentas)
                    {
                        case -1:
                            MessageBox.Show("Por favor seleccione una opción de la izquierda");
                            break;
                        case 1:
                            CodigoRepetidoCaseVentas(1, buscado);
                            break;
                        case 2:
                            CodigoRepetidoCaseVentas(2, buscado);
                            break;
                        case 3:
                            CodigoRepetidoCaseVentas(3, buscado);
                            break;
                        case 4:
                            CodigoRepetidoCaseVentas(4, buscado);
                            break;
                        case 5:
                            CodigoRepetidoCaseVentas(5, buscado);
                            break;
                        case 6:
                            CodigoRepetidoCaseVentas(6, buscado);
                            break;
                        case 7:
                            CodigoRepetidoCaseVentas(7, buscado);
                            break;
                        case 8:
                            CodigoRepetidoCaseVentas(8, buscado);
                            break;
                        case 9:
                            CodigoRepetidoCaseVentas(9, buscado);
                            break;
                        case 10:
                            CodigoRepetidoCaseVentas(10, buscado);
                            break;
                    }
                    lblTotal.Text = "Precio Total " + precio.ToString();
                }
            }
            else
            {
                MessageBox.Show("No se pueden ingresar dos veces el mismo producto");
            }
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
            SqlCommand comando = new SqlCommand("select Nombre From Productos where Id_Producto ='" + contadorVentas + "'", conexion);
            SqlDataReader lector = comando.ExecuteReader();

            if (lector.HasRows == true)
            {
                while (lector.Read())
                {
                    buscado = lector.GetString(0);
                }
            }
            conexion.Close();
        }

        private void BddBajaIdProductos() //traigo los precios de los servicios de la base de datos
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("select Id_Producto From Productos where Id_Producto ='" + contadorVentas + "'", conexion);
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
            cantidad = 1;
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
        private void Ventas_y_Servicios_Validated(object sender, EventArgs e)
        {
            dgv_Vista.DataSource = DataB.ActualizarLista(null);
        }
        private void btnF5_Click(object sender, EventArgs e)
        {
            txt_Busqueda.Clear();
        }

        private void Vista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceCeldasLST = dgv_Vista.CurrentRow.Index;
            contadorVentas = Convert.ToInt32(dgv_Vista.Rows[indiceCeldasLST].Cells[0].Value.ToString());
            bddBajaPrecioProducto();
            BddBajaNombreProductos();
            BddBajaIdProductos();
            cantidad = 1;
            lblCantidad.Text = "1";
            label7.Text = contadorVentas.ToString();

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void txt_Busqueda_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                dgv_Vista.DataSource = DataB.ActualizarLista(txt_Busqueda.Text);
            }
            else
            {
                dgv_Vista.DataSource = DataB.ActualizarListaXPrecio(txt_Busqueda.Text);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
        }
    }
}
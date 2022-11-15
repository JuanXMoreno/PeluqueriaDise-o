using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class FormaDePago : Form
    {
        public FormaDePago()
        {
            InitializeComponent();
        }

        public int[] cantidadXVentaFDP = new int[11];
        public int[] indiceVBDDFDP = new int[11];
        public int[] indiceSBDDFDP = new int[10];
        public int precioTotal;
        int tipoDePago;

        int PosX = 0, PosY = 0;

        SqlConnection conexion = new SqlConnection(DataBase.link);

        private void MoverXTitulo(object sender, MouseEventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Ventas_y_Servicios F1 = Owner as Ventas_y_Servicios;
            F1.Visible = true;
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            string servicios = "insert into ServiciosRealizados (Id_Servicio1, Id_Servicio2, Id_Servicio3 ,Id_Servicio4 ,Id_Servicio5 ,Id_Servicio6 ,Id_Servicio7 ,Id_Servicio8, Id_Servicio9) values('" + indiceSBDDFDP[0] + "','" + indiceSBDDFDP[1] + "','" + indiceSBDDFDP[2] + "','" + indiceSBDDFDP[3] + "','" + indiceSBDDFDP[4] + "','" + indiceSBDDFDP[5] + "','" + indiceSBDDFDP[6] + "','" + indiceSBDDFDP[7] + "','" + indiceSBDDFDP[8] + "')";
            string ventas = "insert into VentasRealizadas (Id_Producto1, Cantidad1 ,Id_Producto2 ,Cantidad2 ,Id_Producto3 ,Cantidad3 ,Id_Producto4, Cantidad4, Id_Producto5, Cantidad5, Id_Producto6, Cantidad6, Id_Producto7, Cantidad7, Id_Producto8, Cantidad8, Id_Producto9, Cantidad9, Id_Producto10, Cantidad10) values('" + indiceVBDDFDP[0] + "','" + cantidadXVentaFDP[0] + "','" + indiceVBDDFDP[1] + "','" + cantidadXVentaFDP[1] + "','" + indiceVBDDFDP[2] + "','" + cantidadXVentaFDP[2] + "','" + indiceVBDDFDP[3] + "','" + cantidadXVentaFDP[3] + "','" + indiceVBDDFDP[4] + "','" + cantidadXVentaFDP[4] + "','" + indiceVBDDFDP[5] + "','" + cantidadXVentaFDP[5] + "','" + indiceVBDDFDP[6] + "','" + cantidadXVentaFDP[6] + "','" + indiceVBDDFDP[7] + "','" + cantidadXVentaFDP[7] + "','" + indiceVBDDFDP[8] + "','" + cantidadXVentaFDP[8] + "', '" + indiceVBDDFDP[9] + "','" + cantidadXVentaFDP[9] + "')";

            if (rb_CreditoDebito.Checked == true)
            {
                tipoDePago = 2;
            }
            else if (rb_Efectivo.Checked == true)
            {
                tipoDePago = 1;
            }
            else if (rb_Transferencia.Checked == true)
            {
                tipoDePago = 3;
            }

            string formaDePago = "insert into Ventas(Id_TipoDePago) values('" + tipoDePago + "')";

            SqlCommand comando = new SqlCommand(servicios, conexion);
            comando.ExecuteNonQuery();
        }

        private void MoverXPanel(object sender, MouseEventArgs e)
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
    }
}

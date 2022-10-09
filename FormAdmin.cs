using System;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class FormAdmin : Form
    {
        AdminStock AS = new AdminStock();
        FormConfig config = new FormConfig();

        public FormAdmin()
        {
            InitializeComponent();
            this.AddOwnedForm(config);
        }

        private void btnAdminServicios_Click(object sender, EventArgs e)
        {
            Ventas_y_Servicios f1 = new Ventas_y_Servicios();
            f1.Show();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login f3 = new Login();
            f3.Close();
        }

        private void btnAdminStock_Click(object sender, EventArgs e)
        {
            if (AS.Visible == false)
            {
                AS.Visible = true;
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
                AS.Visible = false;
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if (config.Visible == false)
            {
                config.Visible = true;
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
                config.Visible = false;
            }
        }
    }
}

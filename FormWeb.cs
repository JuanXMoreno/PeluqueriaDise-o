using CefSharp;
using CefSharp.WinForms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyectoPeluquería
{
    public partial class FormWeb : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        CefSettings settings = new CefSettings();

        public FormWeb()
        {
            InitializeComponent();
            IniciarBrowser();
        }

        int PosX = 0, PosY = 0;

        public void IniciarBrowser()
        {
            //Configuracion del Chromme
            settings.CachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "WhatsAppBot\\Cache");
            settings.CefCommandLineArgs.Add("disable-gpu");
            settings.CefCommandLineArgs.Add("no-proxy-server");
            //Iniciamos el Servicio
            Cef.Initialize(settings);

            //Se abre automaticamente en: WhatsApp.Web
            chromeBrowser = new ChromiumWebBrowser("web.whatsapp.com");

            this.Controls.Add(chromeBrowser);

            chromeBrowser.Size = new Size(812, 530);
            chromeBrowser.Location = new Point(8, 8);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
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

        private void label1_MouseMove(object sender, MouseEventArgs e)
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
            this.Visible = false;
        }

        public void BuscarUser(String Numero)
        {
            chromeBrowser.Load("https://web.whatsapp.com/send?phone=" + Numero);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            BuscarUser("+5493549630404");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MandarMSJ("Hola bro todo bien ? Tenemos alto problema");
        }

        public void MandarMSJ(String msj)
        {
            StreamReader sr = new StreamReader(@"C:\Users\lucia\Source\Repos\PeluqueriaDise-o\Datos\Script.txt", true);
            var Script = sr.ReadToEnd();
            sr.Close();
            chromeBrowser.ExecuteScriptAsync(Script + "\nenviarScript('" + msj + "').then(e => console.log(`Código finalizado, ${e} Mensaje enviado.`)).catch(console.error)");
        }
    }
}

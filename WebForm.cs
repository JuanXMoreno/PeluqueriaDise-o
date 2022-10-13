using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace ProyectoPeluquería
{
    public partial class WebForm : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        CefSettings settings = new CefSettings();

        public WebForm()
        {
            InitializeComponent();
            StartCEF();
        }

        public void StartCEF()
        {
            settings.CachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "WebForm\\Cache");
            settings.CefCommandLineArgs.Add("disable-gpu");
            settings.CefCommandLineArgs.Add("no-proxy-server");
            Cef.Initialize(settings);
            chromeBrowser = new ChromiumWebBrowser("web.whatsapp.com");
            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void EnviarMensaje(String Numero,string Texto)
        {
            chromeBrowser.Load("https://web.whatsapp.com/send?phone=" + Numero);

            StreamReader sr = new StreamReader(@"Datos\\Script.txt", true);
            var Script = sr.ReadToEnd();
            sr.Close();
            chromeBrowser.ExecuteScriptAsync(Script + "\nenviarScript('" + Text + "')");
            //MessageBox.Show("Termino");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnviarMensaje("+5493549633063", "Hola mi amor");
        }

        private void EnviarMSJ_DoWork(object sender, DoWorkEventArgs e)
        {
            EnviarMensaje("+5493549633063", "Hola mi amor");
        }
    }
}

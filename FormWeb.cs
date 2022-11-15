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

        //Cola
        String[] Cola = new string[10000];
        String EnProceso = "";
        String[] Confirmados = new string[10000];
        String[] Errores = new string[10000];
        int libre = 0;
        bool Buscador = true;

        int PosX = 0, PosY = 0; //Mover Form's

        /// Procesos Necesarios para el CEF Chrome
        public void IniciarBrowser()
        {
            //Configuracion del CefSharp 
            CefSharpSettings.ShutdownOnExit = true; // Activar el cierre del Google Chrome en caso de requerirlo
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

            chromeBrowser.FrameLoadEnd += browser_FrameLoadEnd;
            chromeBrowser.ConsoleMessage += browser_ConsoleMessage;
        }

        public void browser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e) //No borrar
        {
            //Vacio
        }
        //Procesos Necesarios para el CEF Chrome


        ///Metodos del Form
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
        //Metodos del Form

        //Metodos para la 'API'

        private void label4_Click(object sender, EventArgs e) //btn para enviar la info al metodo Addcola
        {
            AddCola(textBox1.Text);
        } // Acto #1

        public string AddCola(string num) //Metodo para agregar los numeros al vector
        {
            //Agrego a la cola para enviar el mensaje.
            for (int i = 0; i < Cola.Length; i++)
            {
                if (Cola[i] == null)
                {
                    Console.WriteLine("Se encontro un lugar disponible. N#" + i + "-------Se agregara este numero: " + num);
                    Cola[i] = num;
                    break;
                }
            }
            IniciarBusqueda.Enabled = true; //Aqui activo el buscador
            return num;
        } // Acto #2 (#1)
        private void IniciarBusquedaTimer(object sender, EventArgs e) // Acto #3
        {
            if (Buscador == true)
            {
                Console.WriteLine("Buscando numeros en cola.");
                for (int i = 0; i < Cola.Length; i++)
                {
                    if (Buscador == true)
                    {
                        if (Cola[i] != null)
                        {
                            Console.WriteLine("----------\nNumero de fila #" + i + "\nNumero de telefono: " + Cola[i] + "\nEnviado.");
                            BuscarUser(Cola[i].ToString()); //Envio el numero al metodo
                            EnProceso = Cola[i]; //Lo envio a esta variable para recordarla facilmente
                            Cola[i] = null; //Elimino el numero
                            Buscador = false; //Desactivo el buscador
                            break;
                        }
                    }
                }
            }
            IniciarBusqueda.Enabled = false; // Detengo el Timer momentaneamente
        }
        public bool BuscarUser(String Numero)//Inicia la busqueda del usuario // Acto #4
        {
            EnviarScript.Enabled = true;
            bool Verificado = false;
            try
            {
                chromeBrowser.Load("https://web.whatsapp.com/send?phone=" + Numero);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro un error:\n" + ex);
            }
            return Verificado;
        }
        private void EnviarScriptTime(object sender, EventArgs e)//Timer que verifica el estado del Chrome (Envia un scrip para ubicarse) // Acto #5
        {
            WhatsAppLobby();
            WhatsAppHome();
            WhatsAppErrorNoExist();
        }
        public void WhatsAppLobby()
        {
            try
            {
                chromeBrowser.EvaluateScriptAsync(Properties.Resources.VeriLobby);
            }
            catch (Exception er)
            {
                Console.WriteLine("Se encontro un error en el metodo WhatsAppLobby.\nError: " + er);
            }
        } // Acto #6 //script
        public void WhatsAppHome()
        {
            try
            {
                chromeBrowser.EvaluateScriptAsync(Properties.Resources.ProcAndHome);
            }
            catch (Exception er)
            {
                Console.WriteLine("Se encontro un error en el metodo WhatsAppHome.\nError: " + er);
            }
        }  // Acto #7 //script
        public void WhatsAppErrorNoExist()
        {
            try
            {
                chromeBrowser.EvaluateScriptAsync(Properties.Resources.MensajeDeError);
            }
            catch (Exception er)
            {
                Console.WriteLine("Se encontro un error en el metodo WhatsAppErrorNoExist.\nError: " + er);
            }
        } // Acto # 8 //script
        public void browser_ConsoleMessage(object sender, ConsoleMessageEventArgs e)//Lee la consola (Aqui se verifican los metodos y se envian las directivas¿) Acto #9
        {
            var mensaje = e.Message;
            try
            {
                if (mensaje == "[/lobby]" || mensaje == "Para usar WhatsApp en tu computadora:")
                {
                    DialogResult result = MessageBox.Show("Sesion de WhatsApp no encontrada. Vuelva a iniciar sesion para enviar mensajes.", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        this.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Se cancelaran los mensajes en cola. Muchas gracias\nRata");
                        Buscador = false;
                    }
                }
                if (mensaje == "[Cargando]")
                {
                    Console.WriteLine("Se esta cargando todo....");
                }
                if (mensaje == "[Se encontro un error.]" || mensaje == "El número de teléfono compartido a través de la dirección URL es inválido")
                {
                    Console.WriteLine("Se encontro un numero no valido. se enviara a error para revisar luego.");
                    for (int i = 0; i < Errores.Length; i++)
                    {
                        if (Errores[i] == null)
                        {
                            Errores[i] = EnProceso;
                            Buscador = true;
                            break;
                        }
                    }
                }
                if (mensaje == "[EXITO]")
                {
                    EnviarScript.Enabled = false;
                    mensaje = null;
                    Console.WriteLine("Sesion iniciada y Preparada");
                    Exito.Enabled = true;
                }
                if (mensaje == "[Error. No chat]")
                {
                    Console.WriteLine("No se encontro el chat. ERROR");
                }
                if (mensaje == "[Script Ejecutado]")
                {
                    Intervalo.Enabled = true;
                }
            }
            catch (Exception er)
            {
                Console.WriteLine("Se encontro un error de chrome: " + er);
            }
            //Console.WriteLine("Mensajes de Chrome: "+e.Message); ///Metodo para leer los mensajes
        }
        private void Exito_Tick(object sender, EventArgs e) //Timer, espera unos segundo antes de mandar el mensaje xd //Acto #10
        {
            EnviarMensj();
            Exito.Enabled = false;
        }
        public void EnviarMensj()//Aqui se envia el mensaje //Acto #11
        {
            StreamReader sr1 = new StreamReader(@"C:\Users\lucia\Source\Repos\PeluqueriaDise-o\Datos\NewCliente.txt", true);
            var NewCliente = sr1.ReadToEnd();
            sr1.Close();
            chromeBrowser.ExecuteScriptAsync(Properties.Resources.Sendmsj + "\nenviarScript(`" + NewCliente + "`).then(console.log(`[Script Ejecutado]`))");
        }
        private void Intervalo_Tick(object sender, EventArgs e) // Casi final
        {
            for (int i = 0; i < Confirmados.Length; i++)
            {
                if (Confirmados[i] == null)
                {
                    Confirmados[i] = EnProceso;
                    break;
                }
            }
            Buscador = true;
            Intervalo.Enabled = false;
            IniciarBusqueda.Enabled = true;
        }
        private void Verificar_Click(object sender, EventArgs e)
        {
            VerificarLista();
        } //Verificar Lista
        private void label2_Click(object sender, EventArgs e) //Solo es de prueba
        {
            AddCola("+5493549630404");
            AddCola("+5493549557924");
            AddCola("+5493548596235");
        }
        public void VerificarLista() //Metodo para verificar lista
        {
            for (int i = 0; i < Cola.Length; i++)
            {
                if (Cola[i] != null)
                {
                    Console.WriteLine("Cola #" + i + " Numero contenido dentro de ella: " + Cola[i]);
                }
                if (Confirmados[i] != null)
                {
                    Console.WriteLine("Confirmados #" + i + " Numero contenido dentro de ella: " + Confirmados[i]);
                }
                if (Errores[i] != null)
                {
                    Console.WriteLine("Errores #" + i + " Numero contenido dentro de ella: " + Errores[i]);
                }
            }
        }
    }
}

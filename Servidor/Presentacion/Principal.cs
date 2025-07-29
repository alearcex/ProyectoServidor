using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;


namespace Servidor
{
    public partial class Principal : Form
    {
        #region Atributos
        private TcpListener tcpListener;
        private Thread listenThread;
        private String lastMessage;
        private int clientesConectados;
        #endregion
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Txt_Mensajes.Text = "Servidor Iniciado. Esperando por clientes...\n";
            this.tcpListener = new TcpListener(IPAddress.Any, 30000);
            this.listenThread = new Thread(new ThreadStart(ListenForClients));
            this.listenThread.Start();
        }
        private void ListenForClients()
        {
            this.tcpListener.Start();
            while (true)
            {
                //blocks until a client has connected to the server
                TcpClient client = this.tcpListener.AcceptTcpClient();
                //create a thread to handle communication
                //with connected client
                clientesConectados++;

                if (InvokeRequired)
                    Invoke(new Action(() => Txt_Clientes.Text = clientesConectados.ToString())); 
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            }
        }
        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();
            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] message = new byte[4096];
            int bytesRead;
            while (true)
            {
                bytesRead = 0;
                try
                {
                    //blocks until a client sends a message
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    //a socket error has occured
                }
                if (bytesRead == 0)
                {
                    //the client has disconnected from the server
                    clientesConectados--;

                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => Txt_Clientes.Text = clientesConectados.ToString()));
                    }
                    break;
                }

                //message has successfully been received
                //encoder = new ASCIIEncoding();
                System.Diagnostics.Debug.WriteLine(encoder.GetString(message, 0, bytesRead));
                lastMessage = encoder.GetString(message, 0, bytesRead);


                if (InvokeRequired)
                {
                    Invoke(new Action(() => Txt_Mensajes.Text = "\n" + lastMessage));
                    int Opcion = Validar_Peticion(Txt_Mensajes.Text);
                    byte[] buffer = new byte[4096];

                    switch (Txt_Mensajes.Text.Trim())
                    {  
                        // hace el proceso de verificacion de la cedula ingresada
                        case "108040378":
                            buffer = encoder.GetBytes("1MELVIN CASCANTE MORALES0094SAN ATONIO CORANADO");
                            clientStream.Write(buffer, 0, buffer.Length);
                            clientStream.Flush();
                            break;
                        case "108040379":
                            buffer = encoder.GetBytes("1JUANA PEREZ PREZ00105HEREDIA CENTRO");
                            clientStream.Write(buffer, 0, buffer.Length);
                            clientStream.Flush();
                            break;
                             
                        case "999999999":
                            buffer = encoder.GetBytes("2SUTANITO DE TAL APERECE FALLECIDO");
                            clientStream.Write(buffer, 0, buffer.Length);
                            clientStream.Flush();
                            break;
                        default:
                            if (Txt_Mensajes.Text.Length < 9)
                                buffer = encoder.GetBytes("4FORMATO INVALIDO");
                            else
                                buffer = encoder.GetBytes("3CEDULANO EXISTE");

                            clientStream.Write(buffer, 0, buffer.Length);
                            clientStream.Flush();
                            break;
                    }

                }
            }
            // tcpClient.Close();
            // clientesConectados--;

            //if (InvokeRequired)
            //{
            //  Invoke(new Action(() => Txt_Clientes.Text = clientesConectados.ToString()));
            //}

        }
        public int Validar_Peticion(string Peticion)
        {
            switch (Peticion)
            {
                case "001":
                    return 1;
                case "002":
                    return 2;
                default:
                    return -1;

            }
        }
    }
}
        

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Connexion avec l'IP
using System.Net;
using System.Net.Sockets;

namespace Client_LOURD
{
    public partial class chat : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;

        public chat()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            //Convert string message to byte[]
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(textBoxMessage.Text);
            //Sending the encoded message
            sck.Send(sendingMessage);
            //Adding to the listbox
            listBoxMessage.Items.Add("Me: " + textBoxMessage.Text);
            textBoxMessage.Text = "";

        }

        private void chat_Load(object sender, EventArgs e)
        {
            //Configuration du socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //Get local IP
            textBoxLocalP.Text = GetLocalIP();
            textBoxRemoteIP.Text = GetLocalIP();

        }
        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";

        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            //Binding socket
            epLocal = new IPEndPoint(IPAddress.Parse(textBoxLocalP.Text), Convert.ToInt32(textBoxLocalPort.Text));
            sck.Bind(epLocal);
            //Connection avec le remote IP
            epRemote = new IPEndPoint(IPAddress.Parse(textBoxRemoteIP.Text), Convert.ToInt32(textBoxRemotePort.Text));
            sck.Connect(epRemote);  
            //Ecouter le port specifique
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {          
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;
                //Convertion byte[] to string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                //Adding this message into listBox blabla
                listBoxMessage.Items.Add("Destinataire: " + receivedMessage);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception ex)
            {
            MessageBox.Show(ex.ToString());
    
            }
        }
    }
}

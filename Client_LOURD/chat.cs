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
    }
}

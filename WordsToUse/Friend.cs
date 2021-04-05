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
using System.Net;

namespace WordsToUse
{
    public partial class Friend : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        private byte[] receivedData;

        public Friend()
        {
            InitializeComponent();
        }

        private void Friend_Load(object sender, EventArgs e)
        {
            // set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            // get user IP
            textLocalIP.Text = GetLocalIP();
            textRemoteIP.Text = GetLocalIP();

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            //biding Socket
            epLocal = new IPEndPoint(IPAddress.Parse(textLocalIP.Text), Convert.ToInt32(textLocalPort.Text));
            sck.Bind(epLocal);


            //Connecting to remote IP
            epRemote = new IPEndPoint(IPAddress.Parse(textRemoteIP.Text), Convert.ToInt32(textRemotePort.Text));
            sck.Connect(epRemote);

            //Listening the specific port

            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress iP in host.AddressList)
            {
                if (iP.AddressFamily == AddressFamily.InterNetwork)
                    return iP.ToString();
            }
            return "192.168.1.10";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            //Covert String message to byte[]
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(textMessage.Text);

            //Sending the Encoded message
            sck.Send(sendingMessage);
            //adding to the list box
            listMessage.Items.Add("Me: " + textMessage.Text);
            textMessage.Text = "";

        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receiveData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;

                //Converting byte[] to string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                //Adding this message into ListBox
                listMessage.Items.Add("Friend: " + receivedMessage);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

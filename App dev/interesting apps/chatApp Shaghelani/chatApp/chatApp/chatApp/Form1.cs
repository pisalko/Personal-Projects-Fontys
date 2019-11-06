using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

// Version 1.0 MS

namespace chatApp
{
    public partial class Form1 : Form
    {
        // Declaring a Net Socket object
        Socket sck;
        // Declaring 2 Endpoints objects for 2 pcs
        EndPoint epLocal, epRemote;

        // An array to holds the message 
        byte[] buffer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //setup socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //get user ip
            textBoxLocalIP.Text = GetLocalIP();
            // in case that you want to test it with one pc 
            //textBoxRemotIP.Text = GetLocalIP();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            //binding Socket
            epLocal = new IPEndPoint(IPAddress.Parse(textBoxLocalIP.Text), Convert.ToInt32(textBoxLocalPort.Text));
            sck.Bind(epLocal);

            epRemote = new IPEndPoint(IPAddress.Parse(textBoxRemotIP.Text), Convert.ToInt32(textBoxRemotePort.Text));
            sck.Connect(epRemote);
            //start the connection 
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }

        // A method to get your IP address from DNS server
        private string GetLocalIP()
        {

            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";

        }

        private void buttonMessage_Click(object sender, EventArgs e)
        {
            // convert string msg to byte[]
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(textBoxMessage.Text);
            // send the msg
            sck.Send(sendingMessage);
            // adding the msg to listbox
            listBoxMessage.Items.Add("Me: " + textBoxMessage.Text);
            textBoxMessage.Text = "";
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;

                //converting byte[] to string

                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);


                //add to list box
                listBoxMessage.Items.Add("Friend "+ receivedMessage);

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

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

// Version 1.2 MS

namespace chatApp
{
    public partial class Form1 : Form
    {

        //Create an object of the class
        WebSocket ws;

        public Form1()
        {
            InitializeComponent();
            ws = new WebSocket();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //get user ip
            textBoxLocalIP.Text = ws.GetLocalIP();
            timerListBox.Start();
            // in case that you want to test it with one pc 
            //textBoxRemotIP.Text = GetLocalIP();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            ws.connect(textBoxLocalIP.Text, textBoxLocalPort.Text, textBoxRemotIP.Text, textBoxRemotePort.Text);
            MessageBox.Show("Connection has been established. Now you can start sending messages. ");

        }

        private void buttonMessage_Click(object sender, EventArgs e)
        {
            //send the msg
            ws.sendMsg(textBoxMessage.Text);
            textBoxMessage.Text = "";
        }

        private void timerListBox_Tick(object sender, EventArgs e)
        {
            listBoxMessage.Items.Clear();
            foreach (var item in ws.messages) {
                listBoxMessage.Items.Add(item);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}

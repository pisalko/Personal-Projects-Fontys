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
using System.IO.Ports;

namespace IPProject
{
    public partial class ChefForm : Form
    {
        WebSocket ws;
        public ChefForm()
        {
            InitializeComponent();
            InitPort();
            tmChef.Start();
            ws = new WebSocket();
            ws.connect("192.168.178.123", "80", "192.168.178.123", "80");
        }

        private void spArduino_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (spArduino.BytesToRead > 0)
            {
                string data = spArduino.ReadLine().Replace("\r", "");
                if (data == "Ready")
                {
                    if (lbxChef.InvokeRequired)
                    {
                        lbxChef.BeginInvoke(new MethodInvoker(delegate
                        {
                            if (!this.IsDisposed)
                            {
                                lbxChef.Items.Add("Pizza is Ready!");
                            }
                        }));
                    }
                }
            }
        }
        private void InitPort()
        {
            try
            {

                if (SerialPort.GetPortNames().Length > 0)
                {
                    spArduino.BaudRate = 9600;
                    spArduino.PortName = "COM4";
                    spArduino.Open();
                }
                else
                {
                    MessageBox.Show("Arduino Device is not connected");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void tmChef_Tick(object sender, EventArgs e)
        {
            lbxChef.Items.Clear();
            foreach (var item in ws.messages)
            {
                lbxChef.Items.Add(item);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ws.sendMsg("Pizza is Ready");
        }
        Point lastClick; //Holds where the Form was clicked
        private void ChefForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = new Point(e.X, e.Y); //We'll need this for when the Form starts to move
        }

        private void ChefForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Only when mouse is clicked
            {
                //Move the Form the same difference the mouse cursor moved;
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }
    }
}

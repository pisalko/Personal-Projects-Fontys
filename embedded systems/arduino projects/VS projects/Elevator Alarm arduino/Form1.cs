using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator_Alarm_arduino
{
    public partial class Form1 : Form
    {

        bool responded, button1Bool, labelText = false;
        string textInPort;

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Green;
            label1.Text = "Alarm is OFF";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            if (button1Bool)
                {
                    serialPort1.WriteLine("Responded");
                }
            
            responded = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (responded)
            {
                this.BackColor = Color.Green;
                label1.Text = "Alarm is OFF";
                serialPort1.WriteLine("Clear");
                responded = false;
            }
            else
            {
                MessageBox.Show("Please respond to the alarm first!");
            }
            
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            textInPort = serialPort1.ReadLine();
            textInPort.Trim();
            textInPort = textInPort.Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
            if (textInPort == "Alarm sounded!")
            {
                this.BackColor = Color.Red;
                
                button1Bool = true;
                labelText = true;
            }
           
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (labelText)
            {
                label1.Text = "Alarm is ON!!!";
                labelText = false;
            }

        }
    }
}
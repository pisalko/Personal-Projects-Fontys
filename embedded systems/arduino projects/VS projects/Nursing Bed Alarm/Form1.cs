using System;
using System.Drawing;
using System.Windows.Forms;

namespace Nursing_Bed_Alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char modeCheck;
        String textInPort = "";
        bool alarmSounded;
        string timeOnly;
        int temperature;

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            serialPort1.Open();
            timeOnly = dt.ToString("HHmm");
        }
        bool once = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (modeCheck == '1')
            {
                DateTime dt = DateTime.Now;
                if (once)
                {
                    serialPort1.WriteLine("t:" + timeOnly);
                    once = false;
                }
                bool timeOnlyCheck = timeOnly != dt.ToString("HHmm");

                if (timeOnlyCheck)
                {
                    timeOnly = dt.ToString("HHmm");
                    serialPort1.WriteLine("t:" + timeOnly);
                    
                }
                label2.Text = "Switch to mode 2 for room temperature.";
            }
            else if (modeCheck == '2')
            {
                label2.Visible = true;
                double temperatureFl = Convert.ToDouble(temperature) / 100;
                    label2.Text = "Room temperature is: " + temperatureFl.ToString() + " degrees Celsius";
            }
            else if (modeCheck == '3')
            {
                label2.Text = "Switch to mode 2 for room temperature.";
            }

            if (modeCheck != '1')
                once = true;

            if(alarmSounded)
            {
                pictureBox1.BackColor = Color.Red;
            }
            
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            

            textInPort = serialPort1.ReadLine();
            textInPort.Trim();
            textInPort = textInPort.Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
            

            if(textInPort == "a")
            {

                alarmSounded = true;
            }
            else
            {
                alarmSounded = false;
                switch (textInPort)
                {
                    case "1":
                        modeCheck = '1';
                        break;

                    case "2":
                        modeCheck = '2';
                        break;

                    case "3":
                        modeCheck = '3';
                        break;


                }
            }
                if (textInPort.StartsWith("z"))
                {
                    temperature = Convert.ToInt32(textInPort.Substring(1));
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("r");
            pictureBox1.BackColor = Color.Transparent;
            alarmSounded = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_BackColorChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            if (pictureBox1.BackColor == Color.Red)
            { 
            string time = dt.ToString("HH:mm");
            listBox1.Items.Add(time + "  Alarm Sounded!");
            } 
            else if (pictureBox1.BackColor == Color.Transparent)
            {
                string time = dt.ToString("HH:mm");
                listBox1.Items.Add(time + "  Alarm Reset!");
            }
        }
    }
}

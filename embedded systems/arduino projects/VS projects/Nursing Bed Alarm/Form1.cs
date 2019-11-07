using System;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            serialPort1.Open();
            timeOnly = dt.ToString("HHmm");
        }
        bool once = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //if (modeCheck == 1)
            //{
                DateTime dt = DateTime.Now;
            if (modeCheck == '1')
            {
                if(once)
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
            }
            //}
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //modeCheck = Convert.ToChar(serialPort1.ReadChar());
            textInPort = serialPort1.ReadLine();
            textInPort.Trim();
            textInPort = textInPort.Replace("\r\n", "").Replace("\r", "").Replace("\n", "");

            /*if (textInPort.StartsWith("s"))
            {
                MessageBox.Show(textInPort.Substring(1, textInPort.Length - 1));
            }*/

            switch (textInPort)
            {
                case "a":
                    alarmSounded = true;
                    break;
                default:
                    alarmSounded = false;
                    break;
                    

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_First_Exercise
{
    public partial class Form1 : Form
    {
        int strRes = 0;
        int result = 0;
        string resultSteps;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int numBase = Convert.ToInt32(textBox1.Text);
            int length = Convert.ToInt32(textBox2.Text);
            
            for (int counter = 1; counter <= length; counter++)
            {
                result = result + counter*numBase;
                strRes = counter * numBase;
                resultSteps = resultSteps + strRes.ToString() + " ";

            }
            label3.Text = resultSteps;
            button1.Text = result.ToString();


        }
    }
}

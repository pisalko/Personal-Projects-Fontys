using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_CALC
{
    public partial class Form1 : Form
    {
        double BMI;
        double weight;
        double height;
        double height2;

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            weight = Convert.ToDouble(textBox2.Text);
            height = Convert.ToDouble(textBox1.Text);

            height2 = (height * height);
            BMI = weight / height2;
            BMI.ToString("0.00");

            button1.Text = "Your BMI is: " + BMI.ToString("0.00");
            if (BMI < 18.5)
            {
                label4.Text = "You are underweight.";
            } else if (BMI >= 18.5 && BMI < 25)
            {
                label4.Text = "What's your number ?";
            }
            else if (BMI >= 25 && BMI < 30)
            {
                label4.Text = "You are Big Boned.";
            }
            else if (BMI >= 30)
            {
                label4.Text = "You are extremely thicc.";
            }
        }

    }
}

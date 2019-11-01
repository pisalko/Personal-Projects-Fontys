using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_2_IF_statements__DEMO_
{
    public partial class Form1 : Form
    {

        double totalPrice;
        bool a;
        bool b;
        bool c;
        bool d;
        int nmbrt;
        public Form1()
        {
            InitializeComponent();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
           
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                b = true;
            }
            
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            nmbrt = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked)
            {
                a = true;
            }
            if (radioButton2.Checked)
            {
                b = true;
            }
            if (radioButton3.Checked)
            {
                c = true;
            }
            if (radioButton4.Checked)
            {
                d = true;
            }

            if (a && c == true)
            {
                totalPrice = 8 * nmbrt;
            }
            if ( a && d == true)
            {
                totalPrice = 12 * nmbrt;
            }
            if (b && c == true)
            {
                totalPrice = 16 * nmbrt;
            }
            if (b && d == true)
            {
                totalPrice = 24 * nmbrt;
            }
            label2.Text = "The total ticket price is: " + totalPrice.ToString() + " euro.";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

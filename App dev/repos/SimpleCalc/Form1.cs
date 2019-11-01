using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
           
            double ffirst = double.Parse(first.Text);
            double ssecond = double.Parse(second.Text);
            double result = ffirst + ssecond;
            string rr = result.ToString();
            equal.Text = rr;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double ffirst = Convert.ToDouble(first.Text);
            double ssecond = Convert.ToDouble(second.Text);
            double result = ffirst*ssecond;
            string rr = result.ToString();
            equal.Text = rr;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void First_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            double ffirst = double.Parse(first.Text);
            double ssecond = double.Parse(second.Text);
            double result = ffirst - ssecond;
            string rr = result.ToString();
            equal.Text = rr;
        }

        private void Deleno_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(second.Text) == 0)
            {
                MessageBox.Show("Do not divide by 0!");
            }
            double ffirst = double.Parse(first.Text);
            double ssecond = double.Parse(second.Text);
            double result = ffirst/ssecond;
            string rr = result.ToString();
            equal.Text = rr;
        }
    }
}

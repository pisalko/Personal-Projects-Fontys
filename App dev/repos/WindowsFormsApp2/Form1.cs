using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();

       


        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double ffirst = Convert.ToDouble(first.Text);
            double ssecond = Convert.ToDouble(second.Text);
            double result = ffirst * ssecond;
            string rr = result.ToString();
            equal.Text = rr;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            double ffirst = double.Parse(first.Text);
            double ssecond = double.Parse(second.Text);
            double result = ffirst - ssecond;
            string rr = result.ToString();
            equal.Text = rr;
        }

        private void First_TextChanged(object sender, EventArgs e)
        {

        }

        private void Plus_Click(object sender, EventArgs e)
        {
            double ffirst = double.Parse(first.Text);
            double ssecond = double.Parse(second.Text);
            double result = ffirst + ssecond;
            string rr = result.ToString();
            equal.Text = rr;
        }

        private void Deleno_Click(object sender, EventArgs e)
        {
            double ffirst = double.Parse(first.Text);
            double ssecond = double.Parse(second.Text);
            double result = ffirst / ssecond;
            string rr = result.ToString();
            equal.Text = rr;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "This app is meant to substract, add, multiply or divide numbers. \r\n \r\n Made by Valio";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }
    }
}

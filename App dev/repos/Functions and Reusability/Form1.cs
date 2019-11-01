using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Functions_and_Reusability
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Calc (double a, double b)
        {
            double total = a / b;
            return total;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Calc(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString("0.00");
        }
    }
}

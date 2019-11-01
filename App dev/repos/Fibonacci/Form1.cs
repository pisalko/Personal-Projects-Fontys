using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int prePrevious = 0;
        int previous, fibonacci = 1;
      

        private int Calc (int number)
        {
            int result = 0;

            while (result <= number)
            {
                //smallest quadruple
                result = result + 4;
            }
            return result;
        }

        private int CalcFibonacci(int number)
        {
            while (number >= fibonacci)
            {
                prePrevious = previous;
                previous = fibonacci;
                fibonacci = prePrevious + previous;
            }
            return fibonacci;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);
            label1.Text = "The result is: " + CalcFibonacci(number).ToString();
            //label1.Text = "The result is: " + Calc(number).ToString();
            radioButton1.
        }
    }
}

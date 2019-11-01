using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.DarkRed;
            button1.BackColor = Color.Black;
        }
        string bruh;
        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {

                if (i % 5 == 0 && i % 3 == 0)
                {
                    bruh += "FizzBuzz ";
                }
                else if (i % 3 == 0)
                {
                    bruh += "Fizz ";
                }
                else if (i % 5 == 0)
                {
                    bruh += "Buzz ";
                }
                else
                {
                    bruh += i.ToString() + " ";
                }
            }
            button1.Text = bruh;
        }
    }
}

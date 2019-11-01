using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA_Toggle_Colors
{
    public partial class Form1 : Form
    {
        int a = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
             if (a%2 == 1)
            {
                a++;
                this.BackColor = Color.Green;
            }else if (a%2 == 0)
            {
                a++;
                this.BackColor = Color.Purple;
            }
        }
    }
}

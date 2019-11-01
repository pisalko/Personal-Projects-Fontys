using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA_Toggle_Colors_Extended
{
    public partial class Form1 : Form
    {
        int a = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.BackColor = Color.Cyan;
                a++;
            }else if( a == 2)
            {
                this.BackColor = Color.Purple;
                a++;
            }else if (a == 3)
            {
                this.BackColor = Color.Orange;
                a = 1;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lists_First_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> integers = new List<int>();
        int counter = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            integers.Add(counter);
            listBox1.Items.Add(integers[counter]);
            counter++;
        }
    }
}

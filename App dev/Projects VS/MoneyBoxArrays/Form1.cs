using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyBoxArrays
{
    public partial class MoneyBoxForm : Form
    {
        int u = 0;
        private int Counter(int i)
        {
            i++;
            return i;
        }

        int[] typeOfCoins;
        double[] valueOfCoins;

        public MoneyBoxForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            typeOfCoins = new int[6];
            valueOfCoins = new double[6];
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Counter(u).ToString();
            u++;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Counter(0);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Counter(0);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Counter(0);
        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }
    }
}

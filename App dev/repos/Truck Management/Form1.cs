using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Truck_Management
{
    public partial class Form1 : Form
    {

        int bxor;
        int bxPerPallet;
        int capacityTrucks;
        public Form1()
        {
            InitializeComponent();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bxor = int.Parse(textBox3.Text);
            bxPerPallet = int.Parse(textBox2.Text);
            capacityTrucks = int.Parse(textBox1.Text);

            int bxPerTruck = bxPerPallet * capacityTrucks;
            int ft = bxor/bxPerPallet/capacityTrucks;
            int br = bxor - (ft * bxPerTruck);
            int pr = br / bxPerPallet;
            int fbxr = br - (pr * bxPerPallet);


            label7.Text = "Full trucks: " + ft;
            pll.Text = "Full pallets remaining: " + pr;
            label6.Text = "Boxes remaining: " + fbxr;
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Pll_Click(object sender, EventArgs e)
        {

        }
    }
}

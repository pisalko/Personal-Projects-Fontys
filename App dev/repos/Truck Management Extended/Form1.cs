using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Truck_Management_Extended
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bxor;
        int bxPerPallet;
        int capacityTrucks;

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bxPerPallet = 30;
            textBox2.Text = Convert.ToString(bxPerPallet);
            capacityTrucks = 20;
            textBox1.Text = Convert.ToString(capacityTrucks);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bxor = int.Parse(textBox3.Text);
            bxPerPallet = int.Parse(textBox2.Text);
            capacityTrucks = int.Parse(textBox1.Text);

            int bxPerTruck = bxPerPallet * capacityTrucks;
            int ft = bxor / bxPerPallet / capacityTrucks;
            int br = bxor - (ft * bxPerTruck);
            int pr = br / bxPerPallet;
            int fbxr = br - (pr * bxPerPallet);


            label7.Text = "Full trucks: " + ft;
            pll.Text = "Full pallets remaining: " + pr;
            label6.Text = "Boxes remaining: " + fbxr;
        }

        private void Pll_Click(object sender, EventArgs e)
        {

        }

       
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Who_am_I
{
    public partial class Form1 : Form
    {
 
        Random rnd = new Random();
        int ir;

        public Form1()
        {
           
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YOU ACTIVATED MY TRAP CARD!");
            MessageBox.Show("1 + 1 = 3");
            MessageBox.Show("Quick Maths");
            MessageBox.Show("My name is Valio btw");
            MessageBox.Show("This will go on forever");
            MessageBox.Show("...Trust me, its an infinite for loop");
            MessageBox.Show(".....");
            MessageBox.Show("SIKE, YOU THOUGHT");

        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {

            int a = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            int c = rnd.Next(0, 255);
            this.progressBar1.Value = this.trackBar1.Value;
            this.label1.Text = this.trackBar1.Value.ToString();
            
            this.BackColor = Color.FromArgb(a, b, c);
            
           

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("./OG.jpg");
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("./rose.jpg");
        }

        public void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("./SIKE.jpg");
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            ir = rnd.Next(0, 2);
            this.BackgroundImage = imageList1.Images[ir];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
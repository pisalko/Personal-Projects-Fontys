using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SmallestFibonachiNumber
{
    public partial class Form1 : Form
    {
        

    public Form1()
        {
            InitializeComponent();
            label();
            //this.BackgroundImage = Image.FromFile("C:\\");
        }

         private void label()
        {
            label1.Text = "Any special preferences/request,\r\n please enter here:";

        }



        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
    public class GradientPanel : Form1
    {
        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }
        public float ANgle { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.TopColor, this.BottomColor, this.ANgle);
            Graphics g = e.Graphics;
            g.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}

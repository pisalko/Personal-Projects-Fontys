using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace If_statements_BEER
{
    public partial class Form1 : Form
    { 

        
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
           if(radioButton1.Checked != true && radioButton2.Checked !=true)
            {
                MessageBox.Show("You did not select a drink.");
            }else
            if (radioButton1.Checked)
            {
                this.BackColor = Color.Yellow;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                MessageBox.Show("Enjoy your lemonade !");
            }

            if (checkBox1.Checked && radioButton2.Checked)
            {
                this.BackColor = Color.Green;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                MessageBox.Show("You are allowed to drink ! Enjoy your beverage !");
            }
            else
            if (checkBox1.Checked != true && radioButton2.Checked)
            {
                this.BackColor = Color.Red;
                MessageBox.Show("You are not of age to drink ! Please order something else");
            }
        }
    }
}

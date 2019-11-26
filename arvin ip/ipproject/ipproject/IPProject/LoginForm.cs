using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            tbUsername.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != string.Empty && tbPassword.Text != string.Empty)
            {
                if (tbUsername.Text.ToLower() == "cashier" && tbPassword.Text == "1")
                {
                    this.Hide();
                    MainForm CashierForm = new MainForm();
                    CashierForm.Show();
                }
                if (tbUsername.Text.ToLower() == "chef" && tbPassword.Text == "2")
                {
                    this.Hide();
                    ChefForm chef_Form = new ChefForm();
                    chef_Form.Show();
                }
            }
        }
        Point lastClick; //Holds where the Form was clicked
        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = new Point(e.X, e.Y); //We'll need this for when the Form starts to move
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Only when mouse is clicked
            {
                //Move the Form the same difference the mouse cursor moved;
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }
    }
}

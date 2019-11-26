using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace IPProject
{
    public partial class MainForm : Form
    {
        WebSocket ws;
        public MainForm()
        {
            InitializeComponent();
            tbOrderno.Text = "1";
            tmCashier.Start();
            ws = new WebSocket();
            ws.connect("145.93.60.104", "81", "145.93.37.54", "80");
        }

        private void BtnRegisterOrder_Click(object sender, EventArgs e)
        {
            Panel newpnl = new Panel();
            newpnl.Parent = pnlParentside;
            newpnl.Width = 210;
            newpnl.Height = 77;
            newpnl.Left = 7;
            newpnl.Top = (pnlParentside.Controls.Count - 1) * 81 + 4;
            newpnl.BackColor = Color.FromArgb(178, 8, 55);
            newpnl.Name = "pnlChildSide_" + pnlParentside.Controls.Count.ToString();

            Label lbTitle = new Label();
            lbTitle.Parent = newpnl;
            lbTitle.Text = "Lorem Ipsum";
            lbTitle.Top = 4;
            lbTitle.ForeColor = Color.White;
            lbTitle.Name = "lbTitle_pnlChildSide_" + pnlParentside.Controls.Count.ToString();

            ws.sendMsg("Please prepare order " + tbOrderno.Text);
            int NextNo = int.Parse(tbOrderno.Text) + 1;
            tbOrderno.Text = NextNo.ToString();
            
        }

        private void BtnAddFood_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAddDrink_Click(object sender, EventArgs e)
        {

        }

        private void tmCashier_Tick(object sender, EventArgs e)
        {
            lbxOrders.Items.Clear();
            foreach (var item in ws.messages)
            {
                lbxOrders.Items.Add(item);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
           // LoginForm login = new LoginForm();
           // login.Show();
        }
        Point lastClick;
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = new Point(e.X, e.Y); //We'll need this for when the Form starts to move
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Only when mouse is clicked
            {
                //Move the Form the same difference the mouse cursor moved;
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

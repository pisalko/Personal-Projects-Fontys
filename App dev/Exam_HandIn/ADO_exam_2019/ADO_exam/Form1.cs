using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_exam
{
    public partial class Form1 : Form
    {

        List<String> names = new List<String>();
        List<double> balance = new List<double>();
        bool showAllCh, refreshNeeded = false;

        public Form1()
        {
            InitializeComponent();
            names.Add("Valio");
            balance.Add(5.00);
            names.Add("Ivan");
            balance.Add(5.00);
            names.Add("Pesho");
            balance.Add(5.00);
            names.Add("Gosho");
            balance.Add(5.00);
            names.Add("Alex");
            balance.Add(5.00);
        }

        private void RefreshAtIndex(int indexAt)
        {
            try
            {
                int indexAtLb = -1;

                for (int i = 0; i < lbPiggyBanks.Items.Count; i++)
                {
                    if (lbPiggyBanks.Items[i].ToString().Contains(tbName.Text))
                    {
                        indexAtLb = i;
                        break;
                    }
                }
                if (indexAtLb != -1)
                {
                    lbPiggyBanks.Items.RemoveAt(indexAtLb);
                    lbPiggyBanks.Items.Add(names[indexAt] + "'s Piggy Bank: " + balance[indexAt].ToString("0.00") + "€");
                }
            }
            catch (Exception errors)
            {
              
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //add code here (assignment 2a)
            if (names.Contains(tbName.Text))
            {
                MessageBox.Show("This person already has a Piggy Bank !");
            }
            else if (tbName.Text != "")
            {
                names.Add(tbName.Text);
                balance.Add(5.00);
                int indexAt = names.IndexOf(tbName.Text);
                lbPiggyBanks.Items.Add(names[indexAt] + "'s Piggy Bank: " + balance[indexAt].ToString("0.00") + "€");
            }
            else
            {
                MessageBox.Show("Please enter a suitable name");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //add code here (assignment 2b)
            int indexAt = names.IndexOf(tbName.Text);
            if (indexAt == -1)
            {
                MessageBox.Show("No such person found.");
            }
            else
            {
                if (balance[indexAt] != 0)
                {
                    MessageBox.Show("This person's balance is not empty !");
                }
                else
                {
                    int indexAtLb = -1;

                    for(int i = 0; i < lbPiggyBanks.Items.Count; i++)
                    {
                        if (lbPiggyBanks.Items[i].ToString().Contains(tbName.Text))
                        {
                            indexAtLb = i;
                            break;
                        }
                    }
                    if (indexAtLb != -1)
                    {
                        lbPiggyBanks.Items.RemoveAt(indexAtLb);
                        names.RemoveAt(indexAt);
                        balance.RemoveAt(indexAt);
                    }
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            //add code here (assignment 3a)
            lbPiggyBanks.Items.Clear();
            for (int i = 0; i < names.Count; i++)
            {
                lbPiggyBanks.Items.Add(names[i] + "'s Piggy Bank: " + balance[i].ToString("0.00") + "€");
            }
            showAllCh = true;
        }

        private void btnShowAtLeast_Click(object sender, EventArgs e)
        {
            try
            {
                lbPiggyBanks.Items.Clear();
                //add code here (assignment 3b)
                for (int i = 0; i < balance.Count; i++)
                {
                    if (balance[i] >= Convert.ToDouble(tbLimit.Text))
                    {
                        lbPiggyBanks.Items.Add(names[i] + "'s Piggy Bank: " + balance[i].ToString("0.00") + "€");
                    }
                }
                showAllCh = false;
            }
            catch (Exception errors)
            {
                MessageBox.Show("Please enter data in textbox Limit");
            }
        }

        private void btnShowTotal_Click(object sender, EventArgs e)
        {
            //add code here (assignment 3c)
            double totalMoney = 0;
            for(int i = 0; i < balance.Count; i++)
            {
                totalMoney += balance[i];
            }
            MessageBox.Show("The total money in all Piggy Banks is: " + totalMoney.ToString("0.00") + "€.");
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                //add code here (assignment 4)
                int amountIn = 0;

                if (tbAmount.Text != "")
                    amountIn = Convert.ToInt32(tbAmount.Text);

                int indexAt = names.IndexOf(tbName.Text);

                if (indexAt == -1)
                {
                    MessageBox.Show("No such person found.");
                }
                else if (rbEuro.Checked)
                {
                    balance[indexAt] += Convert.ToDouble(amountIn);
                    //------------
                    RefreshAtIndex(indexAt);
                    //------------
                }
                else if (rbCents.Checked)
                {
                    balance[indexAt] += Convert.ToDouble(amountIn) / 100;
                    //-------------
                    RefreshAtIndex(indexAt);
                    //-------------
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please input correct data in textbox!");
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            //add code here (assignment 5)

            int indexAtGiver = names.IndexOf(tbName.Text);
            int indexAtReceiver = names.IndexOf(tbTransferToName.Text);
            //Exception handling with if/else because of return value of IndexOf method
            if (indexAtGiver == -1)
            {
                MessageBox.Show("Sender with this name not found in Piggy Bank database.");
            }
            else if (indexAtReceiver == -1)
            {
                MessageBox.Show("Receiver with this name not found in Piggy Bank database.");
            }
            else if (indexAtReceiver == indexAtGiver)
            {
                MessageBox.Show("Why are you trying to transfer to yourself ?");
            }
            else
            {
                balance[indexAtReceiver] += balance[indexAtGiver];
                balance[indexAtGiver] = 0;
                //-----------                               
                indexAtGiver = names.IndexOf(tbName.Text);               
                RefreshAtIndex(indexAtGiver);
                indexAtReceiver = names.IndexOf(tbTransferToName.Text);
                RefreshAtIndex(indexAtReceiver);
                //-----------
                //Better, more stable refresh method
                refreshNeeded = true;

                if (showAllCh)
                {
                    if (refreshNeeded)
                    {
                        lbPiggyBanks.Items.Clear();
                        for (int i = 0; i < names.Count; i++)
                        {
                            lbPiggyBanks.Items.Add(names[i] + "'s Piggy Bank: " + balance[i].ToString("0.00") + "€");
                        }
                        refreshNeeded = false;
                    }
                }
                //-----------
            }

        }        
    }
}

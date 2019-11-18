using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trakteren
{
    public partial class Form1 : Form
    {
        List<double> moneyBalance;
        List<String> names;

        List<String> roundNames;

        public Form1()
        {
            InitializeComponent();
            roundNames = new List<String>();
        }

        public int getNameIndex(string nameToFind)
        {
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].Contains(nameToFind))
                    return i;
            }
            return -1;
        }

        private void drawList()
        {
            lbTeamMembers.Items.Clear();
            lbBalance.Items.Clear();
            for (int i = 0; i < names.Count; i++)
            {
                lbTeamMembers.Items.Add(names[i]);
                lbBalance.Items.Add(names[i].PadRight(13) + moneyBalance[i].ToString("0.00"));
            }

            lbRoundInfo.Items.Clear();
            for (int i =0; i <roundNames.Count; i++)
            {
                lbRoundInfo.Items.Add(roundNames[i]);
            }
        }
        
        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            moneyBalance = new List<double>
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            names = new List<String>
                { "Alicia", "Hina", "Owais", "Samir", "Burhan", "Hattie", "Alfie-Jay", "Blair", "Filip", "Frank" };
            drawList();
        }

          private void DisplayAmount()
        {
            string amountLine;
            for(int i = 0; i< moneyBalance.Count; i++)
            {
                amountLine = "€ " + moneyBalance[i].ToString("0.00");
                lbBalance.Items.Add(amountLine);
            }
            foreach (double quantity in moneyBalance)
            {
                amountLine = "€ " + quantity.ToString("0.00");
                lbBalance.Items.Add(amountLine);
            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (lbTeamMembers.SelectedItem != null)
            {
                string nameToBeRemoved = lbTeamMembers.SelectedItem.ToString();
                int nameIndexToRemove = getNameIndex(nameToBeRemoved);
                names.RemoveAt(nameIndexToRemove);
                moneyBalance.RemoveAt(nameIndexToRemove);
                drawList();
            }
            else
                MessageBox.Show("Please select a member you want to remove");
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            string nameToAdd = tbTeamMember.Text;
            if (nameToAdd.Length == 0)
            {
                MessageBox.Show("Please type in the name first");
            }
            else if (names.Contains(nameToAdd))
            {
                MessageBox.Show("This member is already on the list");
            }
            else 
            {
                names.Add(nameToAdd);
                moneyBalance.Add(0);
                drawList();
            }
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            {
                string nameToRemove = tbTeamMember.Text;
                if (nameToRemove.Length > 0)
                {
                    int nameIndexToRemove = getNameIndex(nameToRemove);
                    names.RemoveAt(nameIndexToRemove);
                    moneyBalance.RemoveAt(nameIndexToRemove);
                    drawList();
                }
                else
                    MessageBox.Show("Please enter a name you want to remove");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            if (lbTeamMembers.SelectedItem != null)
            {
                string nameToCopy = lbTeamMembers.SelectedItem.ToString();
                if (roundNames.Contains(nameToCopy))
                {
                    MessageBox.Show("name is already added");
                }
                else
                {
                    roundNames.Add(nameToCopy);
                }
                drawList();
            }
            else
            {
                MessageBox.Show("nothight is selected");
            }
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            if (lbRoundInfo.SelectedItem != null)
            {
                string nameToRemove = lbRoundInfo.SelectedItem.ToString();
                {
                    roundNames.Remove(nameToRemove);
                }
                drawList();
            }
            else
            {
                MessageBox.Show("nothight is selected");
            }


        }

        private void btnBuyARound_Click(object sender, EventArgs e)
        {
            string buyer = tbRoundBuyer.Text;
            double amount = Convert.ToDouble(tbRoundPrice.Text);
            int numberOfPeople = roundNames.Count;
            double amountPerPerson = amount / numberOfPeople;


            int nameIndex = getNameIndex(buyer);
            moneyBalance[nameIndex] += amount;

            for (int i = 0; i < roundNames.Count; i++)
            {
                int roundDrinkerIndex = getNameIndex(roundNames[i]);
                moneyBalance[roundDrinkerIndex] -= amountPerPerson;
            }

            drawList();
        }

        private void PbTeam_Click(object sender, EventArgs e)
        {

        }
    }
}

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
        public Form1()
        {
            InitializeComponent();
        }
        String[] names = new String[] {"Alicia", "Hina", "Owais", "Samir", "Burhan", "Hattie", "Alfie-Jay", "Blair", "Filip", "Frank" };
        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < names.Length; i++)
            {
                lbTeamMembers.Items.Add(names[i]);
            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            lbTeamMembers.Items.Remove(lbTeamMembers.SelectedItem);
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        
        {
            if (lbTeamMembers.Items.Contains(tbTeamMember.Text))
            {
                MessageBox.Show("This player is already taken note of.");
            }
            else
            {
                if (tbTeamMember.Text == "")
                {
                    MessageBox.Show("Please write down a name first!");
                }
                else
                {
                    lbTeamMembers.Items.Add(tbTeamMember.Text);
                }
            }
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            if (lbTeamMembers.Items.Contains(tbTeamMember.Text))
            {
                lbTeamMembers.Items.Remove(tbTeamMember.Text);
            }
            else
            {
                MessageBox.Show("Can't find the player !");
            }
        }

        private void gbBalanceInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}

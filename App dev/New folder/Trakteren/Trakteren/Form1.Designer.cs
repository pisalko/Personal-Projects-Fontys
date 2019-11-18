namespace Trakteren
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbTeamMembers = new System.Windows.Forms.GroupBox();
            this.tbTeamMember = new System.Windows.Forms.TextBox();
            this.lblTeamMember = new System.Windows.Forms.Label();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.pbTeam = new System.Windows.Forms.PictureBox();
            this.lbTeamMembers = new System.Windows.Forms.ListBox();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.gb_RoundInfo = new System.Windows.Forms.GroupBox();
            this.tbRoundBuyer = new System.Windows.Forms.TextBox();
            this.tbRoundPrice = new System.Windows.Forms.TextBox();
            this.lblRoundBuyer = new System.Windows.Forms.Label();
            this.lblRoundPrice = new System.Windows.Forms.Label();
            this.lbRoundInfo = new System.Windows.Forms.ListBox();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.gbBalanceInfo = new System.Windows.Forms.GroupBox();
            this.pbDrinks = new System.Windows.Forms.PictureBox();
            this.lbBalance = new System.Windows.Forms.ListBox();
            this.btnBuyARound = new System.Windows.Forms.Button();
            this.gbTeamMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeam)).BeginInit();
            this.gb_RoundInfo.SuspendLayout();
            this.gbBalanceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrinks)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTeamMembers
            // 
            this.gbTeamMembers.Controls.Add(this.tbTeamMember);
            this.gbTeamMembers.Controls.Add(this.lblTeamMember);
            this.gbTeamMembers.Controls.Add(this.btnRemoveMember);
            this.gbTeamMembers.Controls.Add(this.btnAddMember);
            this.gbTeamMembers.Controls.Add(this.btnRemoveSelected);
            this.gbTeamMembers.Controls.Add(this.pbTeam);
            this.gbTeamMembers.Controls.Add(this.lbTeamMembers);
            this.gbTeamMembers.Controls.Add(this.btnAddTeam);
            this.gbTeamMembers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbTeamMembers.Location = new System.Drawing.Point(2, 12);
            this.gbTeamMembers.Name = "gbTeamMembers";
            this.gbTeamMembers.Size = new System.Drawing.Size(240, 381);
            this.gbTeamMembers.TabIndex = 0;
            this.gbTeamMembers.TabStop = false;
            this.gbTeamMembers.Text = "Team members";
            // 
            // tbTeamMember
            // 
            this.tbTeamMember.BackColor = System.Drawing.Color.Linen;
            this.tbTeamMember.Location = new System.Drawing.Point(125, 349);
            this.tbTeamMember.Name = "tbTeamMember";
            this.tbTeamMember.Size = new System.Drawing.Size(109, 22);
            this.tbTeamMember.TabIndex = 7;
            // 
            // lblTeamMember
            // 
            this.lblTeamMember.AutoSize = true;
            this.lblTeamMember.Location = new System.Drawing.Point(10, 349);
            this.lblTeamMember.Name = "lblTeamMember";
            this.lblTeamMember.Size = new System.Drawing.Size(99, 17);
            this.lblTeamMember.TabIndex = 6;
            this.lblTeamMember.Text = "Team Member";
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.BackColor = System.Drawing.Color.RosyBrown;
            this.btnRemoveMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMember.Location = new System.Drawing.Point(165, 249);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(69, 83);
            this.btnRemoveMember.TabIndex = 5;
            this.btnRemoveMember.Text = "Remove Team Member";
            this.btnRemoveMember.UseVisualStyleBackColor = false;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.Location = new System.Drawing.Point(90, 249);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(69, 83);
            this.btnAddMember.TabIndex = 4;
            this.btnAddMember.Text = "Add Team Member";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.BackColor = System.Drawing.Color.RosyBrown;
            this.btnRemoveSelected.Location = new System.Drawing.Point(6, 249);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(78, 83);
            this.btnRemoveSelected.TabIndex = 3;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = false;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // pbTeam
            // 
            this.pbTeam.BackgroundImage = global::Trakteren.Properties.Resources.shirt;
            this.pbTeam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTeam.ErrorImage = null;
            this.pbTeam.Location = new System.Drawing.Point(6, 107);
            this.pbTeam.Name = "pbTeam";
            this.pbTeam.Size = new System.Drawing.Size(84, 136);
            this.pbTeam.TabIndex = 2;
            this.pbTeam.TabStop = false;
            this.pbTeam.Click += new System.EventHandler(this.PbTeam_Click);
            // 
            // lbTeamMembers
            // 
            this.lbTeamMembers.BackColor = System.Drawing.Color.Linen;
            this.lbTeamMembers.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbTeamMembers.FormattingEnabled = true;
            this.lbTeamMembers.ItemHeight = 16;
            this.lbTeamMembers.Location = new System.Drawing.Point(96, 31);
            this.lbTeamMembers.Name = "lbTeamMembers";
            this.lbTeamMembers.Size = new System.Drawing.Size(138, 212);
            this.lbTeamMembers.TabIndex = 1;
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAddTeam.Location = new System.Drawing.Point(6, 31);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(84, 70);
            this.btnAddTeam.TabIndex = 0;
            this.btnAddTeam.Text = "Add default team";
            this.btnAddTeam.UseVisualStyleBackColor = false;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // gb_RoundInfo
            // 
            this.gb_RoundInfo.Controls.Add(this.tbRoundBuyer);
            this.gb_RoundInfo.Controls.Add(this.tbRoundPrice);
            this.gb_RoundInfo.Controls.Add(this.lblRoundBuyer);
            this.gb_RoundInfo.Controls.Add(this.lblRoundPrice);
            this.gb_RoundInfo.Controls.Add(this.lbRoundInfo);
            this.gb_RoundInfo.Controls.Add(this.btnMoveLeft);
            this.gb_RoundInfo.Controls.Add(this.btnMoveRight);
            this.gb_RoundInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_RoundInfo.Location = new System.Drawing.Point(248, 12);
            this.gb_RoundInfo.Name = "gb_RoundInfo";
            this.gb_RoundInfo.Size = new System.Drawing.Size(277, 381);
            this.gb_RoundInfo.TabIndex = 1;
            this.gb_RoundInfo.TabStop = false;
            this.gb_RoundInfo.Text = "Round Information";
            // 
            // tbRoundBuyer
            // 
            this.tbRoundBuyer.BackColor = System.Drawing.Color.Linen;
            this.tbRoundBuyer.Location = new System.Drawing.Point(102, 261);
            this.tbRoundBuyer.Name = "tbRoundBuyer";
            this.tbRoundBuyer.Size = new System.Drawing.Size(169, 22);
            this.tbRoundBuyer.TabIndex = 8;
            // 
            // tbRoundPrice
            // 
            this.tbRoundPrice.BackColor = System.Drawing.Color.Linen;
            this.tbRoundPrice.Location = new System.Drawing.Point(102, 313);
            this.tbRoundPrice.Name = "tbRoundPrice";
            this.tbRoundPrice.Size = new System.Drawing.Size(169, 22);
            this.tbRoundPrice.TabIndex = 9;
            // 
            // lblRoundBuyer
            // 
            this.lblRoundBuyer.AutoSize = true;
            this.lblRoundBuyer.Location = new System.Drawing.Point(6, 264);
            this.lblRoundBuyer.Name = "lblRoundBuyer";
            this.lblRoundBuyer.Size = new System.Drawing.Size(91, 17);
            this.lblRoundBuyer.TabIndex = 8;
            this.lblRoundBuyer.Text = "Round Buyer";
            // 
            // lblRoundPrice
            // 
            this.lblRoundPrice.AutoSize = true;
            this.lblRoundPrice.Location = new System.Drawing.Point(6, 313);
            this.lblRoundPrice.Name = "lblRoundPrice";
            this.lblRoundPrice.Size = new System.Drawing.Size(86, 17);
            this.lblRoundPrice.TabIndex = 9;
            this.lblRoundPrice.Text = "Round Price";
            // 
            // lbRoundInfo
            // 
            this.lbRoundInfo.BackColor = System.Drawing.Color.Linen;
            this.lbRoundInfo.FormattingEnabled = true;
            this.lbRoundInfo.ItemHeight = 16;
            this.lbRoundInfo.Location = new System.Drawing.Point(102, 31);
            this.lbRoundInfo.Name = "lbRoundInfo";
            this.lbRoundInfo.Size = new System.Drawing.Size(169, 212);
            this.lbRoundInfo.TabIndex = 8;
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.BackColor = System.Drawing.Color.RosyBrown;
            this.btnMoveLeft.Location = new System.Drawing.Point(6, 107);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(90, 59);
            this.btnMoveLeft.TabIndex = 7;
            this.btnMoveLeft.Text = "<<";
            this.btnMoveLeft.UseVisualStyleBackColor = false;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.BackColor = System.Drawing.Color.RosyBrown;
            this.btnMoveRight.Location = new System.Drawing.Point(6, 31);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(90, 59);
            this.btnMoveRight.TabIndex = 8;
            this.btnMoveRight.Text = ">>";
            this.btnMoveRight.UseVisualStyleBackColor = false;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // gbBalanceInfo
            // 
            this.gbBalanceInfo.Controls.Add(this.pbDrinks);
            this.gbBalanceInfo.Controls.Add(this.lbBalance);
            this.gbBalanceInfo.Controls.Add(this.btnBuyARound);
            this.gbBalanceInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbBalanceInfo.Location = new System.Drawing.Point(531, 12);
            this.gbBalanceInfo.Name = "gbBalanceInfo";
            this.gbBalanceInfo.Size = new System.Drawing.Size(273, 380);
            this.gbBalanceInfo.TabIndex = 1;
            this.gbBalanceInfo.TabStop = false;
            this.gbBalanceInfo.Text = "Balance Information";
            // 
            // pbDrinks
            // 
            this.pbDrinks.BackgroundImage = global::Trakteren.Properties.Resources.barrelbeers;
            this.pbDrinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDrinks.ErrorImage = null;
            this.pbDrinks.InitialImage = null;
            this.pbDrinks.Location = new System.Drawing.Point(12, 233);
            this.pbDrinks.Name = "pbDrinks";
            this.pbDrinks.Size = new System.Drawing.Size(245, 141);
            this.pbDrinks.TabIndex = 8;
            this.pbDrinks.TabStop = false;
            // 
            // lbBalance
            // 
            this.lbBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBalance.BackColor = System.Drawing.Color.Linen;
            this.lbBalance.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.FormattingEnabled = true;
            this.lbBalance.Location = new System.Drawing.Point(102, 31);
            this.lbBalance.MaximumSize = new System.Drawing.Size(165, 180);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(165, 173);
            this.lbBalance.TabIndex = 9;
            // 
            // btnBuyARound
            // 
            this.btnBuyARound.BackColor = System.Drawing.Color.RosyBrown;
            this.btnBuyARound.Location = new System.Drawing.Point(6, 96);
            this.btnBuyARound.Name = "btnBuyARound";
            this.btnBuyARound.Size = new System.Drawing.Size(90, 59);
            this.btnBuyARound.TabIndex = 6;
            this.btnBuyARound.Text = "Buy a Round !";
            this.btnBuyARound.UseVisualStyleBackColor = false;
            this.btnBuyARound.Click += new System.EventHandler(this.btnBuyARound_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_RoundInfo);
            this.Controls.Add(this.gbBalanceInfo);
            this.Controls.Add(this.gbTeamMembers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTeamMembers.ResumeLayout(false);
            this.gbTeamMembers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeam)).EndInit();
            this.gb_RoundInfo.ResumeLayout(false);
            this.gb_RoundInfo.PerformLayout();
            this.gbBalanceInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrinks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTeamMembers;
        private System.Windows.Forms.GroupBox gb_RoundInfo;
        private System.Windows.Forms.GroupBox gbBalanceInfo;
        private System.Windows.Forms.TextBox tbTeamMember;
        private System.Windows.Forms.Label lblTeamMember;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.PictureBox pbTeam;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.TextBox tbRoundBuyer;
        private System.Windows.Forms.TextBox tbRoundPrice;
        private System.Windows.Forms.Label lblRoundBuyer;
        private System.Windows.Forms.Label lblRoundPrice;
        private System.Windows.Forms.ListBox lbRoundInfo;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.PictureBox pbDrinks;
        private System.Windows.Forms.Button btnBuyARound;
        private System.Windows.Forms.ListBox lbTeamMembers;
        private System.Windows.Forms.ListBox lbBalance;
    }
}


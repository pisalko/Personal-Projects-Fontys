namespace ADO_exam
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLimit = new System.Windows.Forms.TextBox();
            this.btnShowTotal = new System.Windows.Forms.Button();
            this.btnShowAtLeast = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbCents = new System.Windows.Forms.RadioButton();
            this.rbEuro = new System.Windows.Forms.RadioButton();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTransferToName = new System.Windows.Forms.TextBox();
            this.lbPiggyBanks = new System.Windows.Forms.ListBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Remove";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(11, 75);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbLimit);
            this.groupBox2.Controls.Add(this.btnShowTotal);
            this.groupBox2.Controls.Add(this.btnShowAtLeast);
            this.groupBox2.Controls.Add(this.btnShowAll);
            this.groupBox2.Location = new System.Drawing.Point(118, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Limit";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tbLimit
            // 
            this.tbLimit.Location = new System.Drawing.Point(39, 48);
            this.tbLimit.Name = "tbLimit";
            this.tbLimit.Size = new System.Drawing.Size(55, 20);
            this.tbLimit.TabIndex = 3;
            // 
            // btnShowTotal
            // 
            this.btnShowTotal.Location = new System.Drawing.Point(100, 77);
            this.btnShowTotal.Name = "btnShowTotal";
            this.btnShowTotal.Size = new System.Drawing.Size(95, 23);
            this.btnShowTotal.TabIndex = 2;
            this.btnShowTotal.Text = "Show Total";
            this.btnShowTotal.UseVisualStyleBackColor = true;
            this.btnShowTotal.Click += new System.EventHandler(this.btnShowTotal_Click);
            // 
            // btnShowAtLeast
            // 
            this.btnShowAtLeast.Location = new System.Drawing.Point(100, 48);
            this.btnShowAtLeast.Name = "btnShowAtLeast";
            this.btnShowAtLeast.Size = new System.Drawing.Size(95, 23);
            this.btnShowAtLeast.TabIndex = 1;
            this.btnShowAtLeast.Text = "Show At Least";
            this.btnShowAtLeast.UseVisualStyleBackColor = true;
            this.btnShowAtLeast.Click += new System.EventHandler(this.btnShowAtLeast_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(100, 19);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(95, 23);
            this.btnShowAll.TabIndex = 0;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbCents);
            this.groupBox3.Controls.Add(this.rbEuro);
            this.groupBox3.Controls.Add(this.btnDeposit);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbAmount);
            this.groupBox3.Location = new System.Drawing.Point(325, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 117);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deposit";
            // 
            // rbCents
            // 
            this.rbCents.AutoSize = true;
            this.rbCents.Location = new System.Drawing.Point(107, 48);
            this.rbCents.Name = "rbCents";
            this.rbCents.Size = new System.Drawing.Size(51, 17);
            this.rbCents.TabIndex = 8;
            this.rbCents.Text = "cents";
            this.rbCents.UseVisualStyleBackColor = true;
            // 
            // rbEuro
            // 
            this.rbEuro.AutoSize = true;
            this.rbEuro.Checked = true;
            this.rbEuro.Location = new System.Drawing.Point(55, 48);
            this.rbEuro.Name = "rbEuro";
            this.rbEuro.Size = new System.Drawing.Size(46, 17);
            this.rbEuro.TabIndex = 7;
            this.rbEuro.TabStop = true;
            this.rbEuro.Text = "euro";
            this.rbEuro.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(31, 77);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(95, 23);
            this.btnDeposit.TabIndex = 4;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(55, 22);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(100, 20);
            this.tbAmount.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnTransfer);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.tbTransferToName);
            this.groupBox4.Location = new System.Drawing.Point(499, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(164, 117);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transfer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(35, 77);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(95, 23);
            this.btnTransfer.TabIndex = 8;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "To";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tbTransferToName
            // 
            this.tbTransferToName.Location = new System.Drawing.Point(47, 24);
            this.tbTransferToName.Name = "tbTransferToName";
            this.tbTransferToName.Size = new System.Drawing.Size(100, 20);
            this.tbTransferToName.TabIndex = 7;
            // 
            // lbPiggyBanks
            // 
            this.lbPiggyBanks.FormattingEnabled = true;
            this.lbPiggyBanks.Location = new System.Drawing.Point(157, 9);
            this.lbPiggyBanks.Name = "lbPiggyBanks";
            this.lbPiggyBanks.Size = new System.Drawing.Size(506, 134);
            this.lbPiggyBanks.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(53, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(98, 20);
            this.tbName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(674, 278);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbPiggyBanks);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbPiggyBanks;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbLimit;
        private System.Windows.Forms.Button btnShowTotal;
        private System.Windows.Forms.Button btnShowAtLeast;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTransferToName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbCents;
        private System.Windows.Forms.RadioButton rbEuro;
    }
}


namespace IPProject
{
    partial class ChefForm
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
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbLogo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lbxChef = new System.Windows.Forms.ListBox();
            this.spArduino = new System.IO.Ports.SerialPort(this.components);
            this.tmChef = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(807, 10);
            this.pnlTop.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(36, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.lbLogo);
            this.panel2.Location = new System.Drawing.Point(43, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 70);
            this.panel2.TabIndex = 3;
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogo.ForeColor = System.Drawing.Color.White;
            this.lbLogo.Location = new System.Drawing.Point(54, 9);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(100, 16);
            this.lbLogo.TabIndex = 3;
            this.lbLogo.Text = "The Pizza BOIZ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddItem);
            this.panel3.Controls.Add(this.lbxChef);
            this.panel3.Location = new System.Drawing.Point(0, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 334);
            this.panel3.TabIndex = 4;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(580, 277);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lbxChef
            // 
            this.lbxChef.FormattingEnabled = true;
            this.lbxChef.Location = new System.Drawing.Point(12, 6);
            this.lbxChef.Name = "lbxChef";
            this.lbxChef.Size = new System.Drawing.Size(542, 303);
            this.lbxChef.TabIndex = 0;
            // 
            // spArduino
            // 
            this.spArduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.spArduino_DataReceived);
            // 
            // tmChef
            // 
            this.tmChef.Interval = 1000;
            this.tmChef.Tick += new System.EventHandler(this.tmChef_Tick);
            // 
            // ChefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 481);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChefForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChefForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChefForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChefForm_MouseMove);
            this.pnlTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Panel panel3;
        private System.IO.Ports.SerialPort spArduino;
        private System.Windows.Forms.ListBox lbxChef;
        private System.Windows.Forms.Timer tmChef;
        private System.Windows.Forms.Button btnAddItem;
    }
}
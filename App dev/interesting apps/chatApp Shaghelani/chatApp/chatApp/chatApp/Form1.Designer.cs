namespace chatApp
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxLocalIP = new System.Windows.Forms.TextBox();
            this.textBoxLocalPort = new System.Windows.Forms.TextBox();
            this.textBoxRemotIP = new System.Windows.Forms.TextBox();
            this.textBoxRemotePort = new System.Windows.Forms.TextBox();
            this.LabelIP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.listBoxMessage = new System.Windows.Forms.ListBox();
            this.buttonMessage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LabelIP);
            this.groupBox1.Controls.Add(this.textBoxLocalPort);
            this.groupBox1.Controls.Add(this.textBoxLocalIP);
            this.groupBox1.Location = new System.Drawing.Point(26, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Me";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxRemotePort);
            this.groupBox2.Controls.Add(this.textBoxRemotIP);
            this.groupBox2.Location = new System.Drawing.Point(646, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 272);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Friend";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(1277, 100);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(235, 131);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxLocalIP
            // 
            this.textBoxLocalIP.Location = new System.Drawing.Point(210, 83);
            this.textBoxLocalIP.Name = "textBoxLocalIP";
            this.textBoxLocalIP.Size = new System.Drawing.Size(190, 35);
            this.textBoxLocalIP.TabIndex = 0;
            // 
            // textBoxLocalPort
            // 
            this.textBoxLocalPort.Location = new System.Drawing.Point(210, 157);
            this.textBoxLocalPort.Name = "textBoxLocalPort";
            this.textBoxLocalPort.Size = new System.Drawing.Size(190, 35);
            this.textBoxLocalPort.TabIndex = 1;
            // 
            // textBoxRemotIP
            // 
            this.textBoxRemotIP.Location = new System.Drawing.Point(291, 83);
            this.textBoxRemotIP.Name = "textBoxRemotIP";
            this.textBoxRemotIP.Size = new System.Drawing.Size(190, 35);
            this.textBoxRemotIP.TabIndex = 2;
            // 
            // textBoxRemotePort
            // 
            this.textBoxRemotePort.Location = new System.Drawing.Point(291, 157);
            this.textBoxRemotePort.Name = "textBoxRemotePort";
            this.textBoxRemotePort.Size = new System.Drawing.Size(190, 35);
            this.textBoxRemotePort.TabIndex = 3;
            // 
            // LabelIP
            // 
            this.LabelIP.AutoSize = true;
            this.LabelIP.Location = new System.Drawing.Point(63, 86);
            this.LabelIP.Name = "LabelIP";
            this.LabelIP.Size = new System.Drawing.Size(35, 29);
            this.LabelIP.TabIndex = 4;
            this.LabelIP.Text = "IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "IP";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(26, 820);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(1101, 35);
            this.textBoxMessage.TabIndex = 6;
            // 
            // listBoxMessage
            // 
            this.listBoxMessage.FormattingEnabled = true;
            this.listBoxMessage.ItemHeight = 29;
            this.listBoxMessage.Location = new System.Drawing.Point(26, 320);
            this.listBoxMessage.Name = "listBoxMessage";
            this.listBoxMessage.Size = new System.Drawing.Size(1196, 468);
            this.listBoxMessage.TabIndex = 7;
            // 
            // buttonMessage
            // 
            this.buttonMessage.Location = new System.Drawing.Point(1147, 807);
            this.buttonMessage.Name = "buttonMessage";
            this.buttonMessage.Size = new System.Drawing.Size(191, 61);
            this.buttonMessage.TabIndex = 8;
            this.buttonMessage.Text = "send";
            this.buttonMessage.UseVisualStyleBackColor = true;
            this.buttonMessage.Click += new System.EventHandler(this.buttonMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 952);
            this.Controls.Add(this.buttonMessage);
            this.Controls.Add(this.listBoxMessage);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelIP;
        private System.Windows.Forms.TextBox textBoxLocalPort;
        private System.Windows.Forms.TextBox textBoxLocalIP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRemotePort;
        private System.Windows.Forms.TextBox textBoxRemotIP;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.ListBox listBoxMessage;
        private System.Windows.Forms.Button buttonMessage;
    }
}


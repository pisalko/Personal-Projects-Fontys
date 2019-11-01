namespace Tesla_autopilot
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
            this.buttonAccelerate = new System.Windows.Forms.Button();
            this.buttonBrake = new System.Windows.Forms.Button();
            this.buttonAutoPilot = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAccelerate
            // 
            this.buttonAccelerate.Location = new System.Drawing.Point(241, 320);
            this.buttonAccelerate.Name = "buttonAccelerate";
            this.buttonAccelerate.Size = new System.Drawing.Size(75, 23);
            this.buttonAccelerate.TabIndex = 0;
            this.buttonAccelerate.Text = "button1";
            this.buttonAccelerate.UseVisualStyleBackColor = true;
            // 
            // buttonBrake
            // 
            this.buttonBrake.Location = new System.Drawing.Point(465, 320);
            this.buttonBrake.Name = "buttonBrake";
            this.buttonBrake.Size = new System.Drawing.Size(75, 23);
            this.buttonBrake.TabIndex = 1;
            this.buttonBrake.Text = "button2";
            this.buttonBrake.UseVisualStyleBackColor = true;
            // 
            // buttonAutoPilot
            // 
            this.buttonAutoPilot.Location = new System.Drawing.Point(358, 404);
            this.buttonAutoPilot.Name = "buttonAutoPilot";
            this.buttonAutoPilot.Size = new System.Drawing.Size(75, 23);
            this.buttonAutoPilot.TabIndex = 2;
            this.buttonAutoPilot.Text = "button3";
            this.buttonAutoPilot.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(231, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 178);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAutoPilot);
            this.Controls.Add(this.buttonBrake);
            this.Controls.Add(this.buttonAccelerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAccelerate;
        private System.Windows.Forms.Button buttonBrake;
        private System.Windows.Forms.Button buttonAutoPilot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}


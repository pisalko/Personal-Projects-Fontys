namespace SimpleCalc
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
            this.first = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.po = new System.Windows.Forms.Button();
            this.deleno = new System.Windows.Forms.Button();
            this.second = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.equal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(149, 109);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(119, 22);
            this.first.TabIndex = 0;
            this.first.TextChanged += new System.EventHandler(this.First_TextChanged);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(149, 137);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(23, 23);
            this.plus.TabIndex = 1;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Button1_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(178, 137);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(25, 23);
            this.minus.TabIndex = 2;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // po
            // 
            this.po.Location = new System.Drawing.Point(209, 137);
            this.po.Name = "po";
            this.po.Size = new System.Drawing.Size(28, 23);
            this.po.TabIndex = 3;
            this.po.Text = "X";
            this.po.UseVisualStyleBackColor = true;
            this.po.Click += new System.EventHandler(this.Button3_Click);
            // 
            // deleno
            // 
            this.deleno.Location = new System.Drawing.Point(243, 137);
            this.deleno.Name = "deleno";
            this.deleno.Size = new System.Drawing.Size(25, 23);
            this.deleno.TabIndex = 4;
            this.deleno.Text = "/";
            this.deleno.UseVisualStyleBackColor = true;
            this.deleno.Click += new System.EventHandler(this.Deleno_Click);
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(149, 166);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(119, 22);
            this.second.TabIndex = 5;
            this.second.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "=";
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(149, 211);
            this.equal.Name = "equal";
            this.equal.ReadOnly = true;
            this.equal.Size = new System.Drawing.Size(119, 22);
            this.equal.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 383);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.second);
            this.Controls.Add(this.deleno);
            this.Controls.Add(this.po);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.first);
            this.Name = "Form1";
            this.Text = "Simple calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button po;
        private System.Windows.Forms.Button deleno;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox equal;
    }
}


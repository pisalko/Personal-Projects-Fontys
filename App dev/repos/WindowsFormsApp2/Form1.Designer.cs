namespace WindowsFormsApp2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.po = new System.Windows.Forms.Button();
            this.deleno = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.equal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(506, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 426);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.equal);
            this.panel2.Controls.Add(this.second);
            this.panel2.Controls.Add(this.first);
            this.panel2.Controls.Add(this.deleno);
            this.panel2.Controls.Add(this.po);
            this.panel2.Controls.Add(this.minus);
            this.panel2.Controls.Add(this.plus);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 426);
            this.panel2.TabIndex = 1;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(89, 220);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(37, 23);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(153, 220);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(39, 23);
            this.minus.TabIndex = 1;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // po
            // 
            this.po.Location = new System.Drawing.Point(224, 220);
            this.po.Name = "po";
            this.po.Size = new System.Drawing.Size(37, 23);
            this.po.TabIndex = 2;
            this.po.Text = "*";
            this.po.UseVisualStyleBackColor = true;
            this.po.Click += new System.EventHandler(this.Button3_Click);
            // 
            // deleno
            // 
            this.deleno.Location = new System.Drawing.Point(285, 220);
            this.deleno.Name = "deleno";
            this.deleno.Size = new System.Drawing.Size(38, 23);
            this.deleno.TabIndex = 3;
            this.deleno.Text = "/";
            this.deleno.UseVisualStyleBackColor = true;
            this.deleno.Click += new System.EventHandler(this.Deleno_Click);
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(153, 69);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(100, 22);
            this.first.TabIndex = 4;
            this.first.TextChanged += new System.EventHandler(this.First_TextChanged);
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(153, 140);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(100, 22);
            this.second.TabIndex = 5;
            this.second.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(178, 317);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(0, 25);
            this.equal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Second Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 105);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 105);
            this.button2.TabIndex = 1;
            this.button2.Text = "Hide Info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(14, 193);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(253, 218);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "My First Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.Button deleno;
        private System.Windows.Forms.Button po;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}


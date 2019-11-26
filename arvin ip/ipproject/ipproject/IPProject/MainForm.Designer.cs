namespace IPProject
{
    partial class MainForm
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
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.pnlParentside = new System.Windows.Forms.Panel();
            this.lbxOrders = new System.Windows.Forms.ListBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbLogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOrderno = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRegisterOrder = new System.Windows.Forms.Button();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMargherita = new System.Windows.Forms.Button();
            this.btnMarinara = new System.Windows.Forms.Button();
            this.btnRomana = new System.Windows.Forms.Button();
            this.btnSiciliana = new System.Windows.Forms.Button();
            this.btnCola = new System.Windows.Forms.Button();
            this.btnFanta = new System.Windows.Forms.Button();
            this.btnSprite = new System.Windows.Forms.Button();
            this.btnColaZero = new System.Windows.Forms.Button();
            this.tmCashier = new System.Windows.Forms.Timer(this.components);
            this.pnlOrders.SuspendLayout();
            this.pnlParentside.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrders
            // 
            this.pnlOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnlOrders.Controls.Add(this.pnlParentside);
            this.pnlOrders.Controls.Add(this.btnAbout);
            this.pnlOrders.Controls.Add(this.btnExit);
            this.pnlOrders.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOrders.Location = new System.Drawing.Point(808, 0);
            this.pnlOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(363, 673);
            this.pnlOrders.TabIndex = 0;
            // 
            // pnlParentside
            // 
            this.pnlParentside.AutoScroll = true;
            this.pnlParentside.Controls.Add(this.lbxOrders);
            this.pnlParentside.Location = new System.Drawing.Point(4, 0);
            this.pnlParentside.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlParentside.Name = "pnlParentside";
            this.pnlParentside.Size = new System.Drawing.Size(343, 598);
            this.pnlParentside.TabIndex = 6;
            // 
            // lbxOrders
            // 
            this.lbxOrders.FormattingEnabled = true;
            this.lbxOrders.ItemHeight = 16;
            this.lbxOrders.Location = new System.Drawing.Point(4, 7);
            this.lbxOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxOrders.Name = "lbxOrders";
            this.lbxOrders.Size = new System.Drawing.Size(316, 516);
            this.lbxOrders.TabIndex = 0;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(197, 625);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(71, 33);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(276, 625);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(808, 12);
            this.pnlTop.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(48, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 123);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.lbLogo);
            this.panel2.Location = new System.Drawing.Point(40, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 86);
            this.panel2.TabIndex = 2;
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogo.ForeColor = System.Drawing.Color.White;
            this.lbLogo.Location = new System.Drawing.Point(72, 11);
            this.lbLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(126, 19);
            this.lbLogo.TabIndex = 3;
            this.lbLogo.Text = "The Pizza BOIZ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order Details";
            // 
            // tbOrderno
            // 
            this.tbOrderno.BackColor = System.Drawing.Color.White;
            this.tbOrderno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOrderno.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrderno.Location = new System.Drawing.Point(140, 124);
            this.tbOrderno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOrderno.Name = "tbOrderno";
            this.tbOrderno.ReadOnly = true;
            this.tbOrderno.Size = new System.Drawing.Size(133, 29);
            this.tbOrderno.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(140, 165);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(644, 112);
            this.textBox1.TabIndex = 4;
            // 
            // btnRegisterOrder
            // 
            this.btnRegisterOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnRegisterOrder.FlatAppearance.BorderSize = 0;
            this.btnRegisterOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterOrder.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterOrder.ForeColor = System.Drawing.Color.White;
            this.btnRegisterOrder.Location = new System.Drawing.Point(684, 297);
            this.btnRegisterOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegisterOrder.Name = "btnRegisterOrder";
            this.btnRegisterOrder.Size = new System.Drawing.Size(100, 42);
            this.btnRegisterOrder.TabIndex = 5;
            this.btnRegisterOrder.Text = "Register";
            this.btnRegisterOrder.UseVisualStyleBackColor = false;
            this.btnRegisterOrder.Click += new System.EventHandler(this.BtnRegisterOrder_Click);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnClearOrder.FlatAppearance.BorderSize = 0;
            this.btnClearOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearOrder.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOrder.ForeColor = System.Drawing.Color.White;
            this.btnClearOrder.Location = new System.Drawing.Point(576, 297);
            this.btnClearOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(100, 42);
            this.btnClearOrder.TabIndex = 5;
            this.btnClearOrder.Text = "Clear";
            this.btnClearOrder.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 406);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Food";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 528);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Drink";
            // 
            // btnMargherita
            // 
            this.btnMargherita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnMargherita.FlatAppearance.BorderSize = 0;
            this.btnMargherita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMargherita.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMargherita.ForeColor = System.Drawing.Color.White;
            this.btnMargherita.Location = new System.Drawing.Point(96, 369);
            this.btnMargherita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMargherita.Name = "btnMargherita";
            this.btnMargherita.Size = new System.Drawing.Size(119, 101);
            this.btnMargherita.TabIndex = 5;
            this.btnMargherita.Text = "Margherita";
            this.btnMargherita.UseVisualStyleBackColor = false;
            this.btnMargherita.Click += new System.EventHandler(this.BtnAddFood_Click);
            // 
            // btnMarinara
            // 
            this.btnMarinara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnMarinara.FlatAppearance.BorderSize = 0;
            this.btnMarinara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarinara.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnMarinara.ForeColor = System.Drawing.Color.White;
            this.btnMarinara.Location = new System.Drawing.Point(223, 369);
            this.btnMarinara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMarinara.Name = "btnMarinara";
            this.btnMarinara.Size = new System.Drawing.Size(119, 101);
            this.btnMarinara.TabIndex = 5;
            this.btnMarinara.Text = "Marinara";
            this.btnMarinara.UseVisualStyleBackColor = false;
            this.btnMarinara.Click += new System.EventHandler(this.BtnAddFood_Click);
            // 
            // btnRomana
            // 
            this.btnRomana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnRomana.FlatAppearance.BorderSize = 0;
            this.btnRomana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRomana.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnRomana.ForeColor = System.Drawing.Color.White;
            this.btnRomana.Location = new System.Drawing.Point(349, 369);
            this.btnRomana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRomana.Name = "btnRomana";
            this.btnRomana.Size = new System.Drawing.Size(119, 101);
            this.btnRomana.TabIndex = 5;
            this.btnRomana.Text = "Romana";
            this.btnRomana.UseVisualStyleBackColor = false;
            this.btnRomana.Click += new System.EventHandler(this.BtnAddFood_Click);
            // 
            // btnSiciliana
            // 
            this.btnSiciliana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnSiciliana.FlatAppearance.BorderSize = 0;
            this.btnSiciliana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiciliana.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnSiciliana.ForeColor = System.Drawing.Color.White;
            this.btnSiciliana.Location = new System.Drawing.Point(476, 369);
            this.btnSiciliana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiciliana.Name = "btnSiciliana";
            this.btnSiciliana.Size = new System.Drawing.Size(119, 101);
            this.btnSiciliana.TabIndex = 5;
            this.btnSiciliana.Text = "Siciliana";
            this.btnSiciliana.UseVisualStyleBackColor = false;
            this.btnSiciliana.Click += new System.EventHandler(this.BtnAddFood_Click);
            // 
            // btnCola
            // 
            this.btnCola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnCola.FlatAppearance.BorderSize = 0;
            this.btnCola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCola.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCola.ForeColor = System.Drawing.Color.White;
            this.btnCola.Location = new System.Drawing.Point(96, 495);
            this.btnCola.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCola.Name = "btnCola";
            this.btnCola.Size = new System.Drawing.Size(119, 95);
            this.btnCola.TabIndex = 5;
            this.btnCola.Text = "Cola";
            this.btnCola.UseVisualStyleBackColor = false;
            // 
            // btnFanta
            // 
            this.btnFanta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnFanta.FlatAppearance.BorderSize = 0;
            this.btnFanta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFanta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnFanta.ForeColor = System.Drawing.Color.White;
            this.btnFanta.Location = new System.Drawing.Point(223, 495);
            this.btnFanta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFanta.Name = "btnFanta";
            this.btnFanta.Size = new System.Drawing.Size(119, 95);
            this.btnFanta.TabIndex = 5;
            this.btnFanta.Text = "Fanta";
            this.btnFanta.UseVisualStyleBackColor = false;
            // 
            // btnSprite
            // 
            this.btnSprite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnSprite.FlatAppearance.BorderSize = 0;
            this.btnSprite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSprite.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSprite.ForeColor = System.Drawing.Color.White;
            this.btnSprite.Location = new System.Drawing.Point(349, 495);
            this.btnSprite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSprite.Name = "btnSprite";
            this.btnSprite.Size = new System.Drawing.Size(119, 95);
            this.btnSprite.TabIndex = 5;
            this.btnSprite.Text = "Sprite";
            this.btnSprite.UseVisualStyleBackColor = false;
            // 
            // btnColaZero
            // 
            this.btnColaZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnColaZero.FlatAppearance.BorderSize = 0;
            this.btnColaZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColaZero.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnColaZero.ForeColor = System.Drawing.Color.White;
            this.btnColaZero.Location = new System.Drawing.Point(476, 495);
            this.btnColaZero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnColaZero.Name = "btnColaZero";
            this.btnColaZero.Size = new System.Drawing.Size(119, 95);
            this.btnColaZero.TabIndex = 5;
            this.btnColaZero.Text = "Cola Zero";
            this.btnColaZero.UseVisualStyleBackColor = false;
            this.btnColaZero.Click += new System.EventHandler(this.BtnAddDrink_Click);
            // 
            // tmCashier
            // 
            this.tmCashier.Interval = 1000;
            this.tmCashier.Tick += new System.EventHandler(this.tmCashier_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 673);
            this.Controls.Add(this.btnClearOrder);
            this.Controls.Add(this.btnColaZero);
            this.Controls.Add(this.btnSiciliana);
            this.Controls.Add(this.btnSprite);
            this.Controls.Add(this.btnRomana);
            this.Controls.Add(this.btnFanta);
            this.Controls.Add(this.btnMarinara);
            this.Controls.Add(this.btnCola);
            this.Controls.Add(this.btnMargherita);
            this.Controls.Add(this.btnRegisterOrder);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbOrderno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.pnlOrders.ResumeLayout(false);
            this.pnlParentside.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOrderno;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRegisterOrder;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMargherita;
        private System.Windows.Forms.Button btnMarinara;
        private System.Windows.Forms.Button btnRomana;
        private System.Windows.Forms.Button btnSiciliana;
        private System.Windows.Forms.Button btnCola;
        private System.Windows.Forms.Button btnFanta;
        private System.Windows.Forms.Button btnSprite;
        private System.Windows.Forms.Button btnColaZero;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlParentside;
        private System.Windows.Forms.Timer tmCashier;
        private System.Windows.Forms.ListBox lbxOrders;
    }
}


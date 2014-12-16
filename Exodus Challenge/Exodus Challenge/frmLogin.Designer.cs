namespace Exodus_Challenge
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.logUsername = new System.Windows.Forms.TextBox();
            this.logPassword = new System.Windows.Forms.TextBox();
            this.logAvatar = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.bypass = new System.Windows.Forms.Button();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.btnRegister = new System.Windows.Forms.Button();
            this.regDOB = new System.Windows.Forms.DateTimePicker();
            this.regAvatar = new System.Windows.Forms.PictureBox();
            this.regDBGAvatar = new System.Windows.Forms.NumericUpDown();
            this.regUsername = new System.Windows.Forms.TextBox();
            this.regEmail = new System.Windows.Forms.TextBox();
            this.regPassword = new System.Windows.Forms.TextBox();
            this.regConfirm = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logAvatar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDBGAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogin.Location = new System.Drawing.Point(3, 410);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(349, 36);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // logUsername
            // 
            this.logUsername.ForeColor = System.Drawing.Color.Silver;
            this.logUsername.Location = new System.Drawing.Point(59, 199);
            this.logUsername.Name = "logUsername";
            this.logUsername.Size = new System.Drawing.Size(236, 26);
            this.logUsername.TabIndex = 0;
            this.logUsername.Text = "Username";
            this.logUsername.TextChanged += new System.EventHandler(this.logUsername_TextChanged);
            this.logUsername.Enter += new System.EventHandler(this.logUsername_Enter);
            // 
            // logPassword
            // 
            this.logPassword.ForeColor = System.Drawing.Color.Silver;
            this.logPassword.Location = new System.Drawing.Point(59, 235);
            this.logPassword.Name = "logPassword";
            this.logPassword.Size = new System.Drawing.Size(236, 26);
            this.logPassword.TabIndex = 1;
            this.logPassword.Text = "Password";
            this.logPassword.TextChanged += new System.EventHandler(this.logPassword_TextChanged);
            this.logPassword.Enter += new System.EventHandler(this.logPassword_Enter);
            // 
            // logAvatar
            // 
            this.logAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logAvatar.BackColor = System.Drawing.Color.Transparent;
            this.logAvatar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("logAvatar.ErrorImage")));
            this.logAvatar.Image = ((System.Drawing.Image)(resources.GetObject("logAvatar.Image")));
            this.logAvatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("logAvatar.InitialImage")));
            this.logAvatar.Location = new System.Drawing.Point(6, 46);
            this.logAvatar.Name = "logAvatar";
            this.logAvatar.Size = new System.Drawing.Size(341, 125);
            this.logAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logAvatar.TabIndex = 4;
            this.logAvatar.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabRegister);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(363, 479);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.BackgroundImage = global::Exodus_Challenge.Properties.Resources.sandstoneBrick;
            this.tabLogin.Controls.Add(this.bypass);
            this.tabLogin.Controls.Add(this.logAvatar);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.logPassword);
            this.tabLogin.Controls.Add(this.logUsername);
            this.tabLogin.Location = new System.Drawing.Point(4, 26);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(355, 449);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // bypass
            // 
            this.bypass.BackColor = System.Drawing.Color.Red;
            this.bypass.Location = new System.Drawing.Point(8, 17);
            this.bypass.Name = "bypass";
            this.bypass.Size = new System.Drawing.Size(22, 23);
            this.bypass.TabIndex = 1;
            this.bypass.UseVisualStyleBackColor = false;
            this.bypass.Click += new System.EventHandler(this.bypass_Click);
            // 
            // tabRegister
            // 
            this.tabRegister.BackgroundImage = global::Exodus_Challenge.Properties.Resources.sandstoneBrickSmall;
            this.tabRegister.Controls.Add(this.panel1);
            this.tabRegister.Controls.Add(this.btnRegister);
            this.tabRegister.Controls.Add(this.regDOB);
            this.tabRegister.Controls.Add(this.regAvatar);
            this.tabRegister.Controls.Add(this.regDBGAvatar);
            this.tabRegister.Controls.Add(this.regUsername);
            this.tabRegister.Controls.Add(this.regEmail);
            this.tabRegister.Controls.Add(this.regPassword);
            this.tabRegister.Controls.Add(this.regConfirm);
            this.tabRegister.Location = new System.Drawing.Point(4, 26);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(355, 449);
            this.tabRegister.TabIndex = 1;
            this.tabRegister.Text = "Register";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRegister.Location = new System.Drawing.Point(3, 410);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(349, 36);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // regDOB
            // 
            this.regDOB.CalendarForeColor = System.Drawing.Color.Black;
            this.regDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.regDOB.Location = new System.Drawing.Point(89, 367);
            this.regDOB.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.regDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.regDOB.Name = "regDOB";
            this.regDOB.Size = new System.Drawing.Size(184, 26);
            this.regDOB.TabIndex = 5;
            this.regDOB.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // regAvatar
            // 
            this.regAvatar.BackColor = System.Drawing.Color.Transparent;
            this.regAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regAvatar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("regAvatar.ErrorImage")));
            this.regAvatar.Image = ((System.Drawing.Image)(resources.GetObject("regAvatar.Image")));
            this.regAvatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("regAvatar.InitialImage")));
            this.regAvatar.Location = new System.Drawing.Point(117, 44);
            this.regAvatar.Name = "regAvatar";
            this.regAvatar.Size = new System.Drawing.Size(125, 125);
            this.regAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.regAvatar.TabIndex = 4;
            this.regAvatar.TabStop = false;
            // 
            // regDBGAvatar
            // 
            this.regDBGAvatar.Location = new System.Drawing.Point(117, 174);
            this.regDBGAvatar.Name = "regDBGAvatar";
            this.regDBGAvatar.Size = new System.Drawing.Size(123, 26);
            this.regDBGAvatar.TabIndex = 0;
            this.regDBGAvatar.ValueChanged += new System.EventHandler(this.regDBGAvatar_ValueChanged);
            // 
            // regUsername
            // 
            this.regUsername.ForeColor = System.Drawing.Color.Silver;
            this.regUsername.Location = new System.Drawing.Point(89, 223);
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(184, 26);
            this.regUsername.TabIndex = 1;
            this.regUsername.Text = "Username";
            this.regUsername.TextChanged += new System.EventHandler(this.regUsername_TextChanged);
            this.regUsername.Enter += new System.EventHandler(this.regUsername_Enter);
            // 
            // regEmail
            // 
            this.regEmail.ForeColor = System.Drawing.Color.Silver;
            this.regEmail.Location = new System.Drawing.Point(89, 259);
            this.regEmail.Name = "regEmail";
            this.regEmail.Size = new System.Drawing.Size(184, 26);
            this.regEmail.TabIndex = 2;
            this.regEmail.Text = "Email";
            this.regEmail.TextChanged += new System.EventHandler(this.regEmail_TextChanged);
            this.regEmail.Enter += new System.EventHandler(this.regEmail_Enter);
            // 
            // regPassword
            // 
            this.regPassword.ForeColor = System.Drawing.Color.Silver;
            this.regPassword.Location = new System.Drawing.Point(89, 295);
            this.regPassword.Name = "regPassword";
            this.regPassword.Size = new System.Drawing.Size(184, 26);
            this.regPassword.TabIndex = 3;
            this.regPassword.Text = "Password";
            this.regPassword.TextChanged += new System.EventHandler(this.regPassword_TextChanged);
            this.regPassword.Enter += new System.EventHandler(this.regPassword_Enter);
            // 
            // regConfirm
            // 
            this.regConfirm.ForeColor = System.Drawing.Color.Silver;
            this.regConfirm.Location = new System.Drawing.Point(89, 331);
            this.regConfirm.Name = "regConfirm";
            this.regConfirm.Size = new System.Drawing.Size(184, 26);
            this.regConfirm.TabIndex = 4;
            this.regConfirm.Text = "Confirm";
            this.regConfirm.TextChanged += new System.EventHandler(this.regConfirm_TextChanged);
            this.regConfirm.Enter += new System.EventHandler(this.regConfirm_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 385);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 283);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 64);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Exodus_Challenge.Properties.Resources.hieroglyph;
            this.ClientSize = new System.Drawing.Size(363, 479);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logAvatar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDBGAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox logUsername;
        private System.Windows.Forms.TextBox logPassword;
        private System.Windows.Forms.PictureBox logAvatar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.DateTimePicker regDOB;
        private System.Windows.Forms.PictureBox regAvatar;
        private System.Windows.Forms.NumericUpDown regDBGAvatar;
        private System.Windows.Forms.TextBox regUsername;
        private System.Windows.Forms.TextBox regEmail;
        private System.Windows.Forms.TextBox regPassword;
        private System.Windows.Forms.TextBox regConfirm;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button bypass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
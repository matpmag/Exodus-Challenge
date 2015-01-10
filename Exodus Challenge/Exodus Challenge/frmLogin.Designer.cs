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
            if ( !changingForm && disposing && ( components != null ) )
            {
                components.Dispose();
            }
            if (!changingForm)
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
            this.panelDifficulty = new System.Windows.Forms.Panel();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.pbxDiff = new System.Windows.Forms.PictureBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.regDOB = new System.Windows.Forms.DateTimePicker();
            this.regAvatar = new System.Windows.Forms.PictureBox();
            this.regDBGAvatar = new System.Windows.Forms.NumericUpDown();
            this.regUsername = new System.Windows.Forms.TextBox();
            this.regEmail = new System.Windows.Forms.TextBox();
            this.regPassword = new System.Windows.Forms.TextBox();
            this.regConfirm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logAvatar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.panelDifficulty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDBGAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogin.Location = new System.Drawing.Point(3, 404);
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
            this.logUsername.Size = new System.Drawing.Size(236, 30);
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
            this.logPassword.Size = new System.Drawing.Size(236, 30);
            this.logPassword.TabIndex = 1;
            this.logPassword.Text = "Password";
            this.logPassword.TextChanged += new System.EventHandler(this.logPassword_TextChanged);
            this.logPassword.Enter += new System.EventHandler(this.logPassword_Enter);
            // 
            // logAvatar
            // 
            this.logAvatar.BackColor = System.Drawing.Color.Transparent;
            this.logAvatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.logAvatar.ErrorImage = global::Exodus_Challenge.Properties.Resources.Title;
            this.logAvatar.Image = global::Exodus_Challenge.Properties.Resources.Title;
            this.logAvatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("logAvatar.InitialImage")));
            this.logAvatar.Location = new System.Drawing.Point(3, 26);
            this.logAvatar.Name = "logAvatar";
            this.logAvatar.Size = new System.Drawing.Size(349, 125);
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
            this.tabLogin.Controls.Add(this.logAvatar);
            this.tabLogin.Controls.Add(this.bypass);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.logPassword);
            this.tabLogin.Controls.Add(this.logUsername);
            this.tabLogin.Location = new System.Drawing.Point(4, 32);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(355, 443);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // bypass
            // 
            this.bypass.BackColor = System.Drawing.Color.Red;
            this.bypass.Dock = System.Windows.Forms.DockStyle.Top;
            this.bypass.Location = new System.Drawing.Point(3, 3);
            this.bypass.Name = "bypass";
            this.bypass.Size = new System.Drawing.Size(349, 23);
            this.bypass.TabIndex = 1;
            this.bypass.UseVisualStyleBackColor = false;
            this.bypass.Click += new System.EventHandler(this.bypass_Click);
            // 
            // tabRegister
            // 
            this.tabRegister.BackgroundImage = global::Exodus_Challenge.Properties.Resources.sandstoneBrickSmallest;
            this.tabRegister.Controls.Add(this.panelDifficulty);
            this.tabRegister.Controls.Add(this.btnRegister);
            this.tabRegister.Controls.Add(this.regDOB);
            this.tabRegister.Controls.Add(this.regAvatar);
            this.tabRegister.Controls.Add(this.regDBGAvatar);
            this.tabRegister.Controls.Add(this.regUsername);
            this.tabRegister.Controls.Add(this.regEmail);
            this.tabRegister.Controls.Add(this.regPassword);
            this.tabRegister.Controls.Add(this.regConfirm);
            this.tabRegister.Location = new System.Drawing.Point(4, 32);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(355, 443);
            this.tabRegister.TabIndex = 1;
            this.tabRegister.Text = "Register";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // panelDifficulty
            // 
            this.panelDifficulty.Controls.Add(this.btnHard);
            this.panelDifficulty.Controls.Add(this.btnMedium);
            this.panelDifficulty.Controls.Add(this.btnEasy);
            this.panelDifficulty.Controls.Add(this.pbxDiff);
            this.panelDifficulty.Location = new System.Drawing.Point(8, 8);
            this.panelDifficulty.Name = "panelDifficulty";
            this.panelDifficulty.Size = new System.Drawing.Size(339, 390);
            this.panelDifficulty.TabIndex = 7;
            this.panelDifficulty.Visible = false;
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(224, 302);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(100, 64);
            this.btnHard.TabIndex = 3;
            this.btnHard.Text = "Master";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            this.btnHard.MouseEnter += new System.EventHandler(this.btnHard_MouseEnter);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(118, 302);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(100, 64);
            this.btnMedium.TabIndex = 2;
            this.btnMedium.Text = "Apprentice";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            this.btnMedium.MouseEnter += new System.EventHandler(this.btnMedium_MouseEnter);
            // 
            // btnEasy
            // 
            this.btnEasy.Location = new System.Drawing.Point(12, 302);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(100, 64);
            this.btnEasy.TabIndex = 1;
            this.btnEasy.Text = "Novice";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            this.btnEasy.MouseEnter += new System.EventHandler(this.btnEasy_MouseEnter);
            // 
            // pbxDiff
            // 
            this.pbxDiff.Image = global::Exodus_Challenge.Properties.Resources.scarabMin;
            this.pbxDiff.Location = new System.Drawing.Point(12, 13);
            this.pbxDiff.Name = "pbxDiff";
            this.pbxDiff.Size = new System.Drawing.Size(312, 283);
            this.pbxDiff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDiff.TabIndex = 0;
            this.pbxDiff.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRegister.Location = new System.Drawing.Point(3, 404);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(349, 36);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Set Difficulty";
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
            this.regDOB.Size = new System.Drawing.Size(184, 30);
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
            this.regDBGAvatar.Size = new System.Drawing.Size(123, 30);
            this.regDBGAvatar.TabIndex = 0;
            this.regDBGAvatar.ValueChanged += new System.EventHandler(this.regDBGAvatar_ValueChanged);
            // 
            // regUsername
            // 
            this.regUsername.ForeColor = System.Drawing.Color.Silver;
            this.regUsername.Location = new System.Drawing.Point(89, 223);
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(184, 30);
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
            this.regEmail.Size = new System.Drawing.Size(184, 30);
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
            this.regPassword.Size = new System.Drawing.Size(184, 30);
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
            this.regConfirm.Size = new System.Drawing.Size(184, 30);
            this.regConfirm.TabIndex = 4;
            this.regConfirm.Text = "Confirm";
            this.regConfirm.TextChanged += new System.EventHandler(this.regConfirm_TextChanged);
            this.regConfirm.Enter += new System.EventHandler(this.regConfirm_Enter);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
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
            this.panelDifficulty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDBGAvatar)).EndInit();
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
        private System.Windows.Forms.Panel panelDifficulty;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.PictureBox pbxDiff;
    }
}
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
            if ( disposing && ( components != null ) )
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bypass = new System.Windows.Forms.Button();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNextAvatar = new System.Windows.Forms.Button();
            this.btnPreviousAvatar = new System.Windows.Forms.Button();
            this.panelDifficulty = new System.Windows.Forms.Panel();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.pbxDiff = new System.Windows.Forms.PictureBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.regDOB = new System.Windows.Forms.DateTimePicker();
            this.regAvatar = new System.Windows.Forms.PictureBox();
            this.regUsername = new System.Windows.Forms.TextBox();
            this.regEmail = new System.Windows.Forms.TextBox();
            this.regPassword = new System.Windows.Forms.TextBox();
            this.regConfirm = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.logAvatar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.panelDifficulty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogin.Location = new System.Drawing.Point(3, 486);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(494, 36);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // logUsername
            // 
            this.logUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logUsername.ForeColor = System.Drawing.Color.Silver;
            this.logUsername.Location = new System.Drawing.Point(129, 23);
            this.logUsername.Name = "logUsername";
            this.logUsername.Size = new System.Drawing.Size(236, 30);
            this.logUsername.TabIndex = 0;
            this.logUsername.Text = "Username";
            this.logUsername.TextChanged += new System.EventHandler(this.logUsername_TextChanged);
            this.logUsername.Enter += new System.EventHandler(this.logUsername_Enter);
            // 
            // logPassword
            // 
            this.logPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logPassword.ForeColor = System.Drawing.Color.Silver;
            this.logPassword.Location = new System.Drawing.Point(129, 59);
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
            this.logAvatar.Location = new System.Drawing.Point(3, 3);
            this.logAvatar.Name = "logAvatar";
            this.logAvatar.Size = new System.Drawing.Size(494, 291);
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
            this.tabControl1.Size = new System.Drawing.Size(508, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.BackgroundImage = global::Exodus_Challenge.Properties.Resources.sandstoneBrick;
            this.tabLogin.Controls.Add(this.bypass);
            this.tabLogin.Controls.Add(this.tableLayoutPanel1);
            this.tabLogin.Controls.Add(this.logAvatar);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Location = new System.Drawing.Point(4, 32);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(500, 525);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.logPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.logUsername, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 294);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 92);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // bypass
            // 
            this.bypass.BackColor = System.Drawing.Color.Transparent;
            this.bypass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bypass.ForeColor = System.Drawing.Color.Transparent;
            this.bypass.Location = new System.Drawing.Point(486, 3);
            this.bypass.Margin = new System.Windows.Forms.Padding(0);
            this.bypass.Name = "bypass";
            this.bypass.Size = new System.Drawing.Size(14, 16);
            this.bypass.TabIndex = 1;
            this.bypass.UseVisualStyleBackColor = false;
            this.bypass.Visible = false;
            this.bypass.Click += new System.EventHandler(this.bypass_Click);
            // 
            // tabRegister
            // 
            this.tabRegister.BackgroundImage = global::Exodus_Challenge.Properties.Resources.sandstoneBrickSmallest;
            this.tabRegister.Controls.Add(this.panelDifficulty);
            this.tabRegister.Controls.Add(this.btnRegister);
            this.tabRegister.Controls.Add(this.regDOB);
            this.tabRegister.Controls.Add(this.regAvatar);
            this.tabRegister.Controls.Add(this.regUsername);
            this.tabRegister.Controls.Add(this.regEmail);
            this.tabRegister.Controls.Add(this.regPassword);
            this.tabRegister.Controls.Add(this.regConfirm);
            this.tabRegister.Controls.Add(this.button1);
            this.tabRegister.Controls.Add(this.btnNextAvatar);
            this.tabRegister.Controls.Add(this.btnPreviousAvatar);
            this.tabRegister.Location = new System.Drawing.Point(4, 32);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(500, 525);
            this.tabRegister.TabIndex = 1;
            this.tabRegister.Text = "Register";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNextAvatar
            // 
            this.btnNextAvatar.Location = new System.Drawing.Point(321, 48);
            this.btnNextAvatar.Name = "btnNextAvatar";
            this.btnNextAvatar.Size = new System.Drawing.Size(56, 124);
            this.btnNextAvatar.TabIndex = 7;
            this.btnNextAvatar.UseVisualStyleBackColor = true;
            this.btnNextAvatar.Click += new System.EventHandler(this.btnNextAvatar_Click);
            // 
            // btnPreviousAvatar
            // 
            this.btnPreviousAvatar.Location = new System.Drawing.Point(128, 48);
            this.btnPreviousAvatar.Name = "btnPreviousAvatar";
            this.btnPreviousAvatar.Size = new System.Drawing.Size(56, 124);
            this.btnPreviousAvatar.TabIndex = 6;
            this.btnPreviousAvatar.UseVisualStyleBackColor = true;
            this.btnPreviousAvatar.Click += new System.EventHandler(this.btnPreviousAvatar_Click);
            // 
            // panelDifficulty
            // 
            this.panelDifficulty.Controls.Add(this.btnHard);
            this.panelDifficulty.Controls.Add(this.btnMedium);
            this.panelDifficulty.Controls.Add(this.btnEasy);
            this.panelDifficulty.Controls.Add(this.pbxDiff);
            this.panelDifficulty.Location = new System.Drawing.Point(8, 11);
            this.panelDifficulty.Name = "panelDifficulty";
            this.panelDifficulty.Size = new System.Drawing.Size(469, 459);
            this.panelDifficulty.TabIndex = 9;
            this.panelDifficulty.Visible = false;
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(313, 360);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(140, 64);
            this.btnHard.TabIndex = 3;
            this.btnHard.Text = "Master";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            this.btnHard.MouseEnter += new System.EventHandler(this.btnHard_MouseEnter);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(170, 360);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(140, 64);
            this.btnMedium.TabIndex = 2;
            this.btnMedium.Text = "Apprentice";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            this.btnMedium.MouseEnter += new System.EventHandler(this.btnMedium_MouseEnter);
            // 
            // btnEasy
            // 
            this.btnEasy.Location = new System.Drawing.Point(24, 360);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(140, 64);
            this.btnEasy.TabIndex = 1;
            this.btnEasy.Text = "Novice";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            this.btnEasy.MouseEnter += new System.EventHandler(this.btnEasy_MouseEnter);
            // 
            // pbxDiff
            // 
            this.pbxDiff.Image = global::Exodus_Challenge.Properties.Resources.scarabMin;
            this.pbxDiff.Location = new System.Drawing.Point(95, 35);
            this.pbxDiff.Name = "pbxDiff";
            this.pbxDiff.Size = new System.Drawing.Size(330, 283);
            this.pbxDiff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDiff.TabIndex = 0;
            this.pbxDiff.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRegister.Location = new System.Drawing.Point(3, 486);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(494, 36);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Set Difficulty";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // regDOB
            // 
            this.regDOB.CalendarForeColor = System.Drawing.Color.Black;
            this.regDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.regDOB.Location = new System.Drawing.Point(162, 371);
            this.regDOB.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.regDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.regDOB.Name = "regDOB";
            this.regDOB.Size = new System.Drawing.Size(184, 30);
            this.regDOB.TabIndex = 4;
            this.regDOB.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // regAvatar
            // 
            this.regAvatar.BackColor = System.Drawing.Color.Transparent;
            this.regAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regAvatar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("regAvatar.ErrorImage")));
            this.regAvatar.Image = ((System.Drawing.Image)(resources.GetObject("regAvatar.Image")));
            this.regAvatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("regAvatar.InitialImage")));
            this.regAvatar.Location = new System.Drawing.Point(190, 48);
            this.regAvatar.Name = "regAvatar";
            this.regAvatar.Size = new System.Drawing.Size(125, 125);
            this.regAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.regAvatar.TabIndex = 4;
            this.regAvatar.TabStop = false;
            // 
            // regUsername
            // 
            this.regUsername.ForeColor = System.Drawing.Color.Silver;
            this.regUsername.Location = new System.Drawing.Point(162, 227);
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(184, 30);
            this.regUsername.TabIndex = 0;
            this.regUsername.Text = "Username";
            this.regUsername.TextChanged += new System.EventHandler(this.regUsername_TextChanged);
            this.regUsername.Enter += new System.EventHandler(this.regUsername_Enter);
            // 
            // regEmail
            // 
            this.regEmail.ForeColor = System.Drawing.Color.Silver;
            this.regEmail.Location = new System.Drawing.Point(162, 263);
            this.regEmail.Name = "regEmail";
            this.regEmail.Size = new System.Drawing.Size(184, 30);
            this.regEmail.TabIndex = 1;
            this.regEmail.Text = "Email";
            this.regEmail.TextChanged += new System.EventHandler(this.regEmail_TextChanged);
            this.regEmail.Enter += new System.EventHandler(this.regEmail_Enter);
            // 
            // regPassword
            // 
            this.regPassword.ForeColor = System.Drawing.Color.Silver;
            this.regPassword.Location = new System.Drawing.Point(162, 299);
            this.regPassword.Name = "regPassword";
            this.regPassword.Size = new System.Drawing.Size(184, 30);
            this.regPassword.TabIndex = 2;
            this.regPassword.Text = "Password";
            this.regPassword.TextChanged += new System.EventHandler(this.regPassword_TextChanged);
            this.regPassword.Enter += new System.EventHandler(this.regPassword_Enter);
            // 
            // regConfirm
            // 
            this.regConfirm.ForeColor = System.Drawing.Color.Silver;
            this.regConfirm.Location = new System.Drawing.Point(162, 335);
            this.regConfirm.Name = "regConfirm";
            this.regConfirm.Size = new System.Drawing.Size(184, 30);
            this.regConfirm.TabIndex = 3;
            this.regConfirm.Text = "Confirm";
            this.regConfirm.TextChanged += new System.EventHandler(this.regConfirm_TextChanged);
            this.regConfirm.Enter += new System.EventHandler(this.regConfirm_Enter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Exodus_Challenge.Properties.Resources.hieroglyph;
            this.ClientSize = new System.Drawing.Size(508, 561);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            this.panelDifficulty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regAvatar)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNextAvatar;
        private System.Windows.Forms.Button btnPreviousAvatar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
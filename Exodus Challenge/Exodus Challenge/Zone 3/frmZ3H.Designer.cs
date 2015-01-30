namespace Exodus_Challenge
{
    partial class frmZ3H
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZ2M));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblQText = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatDoIDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whereDoIFindTheAnswersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScoreMultiplier = new System.Windows.Forms.Label();
            this.timerScoreDecrement = new System.Windows.Forms.Timer(this.components);
            this.verticalProgressBar1 = new Exodus_Challenge.CustomControls.VerticalProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboxQ1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nudQ2 = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cboxQ3 = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.nudQ4 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQ2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQ4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubmit.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(484, 545);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(235, 58);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblQText
            // 
            this.lblQText.BackColor = System.Drawing.Color.Transparent;
            this.lblQText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQText.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQText.Location = new System.Drawing.Point(150, 20);
            this.lblQText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQText.Name = "lblQText";
            this.lblQText.Size = new System.Drawing.Size(382, 167);
            this.lblQText.TabIndex = 12;
            this.lblQText.Text = "What did Pharaoh command the taskmasters when Moses first requested him to let Is" +
    "rael go?";
            this.lblQText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = global::Exodus_Challenge.Properties.Resources.Scroll;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.lblQText);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel6.Location = new System.Drawing.Point(118, 65);
            this.panel6.Margin = new System.Windows.Forms.Padding(20);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(150, 20, 150, 20);
            this.panel6.Size = new System.Drawing.Size(682, 207);
            this.panel6.TabIndex = 27;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.retryToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1137, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Exit";
            // 
            // retryToolStripMenuItem
            // 
            this.retryToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.retryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.retryToolStripMenuItem.Name = "retryToolStripMenuItem";
            this.retryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.retryToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            this.retryToolStripMenuItem.Text = "Retry";
            this.retryToolStripMenuItem.ToolTipText = "Retry";
            this.retryToolStripMenuItem.Click += new System.EventHandler(this.retryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whatDoIDoToolStripMenuItem,
            this.whereDoIFindTheAnswersToolStripMenuItem});
            this.helpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.ToolTipText = "Help";
            // 
            // whatDoIDoToolStripMenuItem
            // 
            this.whatDoIDoToolStripMenuItem.Name = "whatDoIDoToolStripMenuItem";
            this.whatDoIDoToolStripMenuItem.Size = new System.Drawing.Size(269, 24);
            this.whatDoIDoToolStripMenuItem.Text = "What do I do?";
            this.whatDoIDoToolStripMenuItem.Click += new System.EventHandler(this.whatDoIDoToolStripMenuItem_Click);
            // 
            // whereDoIFindTheAnswersToolStripMenuItem
            // 
            this.whereDoIFindTheAnswersToolStripMenuItem.Name = "whereDoIFindTheAnswersToolStripMenuItem";
            this.whereDoIFindTheAnswersToolStripMenuItem.Size = new System.Drawing.Size(269, 24);
            this.whereDoIFindTheAnswersToolStripMenuItem.Text = "Where do I find the answers?";
            this.whereDoIFindTheAnswersToolStripMenuItem.Click += new System.EventHandler(this.whereDoIFindTheAnswersToolStripMenuItem_Click);
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::Exodus_Challenge.Properties.Resources.Papyrus;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.lblScoreMultiplier);
            this.panel7.Location = new System.Drawing.Point(5, 65);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(85, 55);
            this.panel7.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "x";
            // 
            // lblScoreMultiplier
            // 
            this.lblScoreMultiplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblScoreMultiplier.AutoSize = true;
            this.lblScoreMultiplier.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreMultiplier.Font = new System.Drawing.Font("Monotype Corsiva", 28F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreMultiplier.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblScoreMultiplier.Location = new System.Drawing.Point(11, -2);
            this.lblScoreMultiplier.Name = "lblScoreMultiplier";
            this.lblScoreMultiplier.Size = new System.Drawing.Size(66, 56);
            this.lblScoreMultiplier.TabIndex = 1;
            this.lblScoreMultiplier.Text = "50";
            this.lblScoreMultiplier.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // timerScoreDecrement
            // 
            this.timerScoreDecrement.Enabled = true;
            this.timerScoreDecrement.Tick += new System.EventHandler(this.timerScoreDecrement_Tick);
            // 
            // verticalProgressBar1
            // 
            this.verticalProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.verticalProgressBar1.Location = new System.Drawing.Point(15, 137);
            this.verticalProgressBar1.Margin = new System.Windows.Forms.Padding(20, 60, 0, 60);
            this.verticalProgressBar1.Maximum = 1200;
            this.verticalProgressBar1.Name = "verticalProgressBar1";
            this.verticalProgressBar1.Size = new System.Drawing.Size(56, 498);
            this.verticalProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.verticalProgressBar1.TabIndex = 30;
            this.verticalProgressBar1.Value = 1200;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(830, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 625);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // btnSkip
            // 
            this.btnSkip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSkip.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.Location = new System.Drawing.Point(227, 545);
            this.btnSkip.Margin = new System.Windows.Forms.Padding(6);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(235, 58);
            this.btnSkip.TabIndex = 34;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ItemSize = new System.Drawing.Size(50, 10);
            this.tabControl1.Location = new System.Drawing.Point(118, 345);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(433, 125);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Exodus_Challenge.Properties.Resources.Papyrus;
            this.tabPage1.Controls.Add(this.cboxQ1);
            this.tabPage1.Location = new System.Drawing.Point(4, 14);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(425, 107);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboxQ1
            // 
            this.cboxQ1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboxQ1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxQ1.FormattingEnabled = true;
            this.cboxQ1.Items.AddRange(new object[] {
            "Beat the Israelites",
            "Make them build the city of Rameses",
            "Take away their straw for making bricks",
            "All of the above"});
            this.cboxQ1.Location = new System.Drawing.Point(27, 38);
            this.cboxQ1.Margin = new System.Windows.Forms.Padding(6);
            this.cboxQ1.Name = "cboxQ1";
            this.cboxQ1.Size = new System.Drawing.Size(369, 31);
            this.cboxQ1.TabIndex = 34;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.BackgroundImage = global::Exodus_Challenge.Properties.Resources.Papyrus;
            this.tabPage2.Controls.Add(this.nudQ2);
            this.tabPage2.Location = new System.Drawing.Point(4, 14);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(425, 107);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // nudQ2
            // 
            this.nudQ2.Font = new System.Drawing.Font("Monotype Corsiva", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQ2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudQ2.Location = new System.Drawing.Point(165, 26);
            this.nudQ2.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudQ2.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudQ2.Name = "nudQ2";
            this.nudQ2.Size = new System.Drawing.Size(106, 49);
            this.nudQ2.TabIndex = 13;
            this.nudQ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQ2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Exodus_Challenge.Properties.Resources.Papyrus;
            this.tabPage3.Controls.Add(this.cboxQ3);
            this.tabPage3.Location = new System.Drawing.Point(4, 14);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(425, 107);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cboxQ3
            // 
            this.cboxQ3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboxQ3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxQ3.FormattingEnabled = true;
            this.cboxQ3.Items.AddRange(new object[] {
            "Flies on Egyptians but not on Israelites",
            "Cattle of Egyptians died but not Israelites",
            "Darkness covered the Egyptians but not the Israelites",
            "All of the above"});
            this.cboxQ3.Location = new System.Drawing.Point(27, 38);
            this.cboxQ3.Margin = new System.Windows.Forms.Padding(6);
            this.cboxQ3.Name = "cboxQ3";
            this.cboxQ3.Size = new System.Drawing.Size(369, 31);
            this.cboxQ3.TabIndex = 33;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::Exodus_Challenge.Properties.Resources.Papyrus;
            this.tabPage4.Controls.Add(this.nudQ4);
            this.tabPage4.Location = new System.Drawing.Point(4, 14);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(425, 107);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // nudQ4
            // 
            this.nudQ4.Font = new System.Drawing.Font("Monotype Corsiva", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQ4.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudQ4.Location = new System.Drawing.Point(165, 26);
            this.nudQ4.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudQ4.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudQ4.Name = "nudQ4";
            this.nudQ4.Size = new System.Drawing.Size(106, 49);
            this.nudQ4.TabIndex = 14;
            this.nudQ4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQ4.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(585, 313);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 175);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // frmZ2M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Exodus_Challenge.Properties.Resources.sandstoneBrickSmallest;
            this.ClientSize = new System.Drawing.Size(1137, 649);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.verticalProgressBar1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmZ2M";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exodus Challenge Zone 2 - Baby Moses";
            this.panel6.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQ2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQ4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblQText;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatDoIDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whereDoIFindTheAnswersToolStripMenuItem;
        private Exodus_Challenge.CustomControls.VerticalProgressBar verticalProgressBar1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScoreMultiplier;
        private System.Windows.Forms.Timer timerScoreDecrement;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown nudQ2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cboxQ1;
        private System.Windows.Forms.ComboBox cboxQ3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.NumericUpDown nudQ4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
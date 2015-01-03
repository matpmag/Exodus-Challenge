namespace Exodus_Challenge
{
    partial class LevelSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelSelect));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabConsole = new System.Windows.Forms.TabPage();
            this.tbxConsoleOutput = new System.Windows.Forms.TextBox();
            this.inpConsoleCommand = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.btnEnableConsole = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.tabLevelSelect = new System.Windows.Forms.TabPage();
            this.tblScores = new System.Windows.Forms.TableLayoutPanel();
            this.lblMannaScore = new System.Windows.Forms.Label();
            this.pbxManna = new System.Windows.Forms.PictureBox();
            this.pbxQuail = new System.Windows.Forms.PictureBox();
            this.lblQuailScore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnlvlQ5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnlvlQ2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnlvlQ3 = new System.Windows.Forms.Button();
            this.btnlvlG6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnlvlQ4 = new System.Windows.Forms.Button();
            this.btnlvlG1 = new System.Windows.Forms.Button();
            this.btnlvlG3 = new System.Windows.Forms.Button();
            this.btnlvlG2 = new System.Windows.Forms.Button();
            this.btnlvlG4 = new System.Windows.Forms.Button();
            this.btnlvl5 = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.btnSettingCheatsLevel = new System.Windows.Forms.Button();
            this.btnSettingCheatsQuail = new System.Windows.Forms.Button();
            this.btnSettingCheatsManna = new System.Windows.Forms.Button();
            this.btnSettingDifficultyHard = new System.Windows.Forms.Button();
            this.btnSettingDifficultyMedium = new System.Windows.Forms.Button();
            this.btnSettingDifficultyEasy = new System.Windows.Forms.Button();
            this.tblSettings = new System.Windows.Forms.TableLayoutPanel();
            this.btnSettingConsoleActivate = new System.Windows.Forms.Button();
            this.btnSettingCheatsActivate = new System.Windows.Forms.Button();
            this.btnSettingDifficultyActivate = new System.Windows.Forms.Button();
            this.btnSettingAccountActivate = new System.Windows.Forms.Button();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabConsole.SuspendLayout();
            this.tabLevelSelect.SuspendLayout();
            this.tblScores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxManna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQuail)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.tblSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.tabLevelSelect);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Controls.Add(this.tabAccount);
            this.tabControl.Controls.Add(this.tabConsole);
            this.tabControl.ItemSize = new System.Drawing.Size(83, 21);
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(1100, 719);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 30;
            // 
            // tabConsole
            // 
            this.tabConsole.BackColor = System.Drawing.SystemColors.Desktop;
            this.tabConsole.Controls.Add(this.tbxConsoleOutput);
            this.tabConsole.Controls.Add(this.inpConsoleCommand);
            this.tabConsole.Location = new System.Drawing.Point(4, 25);
            this.tabConsole.Margin = new System.Windows.Forms.Padding(0);
            this.tabConsole.Name = "tabConsole";
            this.tabConsole.Size = new System.Drawing.Size(1092, 690);
            this.tabConsole.TabIndex = 2;
            this.tabConsole.Text = "Console";
            // 
            // tbxConsoleOutput
            // 
            this.tbxConsoleOutput.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbxConsoleOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxConsoleOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxConsoleOutput.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConsoleOutput.ForeColor = System.Drawing.Color.Green;
            this.tbxConsoleOutput.Location = new System.Drawing.Point(0, 0);
            this.tbxConsoleOutput.Multiline = true;
            this.tbxConsoleOutput.Name = "tbxConsoleOutput";
            this.tbxConsoleOutput.ReadOnly = true;
            this.tbxConsoleOutput.Size = new System.Drawing.Size(1092, 652);
            this.tbxConsoleOutput.TabIndex = 1;
            this.tbxConsoleOutput.Text = "<Console Output Text>";
            // 
            // inpConsoleCommand
            // 
            this.inpConsoleCommand.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inpConsoleCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpConsoleCommand.Location = new System.Drawing.Point(0, 652);
            this.inpConsoleCommand.Name = "inpConsoleCommand";
            this.inpConsoleCommand.Size = new System.Drawing.Size(1092, 38);
            this.inpConsoleCommand.TabIndex = 0;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Location = new System.Drawing.Point(20, 114);
            this.button11.Margin = new System.Windows.Forms.Padding(20);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(404, 54);
            this.button11.TabIndex = 1;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // btnEnableConsole
            // 
            this.btnEnableConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnableConsole.Location = new System.Drawing.Point(20, 20);
            this.btnEnableConsole.Margin = new System.Windows.Forms.Padding(20);
            this.btnEnableConsole.Name = "btnEnableConsole";
            this.btnEnableConsole.Size = new System.Drawing.Size(404, 54);
            this.btnEnableConsole.TabIndex = 0;
            this.btnEnableConsole.Text = "button10";
            this.btnEnableConsole.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Location = new System.Drawing.Point(20, 208);
            this.button12.Margin = new System.Windows.Forms.Padding(20);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(404, 54);
            this.button12.TabIndex = 2;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Location = new System.Drawing.Point(20, 302);
            this.button13.Margin = new System.Windows.Forms.Padding(20);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(404, 54);
            this.button13.TabIndex = 2;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button14.Location = new System.Drawing.Point(20, 396);
            this.button14.Margin = new System.Windows.Forms.Padding(20);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(404, 56);
            this.button14.TabIndex = 2;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // tabLevelSelect
            // 
            this.tabLevelSelect.BackColor = System.Drawing.Color.Wheat;
            this.tabLevelSelect.BackgroundImage = global::Exodus_Challenge.Properties.Resources.map;
            this.tabLevelSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabLevelSelect.Controls.Add(this.tblScores);
            this.tabLevelSelect.Controls.Add(this.button1);
            this.tabLevelSelect.Controls.Add(this.button9);
            this.tabLevelSelect.Controls.Add(this.btnlvlQ5);
            this.tabLevelSelect.Controls.Add(this.button8);
            this.tabLevelSelect.Controls.Add(this.btnHelp);
            this.tabLevelSelect.Controls.Add(this.btnSettings);
            this.tabLevelSelect.Controls.Add(this.btnSave);
            this.tabLevelSelect.Controls.Add(this.btnQuit);
            this.tabLevelSelect.Controls.Add(this.button7);
            this.tabLevelSelect.Controls.Add(this.btnlvlQ2);
            this.tabLevelSelect.Controls.Add(this.button6);
            this.tabLevelSelect.Controls.Add(this.btnlvlQ3);
            this.tabLevelSelect.Controls.Add(this.btnlvlG6);
            this.tabLevelSelect.Controls.Add(this.button5);
            this.tabLevelSelect.Controls.Add(this.btnlvlQ4);
            this.tabLevelSelect.Controls.Add(this.btnlvlG1);
            this.tabLevelSelect.Controls.Add(this.btnlvlG3);
            this.tabLevelSelect.Controls.Add(this.btnlvlG2);
            this.tabLevelSelect.Controls.Add(this.btnlvlG4);
            this.tabLevelSelect.Controls.Add(this.btnlvl5);
            this.tabLevelSelect.Location = new System.Drawing.Point(4, 25);
            this.tabLevelSelect.Name = "tabLevelSelect";
            this.tabLevelSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabLevelSelect.Size = new System.Drawing.Size(1092, 690);
            this.tabLevelSelect.TabIndex = 0;
            this.tabLevelSelect.Text = "Level  Select";
            // 
            // tblScores
            // 
            this.tblScores.BackgroundImage = global::Exodus_Challenge.Properties.Resources.Papyrus;
            this.tblScores.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tblScores.ColumnCount = 2;
            this.tblScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.9669F));
            this.tblScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.0331F));
            this.tblScores.Controls.Add(this.lblMannaScore, 1, 0);
            this.tblScores.Controls.Add(this.pbxManna, 0, 0);
            this.tblScores.Controls.Add(this.pbxQuail, 0, 1);
            this.tblScores.Controls.Add(this.lblQuailScore, 1, 1);
            this.tblScores.Location = new System.Drawing.Point(9, 531);
            this.tblScores.Name = "tblScores";
            this.tblScores.RowCount = 2;
            this.tblScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblScores.Size = new System.Drawing.Size(426, 151);
            this.tblScores.TabIndex = 31;
            // 
            // lblMannaScore
            // 
            this.lblMannaScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMannaScore.AutoSize = true;
            this.lblMannaScore.BackColor = System.Drawing.Color.Transparent;
            this.lblMannaScore.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMannaScore.Location = new System.Drawing.Point(83, 3);
            this.lblMannaScore.Name = "lblMannaScore";
            this.lblMannaScore.Size = new System.Drawing.Size(337, 71);
            this.lblMannaScore.TabIndex = 15;
            this.lblMannaScore.Text = "<MannaScore>";
            this.lblMannaScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxManna
            // 
            this.pbxManna.BackColor = System.Drawing.Color.Transparent;
            this.pbxManna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxManna.Image = ((System.Drawing.Image)(resources.GetObject("pbxManna.Image")));
            this.pbxManna.Location = new System.Drawing.Point(6, 5);
            this.pbxManna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxManna.Name = "pbxManna";
            this.pbxManna.Size = new System.Drawing.Size(68, 67);
            this.pbxManna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxManna.TabIndex = 12;
            this.pbxManna.TabStop = false;
            // 
            // pbxQuail
            // 
            this.pbxQuail.BackColor = System.Drawing.Color.Transparent;
            this.pbxQuail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxQuail.Image = ((System.Drawing.Image)(resources.GetObject("pbxQuail.Image")));
            this.pbxQuail.Location = new System.Drawing.Point(6, 79);
            this.pbxQuail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxQuail.Name = "pbxQuail";
            this.pbxQuail.Size = new System.Drawing.Size(68, 67);
            this.pbxQuail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxQuail.TabIndex = 11;
            this.pbxQuail.TabStop = false;
            // 
            // lblQuailScore
            // 
            this.lblQuailScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuailScore.AutoSize = true;
            this.lblQuailScore.BackColor = System.Drawing.Color.Transparent;
            this.lblQuailScore.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuailScore.Location = new System.Drawing.Point(83, 77);
            this.lblQuailScore.Name = "lblQuailScore";
            this.lblQuailScore.Size = new System.Drawing.Size(337, 71);
            this.lblQuailScore.TabIndex = 14;
            this.lblQuailScore.Text = "<QuailScore>";
            this.lblQuailScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(222, 165);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 41);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.Transparent;
            this.button9.Location = new System.Drawing.Point(919, 220);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(43, 41);
            this.button9.TabIndex = 29;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // btnlvlQ5
            // 
            this.btnlvlQ5.BackColor = System.Drawing.Color.Transparent;
            this.btnlvlQ5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlvlQ5.BackgroundImage")));
            this.btnlvlQ5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlvlQ5.FlatAppearance.BorderSize = 0;
            this.btnlvlQ5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnlvlQ5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnlvlQ5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlvlQ5.ForeColor = System.Drawing.Color.Transparent;
            this.btnlvlQ5.Location = new System.Drawing.Point(945, 87);
            this.btnlvlQ5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlvlQ5.Name = "btnlvlQ5";
            this.btnlvlQ5.Size = new System.Drawing.Size(43, 41);
            this.btnlvlQ5.TabIndex = 4;
            this.btnlvlQ5.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Transparent;
            this.button8.Location = new System.Drawing.Point(721, 449);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(43, 41);
            this.button8.TabIndex = 28;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.Transparent;
            this.btnHelp.Location = new System.Drawing.Point(1028, 562);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(56, 57);
            this.btnHelp.TabIndex = 17;
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImage = global::Exodus_Challenge.Properties.Resources.settings;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.Transparent;
            this.btnSettings.Location = new System.Drawing.Point(1028, 625);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(56, 57);
            this.btnSettings.TabIndex = 16;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(1028, 501);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 57);
            this.btnSave.TabIndex = 18;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuit.BackgroundImage")));
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuit.Location = new System.Drawing.Point(1033, 1);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(56, 57);
            this.btnQuit.TabIndex = 19;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.Transparent;
            this.button7.Location = new System.Drawing.Point(605, 461);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(43, 41);
            this.button7.TabIndex = 27;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btnlvlQ2
            // 
            this.btnlvlQ2.BackColor = System.Drawing.Color.Transparent;
            this.btnlvlQ2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlvlQ2.BackgroundImage")));
            this.btnlvlQ2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlvlQ2.FlatAppearance.BorderSize = 0;
            this.btnlvlQ2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnlvlQ2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnlvlQ2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlvlQ2.ForeColor = System.Drawing.Color.Transparent;
            this.btnlvlQ2.Location = new System.Drawing.Point(409, 351);
            this.btnlvlQ2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlvlQ2.Name = "btnlvlQ2";
            this.btnlvlQ2.Size = new System.Drawing.Size(43, 41);
            this.btnlvlQ2.TabIndex = 1;
            this.btnlvlQ2.UseVisualStyleBackColor = false;
            this.btnlvlQ2.Click += new System.EventHandler(this.btnlvlQ2_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(375, 297);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(43, 41);
            this.button6.TabIndex = 26;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnlvlQ3
            // 
            this.btnlvlQ3.BackColor = System.Drawing.Color.Transparent;
            this.btnlvlQ3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlvlQ3.BackgroundImage")));
            this.btnlvlQ3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlvlQ3.FlatAppearance.BorderSize = 0;
            this.btnlvlQ3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnlvlQ3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnlvlQ3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlvlQ3.ForeColor = System.Drawing.Color.Transparent;
            this.btnlvlQ3.Location = new System.Drawing.Point(545, 389);
            this.btnlvlQ3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlvlQ3.Name = "btnlvlQ3";
            this.btnlvlQ3.Size = new System.Drawing.Size(43, 41);
            this.btnlvlQ3.TabIndex = 2;
            this.btnlvlQ3.UseVisualStyleBackColor = false;
            this.btnlvlQ3.Click += new System.EventHandler(this.btnlvlQ3_Click);
            // 
            // btnlvlG6
            // 
            this.btnlvlG6.AutoSize = true;
            this.btnlvlG6.BackColor = System.Drawing.Color.Transparent;
            this.btnlvlG6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlvlG6.BackgroundImage")));
            this.btnlvlG6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlvlG6.FlatAppearance.BorderSize = 0;
            this.btnlvlG6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnlvlG6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnlvlG6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlvlG6.ForeColor = System.Drawing.Color.Transparent;
            this.btnlvlG6.Location = new System.Drawing.Point(945, 2);
            this.btnlvlG6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlvlG6.Name = "btnlvlG6";
            this.btnlvlG6.Size = new System.Drawing.Size(67, 63);
            this.btnlvlG6.TabIndex = 10;
            this.btnlvlG6.UseVisualStyleBackColor = false;
            this.btnlvlG6.Click += new System.EventHandler(this.btnlvlG6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(292, 182);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 41);
            this.button5.TabIndex = 25;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnlvlQ4
            // 
            this.btnlvlQ4.BackColor = System.Drawing.Color.Transparent;
            this.btnlvlQ4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlvlQ4.BackgroundImage")));
            this.btnlvlQ4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlvlQ4.FlatAppearance.BorderSize = 0;
            this.btnlvlQ4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnlvlQ4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnlvlQ4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlvlQ4.ForeColor = System.Drawing.Color.Transparent;
            this.btnlvlQ4.Location = new System.Drawing.Point(763, 377);
            this.btnlvlQ4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlvlQ4.Name = "btnlvlQ4";
            this.btnlvlQ4.Size = new System.Drawing.Size(43, 41);
            this.btnlvlQ4.TabIndex = 3;
            this.btnlvlQ4.UseVisualStyleBackColor = false;
            this.btnlvlQ4.Click += new System.EventHandler(this.btnlvlQ4_Click);
            // 
            // btnlvlG1
            // 
            this.btnlvlG1.AutoSize = true;
            this.btnlvlG1.BackColor = System.Drawing.Color.Transparent;
            this.btnlvlG1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlvlG1.BackgroundImage")));
            this.btnlvlG1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlvlG1.FlatAppearance.BorderSize = 0;
            this.btnlvlG1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnlvlG1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnlvlG1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlvlG1.ForeColor = System.Drawing.Color.Transparent;
            this.btnlvlG1.Location = new System.Drawing.Point(124, 148);
            this.btnlvlG1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlvlG1.Name = "btnlvlG1";
            this.btnlvlG1.Size = new System.Drawing.Size(71, 75);
            this.btnlvlG1.TabIndex = 5;
            this.btnlvlG1.UseVisualStyleBackColor = false;
            this.btnlvlG1.Click += new System.EventHandler(this.btnlvlG1_Click);
            // 
            // btnlvlG3
            // 
            this.btnlvlG3.AutoSize = true;
            this.btnlvlG3.BackColor = System.Drawing.Color.Transparent;
            this.btnlvlG3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlvlG3.BackgroundImage")));
            this.btnlvlG3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlvlG3.FlatAppearance.BorderSize = 0;
            this.btnlvlG3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnlvlG3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnlvlG3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlvlG3.ForeColor = System.Drawing.Color.Transparent;
            this.btnlvlG3.Location = new System.Drawing.Point(472, 365);
            this.btnlvlG3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlvlG3.Name = "btnlvlG3";
            this.btnlvlG3.Size = new System.Drawing.Size(67, 65);
            this.btnlvlG3.TabIndex = 6;
            this.btnlvlG3.UseVisualStyleBackColor = false;
            this.btnlvlG3.Click += new System.EventHandler(this.btnlvlG3_Click);
            // 
            // btnlvlG2
            // 
            this.btnlvlG2.AutoSize = true;
            this.btnlvlG2.BackColor = System.Drawing.Color.Transparent;
            this.btnlvlG2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlvlG2.BackgroundImage")));
            this.btnlvlG2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlvlG2.FlatAppearance.BorderSize = 0;
            this.btnlvlG2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnlvlG2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnlvlG2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlvlG2.ForeColor = System.Drawing.Color.Transparent;
            this.btnlvlG2.Location = new System.Drawing.Point(341, 201);
            this.btnlvlG2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlvlG2.Name = "btnlvlG2";
            this.btnlvlG2.Size = new System.Drawing.Size(77, 78);
            this.btnlvlG2.TabIndex = 7;
            this.btnlvlG2.UseVisualStyleBackColor = false;
            this.btnlvlG2.Click += new System.EventHandler(this.btnlvlG2_Click);
            // 
            // btnlvlG4
            // 
            this.btnlvlG4.AutoSize = true;
            this.btnlvlG4.BackColor = System.Drawing.Color.Transparent;
            this.btnlvlG4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlvlG4.BackgroundImage")));
            this.btnlvlG4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlvlG4.FlatAppearance.BorderSize = 0;
            this.btnlvlG4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnlvlG4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnlvlG4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlvlG4.ForeColor = System.Drawing.Color.Transparent;
            this.btnlvlG4.Location = new System.Drawing.Point(666, 532);
            this.btnlvlG4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlvlG4.Name = "btnlvlG4";
            this.btnlvlG4.Size = new System.Drawing.Size(69, 65);
            this.btnlvlG4.TabIndex = 8;
            this.btnlvlG4.UseVisualStyleBackColor = false;
            this.btnlvlG4.Click += new System.EventHandler(this.btnlvlG4_Click);
            // 
            // btnlvl5
            // 
            this.btnlvl5.AutoSize = true;
            this.btnlvl5.BackColor = System.Drawing.Color.Transparent;
            this.btnlvl5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlvl5.BackgroundImage")));
            this.btnlvl5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlvl5.FlatAppearance.BorderSize = 0;
            this.btnlvl5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnlvl5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnlvl5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlvl5.ForeColor = System.Drawing.Color.Transparent;
            this.btnlvl5.Location = new System.Drawing.Point(816, 297);
            this.btnlvl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlvl5.Name = "btnlvl5";
            this.btnlvl5.Size = new System.Drawing.Size(75, 79);
            this.btnlvl5.TabIndex = 9;
            this.btnlvl5.UseVisualStyleBackColor = false;
            // 
            // tabSettings
            // 
            this.tabSettings.BackgroundImage = global::Exodus_Challenge.Properties.Resources.sandstoneBrickSmallest;
            this.tabSettings.Controls.Add(this.btnSettingCheatsLevel);
            this.tabSettings.Controls.Add(this.btnSettingCheatsQuail);
            this.tabSettings.Controls.Add(this.btnSettingCheatsManna);
            this.tabSettings.Controls.Add(this.btnSettingDifficultyHard);
            this.tabSettings.Controls.Add(this.btnSettingDifficultyMedium);
            this.tabSettings.Controls.Add(this.btnSettingDifficultyEasy);
            this.tabSettings.Controls.Add(this.tblSettings);
            this.tabSettings.Location = new System.Drawing.Point(4, 25);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(1092, 690);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // btnSettingCheatsLevel
            // 
            this.btnSettingCheatsLevel.Location = new System.Drawing.Point(699, 572);
            this.btnSettingCheatsLevel.Name = "btnSettingCheatsLevel";
            this.btnSettingCheatsLevel.Size = new System.Drawing.Size(237, 66);
            this.btnSettingCheatsLevel.TabIndex = 7;
            this.btnSettingCheatsLevel.Text = "btnSettingCheatsLevel";
            this.btnSettingCheatsLevel.UseVisualStyleBackColor = true;
            this.btnSettingCheatsLevel.Visible = false;
            this.btnSettingCheatsLevel.Click += new System.EventHandler(this.btnSettingCheatsLevel_Click);
            // 
            // btnSettingCheatsQuail
            // 
            this.btnSettingCheatsQuail.Location = new System.Drawing.Point(699, 500);
            this.btnSettingCheatsQuail.Name = "btnSettingCheatsQuail";
            this.btnSettingCheatsQuail.Size = new System.Drawing.Size(237, 66);
            this.btnSettingCheatsQuail.TabIndex = 6;
            this.btnSettingCheatsQuail.Text = "btnSettingCheatsQuail";
            this.btnSettingCheatsQuail.UseVisualStyleBackColor = true;
            this.btnSettingCheatsQuail.Visible = false;
            this.btnSettingCheatsQuail.Click += new System.EventHandler(this.btnSettingCheatsQuail_Click);
            // 
            // btnSettingCheatsManna
            // 
            this.btnSettingCheatsManna.Location = new System.Drawing.Point(699, 428);
            this.btnSettingCheatsManna.Name = "btnSettingCheatsManna";
            this.btnSettingCheatsManna.Size = new System.Drawing.Size(237, 66);
            this.btnSettingCheatsManna.TabIndex = 5;
            this.btnSettingCheatsManna.Text = "btnSettingCheatsManna";
            this.btnSettingCheatsManna.UseVisualStyleBackColor = true;
            this.btnSettingCheatsManna.Visible = false;
            this.btnSettingCheatsManna.Click += new System.EventHandler(this.btnSettingCheatsManna_Click);
            // 
            // btnSettingDifficultyHard
            // 
            this.btnSettingDifficultyHard.Location = new System.Drawing.Point(699, 310);
            this.btnSettingDifficultyHard.Name = "btnSettingDifficultyHard";
            this.btnSettingDifficultyHard.Size = new System.Drawing.Size(237, 66);
            this.btnSettingDifficultyHard.TabIndex = 4;
            this.btnSettingDifficultyHard.Text = "btnSettingDifficultyHard";
            this.btnSettingDifficultyHard.UseVisualStyleBackColor = true;
            this.btnSettingDifficultyHard.Visible = false;
            this.btnSettingDifficultyHard.Click += new System.EventHandler(this.btnSettingDifficultyHard_Click);
            // 
            // btnSettingDifficultyMedium
            // 
            this.btnSettingDifficultyMedium.Location = new System.Drawing.Point(699, 238);
            this.btnSettingDifficultyMedium.Name = "btnSettingDifficultyMedium";
            this.btnSettingDifficultyMedium.Size = new System.Drawing.Size(237, 66);
            this.btnSettingDifficultyMedium.TabIndex = 3;
            this.btnSettingDifficultyMedium.Text = "btnSettingDifficultyMedium";
            this.btnSettingDifficultyMedium.UseVisualStyleBackColor = true;
            this.btnSettingDifficultyMedium.Visible = false;
            this.btnSettingDifficultyMedium.Click += new System.EventHandler(this.btnSettingDifficultyMedium_Click);
            // 
            // btnSettingDifficultyEasy
            // 
            this.btnSettingDifficultyEasy.Location = new System.Drawing.Point(699, 166);
            this.btnSettingDifficultyEasy.Name = "btnSettingDifficultyEasy";
            this.btnSettingDifficultyEasy.Size = new System.Drawing.Size(237, 66);
            this.btnSettingDifficultyEasy.TabIndex = 2;
            this.btnSettingDifficultyEasy.Text = "btnSettingDifficultyEasy";
            this.btnSettingDifficultyEasy.UseVisualStyleBackColor = true;
            this.btnSettingDifficultyEasy.Visible = false;
            this.btnSettingDifficultyEasy.Click += new System.EventHandler(this.btnSettingDifficultyEasy_Click);
            // 
            // tblSettings
            // 
            this.tblSettings.BackColor = System.Drawing.Color.Transparent;
            this.tblSettings.ColumnCount = 1;
            this.tblSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblSettings.Controls.Add(this.btnSettingConsoleActivate, 0, 3);
            this.tblSettings.Controls.Add(this.btnSettingCheatsActivate, 0, 2);
            this.tblSettings.Controls.Add(this.btnSettingDifficultyActivate, 0, 0);
            this.tblSettings.Controls.Add(this.btnSettingAccountActivate, 0, 1);
            this.tblSettings.Location = new System.Drawing.Point(103, 166);
            this.tblSettings.Margin = new System.Windows.Forms.Padding(0);
            this.tblSettings.Name = "tblSettings";
            this.tblSettings.RowCount = 4;
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblSettings.Size = new System.Drawing.Size(438, 472);
            this.tblSettings.TabIndex = 1;
            // 
            // btnSettingConsoleActivate
            // 
            this.btnSettingConsoleActivate.AutoSize = true;
            this.btnSettingConsoleActivate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSettingConsoleActivate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettingConsoleActivate.Location = new System.Drawing.Point(20, 374);
            this.btnSettingConsoleActivate.Margin = new System.Windows.Forms.Padding(20);
            this.btnSettingConsoleActivate.Name = "btnSettingConsoleActivate";
            this.btnSettingConsoleActivate.Size = new System.Drawing.Size(398, 78);
            this.btnSettingConsoleActivate.TabIndex = 9;
            this.btnSettingConsoleActivate.Text = "btnSettingConsoleActivate";
            this.btnSettingConsoleActivate.UseVisualStyleBackColor = true;
            this.btnSettingConsoleActivate.Visible = false;
            this.btnSettingConsoleActivate.Click += new System.EventHandler(this.btnSettingConsoleActivate_Click);
            // 
            // btnSettingCheatsActivate
            // 
            this.btnSettingCheatsActivate.AutoSize = true;
            this.btnSettingCheatsActivate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSettingCheatsActivate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettingCheatsActivate.Location = new System.Drawing.Point(20, 256);
            this.btnSettingCheatsActivate.Margin = new System.Windows.Forms.Padding(20);
            this.btnSettingCheatsActivate.Name = "btnSettingCheatsActivate";
            this.btnSettingCheatsActivate.Size = new System.Drawing.Size(398, 78);
            this.btnSettingCheatsActivate.TabIndex = 7;
            this.btnSettingCheatsActivate.Text = "btnSettingCheatsActivate";
            this.btnSettingCheatsActivate.UseVisualStyleBackColor = true;
            this.btnSettingCheatsActivate.Click += new System.EventHandler(this.btnSettingCheatsActivate_Click);
            // 
            // btnSettingDifficultyActivate
            // 
            this.btnSettingDifficultyActivate.AutoSize = true;
            this.btnSettingDifficultyActivate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSettingDifficultyActivate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettingDifficultyActivate.Location = new System.Drawing.Point(20, 20);
            this.btnSettingDifficultyActivate.Margin = new System.Windows.Forms.Padding(20);
            this.btnSettingDifficultyActivate.Name = "btnSettingDifficultyActivate";
            this.btnSettingDifficultyActivate.Size = new System.Drawing.Size(398, 78);
            this.btnSettingDifficultyActivate.TabIndex = 5;
            this.btnSettingDifficultyActivate.Text = "btnSettingDifficultyActivate";
            this.btnSettingDifficultyActivate.UseVisualStyleBackColor = true;
            this.btnSettingDifficultyActivate.Click += new System.EventHandler(this.btnSettingDifficultyActivate_Click);
            // 
            // btnSettingAccountActivate
            // 
            this.btnSettingAccountActivate.AutoSize = true;
            this.btnSettingAccountActivate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSettingAccountActivate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettingAccountActivate.Location = new System.Drawing.Point(20, 138);
            this.btnSettingAccountActivate.Margin = new System.Windows.Forms.Padding(20);
            this.btnSettingAccountActivate.Name = "btnSettingAccountActivate";
            this.btnSettingAccountActivate.Size = new System.Drawing.Size(398, 78);
            this.btnSettingAccountActivate.TabIndex = 8;
            this.btnSettingAccountActivate.Text = "btnSettingAccountActivate";
            this.btnSettingAccountActivate.UseVisualStyleBackColor = true;
            this.btnSettingAccountActivate.Click += new System.EventHandler(this.btnSettingAccountActivate_Click);
            // 
            // tabAccount
            // 
            this.tabAccount.BackgroundImage = global::Exodus_Challenge.Properties.Resources.sandstoneBrickSmallest;
            this.tabAccount.Location = new System.Drawing.Point(4, 25);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(1092, 690);
            this.tabAccount.TabIndex = 3;
            this.tabAccount.Text = "Account";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // LevelSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 747);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LevelSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level Select";
            this.Load += new System.EventHandler(this.LevelSelect_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabConsole.ResumeLayout(false);
            this.tabConsole.PerformLayout();
            this.tabLevelSelect.ResumeLayout(false);
            this.tabLevelSelect.PerformLayout();
            this.tblScores.ResumeLayout(false);
            this.tblScores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxManna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQuail)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tblSettings.ResumeLayout(false);
            this.tblSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlvlQ2;
        private System.Windows.Forms.Button btnlvlQ3;
        private System.Windows.Forms.Button btnlvlQ4;
        private System.Windows.Forms.Button btnlvlQ5;
        private System.Windows.Forms.Button btnlvlG1;
        private System.Windows.Forms.Button btnlvlG3;
        private System.Windows.Forms.Button btnlvlG2;
        private System.Windows.Forms.Button btnlvlG4;
        private System.Windows.Forms.Button btnlvl5;
        private System.Windows.Forms.Button btnlvlG6;
        private System.Windows.Forms.PictureBox pbxQuail;
        private System.Windows.Forms.PictureBox pbxManna;
        private System.Windows.Forms.Label lblQuailScore;
        private System.Windows.Forms.Label lblMannaScore;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLevelSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabConsole;
        private System.Windows.Forms.TextBox tbxConsoleOutput;
        private System.Windows.Forms.TextBox inpConsoleCommand;
        private System.Windows.Forms.TableLayoutPanel tblScores;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TableLayoutPanel tblSettings;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnEnableConsole;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btnSettingCheatsLevel;
        private System.Windows.Forms.Button btnSettingCheatsQuail;
        private System.Windows.Forms.Button btnSettingCheatsManna;
        private System.Windows.Forms.Button btnSettingDifficultyHard;
        private System.Windows.Forms.Button btnSettingDifficultyMedium;
        private System.Windows.Forms.Button btnSettingDifficultyEasy;
        private System.Windows.Forms.Button btnSettingAccountActivate;
        private System.Windows.Forms.Button btnSettingCheatsActivate;
        private System.Windows.Forms.Button btnSettingDifficultyActivate;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.Button btnSettingConsoleActivate;
    }
}
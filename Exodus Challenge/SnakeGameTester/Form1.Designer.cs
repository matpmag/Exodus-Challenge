namespace SnakeGameTester
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
            this.components = new System.ComponentModel.Container();
            this.tblLayoutOrganiser = new System.Windows.Forms.TableLayoutPanel();
            this.pbxPlayArea = new System.Windows.Forms.PictureBox();
            this.tblSidePanel = new System.Windows.Forms.TableLayoutPanel();
            this.gboxInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxDebug = new System.Windows.Forms.GroupBox();
            this.btnDebug3 = new System.Windows.Forms.Button();
            this.btnDebug2 = new System.Windows.Forms.Button();
            this.btnDebug1 = new System.Windows.Forms.Button();
            this.timerTicker = new System.Windows.Forms.Timer(this.components);
            this.tblLayoutOrganiser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayArea)).BeginInit();
            this.tblSidePanel.SuspendLayout();
            this.gboxInfo.SuspendLayout();
            this.gboxDebug.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayoutOrganiser
            // 
            this.tblLayoutOrganiser.ColumnCount = 2;
            this.tblLayoutOrganiser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.72081F));
            this.tblLayoutOrganiser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1324F));
            this.tblLayoutOrganiser.Controls.Add(this.pbxPlayArea, 1, 0);
            this.tblLayoutOrganiser.Controls.Add(this.tblSidePanel, 0, 0);
            this.tblLayoutOrganiser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutOrganiser.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutOrganiser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tblLayoutOrganiser.Name = "tblLayoutOrganiser";
            this.tblLayoutOrganiser.RowCount = 1;
            this.tblLayoutOrganiser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutOrganiser.Size = new System.Drawing.Size(1478, 858);
            this.tblLayoutOrganiser.TabIndex = 0;
            // 
            // pbxPlayArea
            // 
            this.pbxPlayArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxPlayArea.Location = new System.Drawing.Point(199, 46);
            this.pbxPlayArea.Margin = new System.Windows.Forms.Padding(45, 46, 45, 46);
            this.pbxPlayArea.Name = "pbxPlayArea";
            this.pbxPlayArea.Size = new System.Drawing.Size(1234, 766);
            this.pbxPlayArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxPlayArea.TabIndex = 1;
            this.pbxPlayArea.TabStop = false;
            // 
            // tblSidePanel
            // 
            this.tblSidePanel.ColumnCount = 1;
            this.tblSidePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSidePanel.Controls.Add(this.gboxInfo, 0, 2);
            this.tblSidePanel.Controls.Add(this.gboxDebug, 0, 0);
            this.tblSidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSidePanel.Location = new System.Drawing.Point(4, 5);
            this.tblSidePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tblSidePanel.Name = "tblSidePanel";
            this.tblSidePanel.RowCount = 3;
            this.tblSidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.98082F));
            this.tblSidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.01919F));
            this.tblSidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tblSidePanel.Size = new System.Drawing.Size(146, 848);
            this.tblSidePanel.TabIndex = 2;
            // 
            // gboxInfo
            // 
            this.gboxInfo.BackColor = System.Drawing.SystemColors.Control;
            this.gboxInfo.Controls.Add(this.label3);
            this.gboxInfo.Controls.Add(this.label2);
            this.gboxInfo.Controls.Add(this.label1);
            this.gboxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxInfo.Location = new System.Drawing.Point(4, 646);
            this.gboxInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxInfo.Name = "gboxInfo";
            this.gboxInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxInfo.Size = new System.Drawing.Size(138, 197);
            this.gboxInfo.TabIndex = 0;
            this.gboxInfo.TabStop = false;
            this.gboxInfo.Text = "Info";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(4, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(4, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // gboxDebug
            // 
            this.gboxDebug.Controls.Add(this.btnDebug3);
            this.gboxDebug.Controls.Add(this.btnDebug2);
            this.gboxDebug.Controls.Add(this.btnDebug1);
            this.gboxDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxDebug.Location = new System.Drawing.Point(4, 5);
            this.gboxDebug.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxDebug.Name = "gboxDebug";
            this.gboxDebug.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxDebug.Size = new System.Drawing.Size(138, 143);
            this.gboxDebug.TabIndex = 0;
            this.gboxDebug.TabStop = false;
            this.gboxDebug.Text = "groupBox1";
            // 
            // btnDebug3
            // 
            this.btnDebug3.AutoSize = true;
            this.btnDebug3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDebug3.Location = new System.Drawing.Point(4, 116);
            this.btnDebug3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDebug3.Name = "btnDebug3";
            this.btnDebug3.Size = new System.Drawing.Size(130, 46);
            this.btnDebug3.TabIndex = 2;
            this.btnDebug3.Text = "button3";
            this.btnDebug3.UseVisualStyleBackColor = true;
            // 
            // btnDebug2
            // 
            this.btnDebug2.AutoSize = true;
            this.btnDebug2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDebug2.Location = new System.Drawing.Point(4, 70);
            this.btnDebug2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDebug2.Name = "btnDebug2";
            this.btnDebug2.Size = new System.Drawing.Size(130, 46);
            this.btnDebug2.TabIndex = 1;
            this.btnDebug2.Text = "button2";
            this.btnDebug2.UseVisualStyleBackColor = true;
            this.btnDebug2.Click += new System.EventHandler(this.timerTicker_Tick);
            // 
            // btnDebug1
            // 
            this.btnDebug1.AutoSize = true;
            this.btnDebug1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDebug1.Location = new System.Drawing.Point(4, 24);
            this.btnDebug1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDebug1.Name = "btnDebug1";
            this.btnDebug1.Size = new System.Drawing.Size(130, 46);
            this.btnDebug1.TabIndex = 0;
            this.btnDebug1.Text = "button1";
            this.btnDebug1.UseVisualStyleBackColor = true;
            this.btnDebug1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerTicker
            // 
            this.timerTicker.Enabled = true;
            this.timerTicker.Tick += new System.EventHandler(this.timerTicker_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1478, 858);
            this.Controls.Add(this.tblLayoutOrganiser);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tblLayoutOrganiser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayArea)).EndInit();
            this.tblSidePanel.ResumeLayout(false);
            this.gboxInfo.ResumeLayout(false);
            this.gboxDebug.ResumeLayout(false);
            this.gboxDebug.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutOrganiser;
        private System.Windows.Forms.PictureBox pbxPlayArea;
        private System.Windows.Forms.TableLayoutPanel tblSidePanel;
        private System.Windows.Forms.GroupBox gboxInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboxDebug;
        private System.Windows.Forms.Button btnDebug3;
        private System.Windows.Forms.Button btnDebug2;
        private System.Windows.Forms.Button btnDebug1;
        private System.Windows.Forms.Timer timerTicker;
    }
}


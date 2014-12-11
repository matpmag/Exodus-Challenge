namespace Exodus_Challenge
{
    partial class frmWackamole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWackamole));
            this.pbxMole = new System.Windows.Forms.PictureBox();
            this.moleTicker = new System.Windows.Forms.Timer(this.components);
            this.scoreCount = new System.Windows.Forms.Label();
            this.areaA = new System.Windows.Forms.Panel();
            this.areaB = new System.Windows.Forms.Panel();
            this.areaC = new System.Windows.Forms.Panel();
            this.timeInLevel = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMole)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxMole
            // 
            this.pbxMole.BackColor = System.Drawing.Color.Transparent;
            this.pbxMole.Image = ((System.Drawing.Image)(resources.GetObject("pbxMole.Image")));
            this.pbxMole.Location = new System.Drawing.Point(66, 261);
            this.pbxMole.Name = "pbxMole";
            this.pbxMole.Size = new System.Drawing.Size(110, 100);
            this.pbxMole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMole.TabIndex = 0;
            this.pbxMole.TabStop = false;
            this.pbxMole.Visible = false;
            this.pbxMole.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxMole_MouseDown);
            // 
            // moleTicker
            // 
            this.moleTicker.Enabled = true;
            this.moleTicker.Interval = 1700;
            this.moleTicker.Tick += new System.EventHandler(this.moleTicker_Tick);
            // 
            // scoreCount
            // 
            this.scoreCount.AutoSize = true;
            this.scoreCount.BackColor = System.Drawing.Color.Transparent;
            this.scoreCount.Font = new System.Drawing.Font("Segoe Print", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreCount.Location = new System.Drawing.Point(960, 9);
            this.scoreCount.Name = "scoreCount";
            this.scoreCount.Size = new System.Drawing.Size(52, 61);
            this.scoreCount.TabIndex = 1;
            this.scoreCount.Text = "0";
            // 
            // areaA
            // 
            this.areaA.BackColor = System.Drawing.Color.Transparent;
            this.areaA.Location = new System.Drawing.Point(66, 401);
            this.areaA.Name = "areaA";
            this.areaA.Size = new System.Drawing.Size(865, 226);
            this.areaA.TabIndex = 2;
            // 
            // areaB
            // 
            this.areaB.BackColor = System.Drawing.Color.Transparent;
            this.areaB.Location = new System.Drawing.Point(189, 251);
            this.areaB.Name = "areaB";
            this.areaB.Size = new System.Drawing.Size(552, 150);
            this.areaB.TabIndex = 3;
            // 
            // areaC
            // 
            this.areaC.BackColor = System.Drawing.Color.Transparent;
            this.areaC.Location = new System.Drawing.Point(333, 155);
            this.areaC.Name = "areaC";
            this.areaC.Size = new System.Drawing.Size(283, 100);
            this.areaC.TabIndex = 4;
            // 
            // timeInLevel
            // 
            this.timeInLevel.Enabled = true;
            this.timeInLevel.Interval = 1000;
            this.timeInLevel.Tick += new System.EventHandler(this.timeInLevel_Tick);
            // 
            // frmWackamole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 697);
            this.Controls.Add(this.pbxMole);
            this.Controls.Add(this.areaC);
            this.Controls.Add(this.areaB);
            this.Controls.Add(this.areaA);
            this.Controls.Add(this.scoreCount);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWackamole";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMole;
        private System.Windows.Forms.Timer moleTicker;
        private System.Windows.Forms.Label scoreCount;
        private System.Windows.Forms.Panel areaA;
        private System.Windows.Forms.Panel areaB;
        private System.Windows.Forms.Panel areaC;
        private System.Windows.Forms.Timer timeInLevel;
    }
}
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
            this.pbxMole = new System.Windows.Forms.PictureBox();
            this.moleTicker = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMole)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxMole
            // 
            this.pbxMole.Image = global::Exodus_Challenge.Properties.Resources.avatar;
            this.pbxMole.Location = new System.Drawing.Point(12, 12);
            this.pbxMole.Name = "pbxMole";
            this.pbxMole.Size = new System.Drawing.Size(95, 91);
            this.pbxMole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMole.TabIndex = 0;
            this.pbxMole.TabStop = false;
            this.pbxMole.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxMole_MouseDown);
            // 
            // moleTicker
            // 
            this.moleTicker.Enabled = true;
            this.moleTicker.Interval = 700;
            this.moleTicker.Tick += new System.EventHandler(this.moleTicker_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(966, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 697);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxMole);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMole;
        private System.Windows.Forms.Timer moleTicker;
        private System.Windows.Forms.Label label1;
    }
}
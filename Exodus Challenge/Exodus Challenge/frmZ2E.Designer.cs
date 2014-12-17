namespace Exodus_Challenge
{
    partial class frmZ2E
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
            this.pbxCurrent = new System.Windows.Forms.PictureBox();
            this.pbxNext = new System.Windows.Forms.PictureBox();
            this.inpAns = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNext)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCurrent
            // 
            this.pbxCurrent.Location = new System.Drawing.Point(316, 53);
            this.pbxCurrent.Name = "pbxCurrent";
            this.pbxCurrent.Size = new System.Drawing.Size(328, 221);
            this.pbxCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxCurrent.TabIndex = 0;
            this.pbxCurrent.TabStop = false;
            // 
            // pbxNext
            // 
            this.pbxNext.Location = new System.Drawing.Point(686, 53);
            this.pbxNext.Name = "pbxNext";
            this.pbxNext.Size = new System.Drawing.Size(328, 221);
            this.pbxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxNext.TabIndex = 1;
            this.pbxNext.TabStop = false;
            // 
            // inpAns
            // 
            this.inpAns.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpAns.Location = new System.Drawing.Point(410, 402);
            this.inpAns.MaxLength = 2;
            this.inpAns.Name = "inpAns";
            this.inpAns.Size = new System.Drawing.Size(149, 112);
            this.inpAns.TabIndex = 2;
            this.inpAns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inpAns_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // frmZ2E
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 597);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inpAns);
            this.Controls.Add(this.pbxNext);
            this.Controls.Add(this.pbxCurrent);
            this.Name = "frmZ2E";
            this.Text = "frmZ2E";
            ((System.ComponentModel.ISupportInitialize)(this.pbxCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCurrent;
        private System.Windows.Forms.PictureBox pbxNext;
        private System.Windows.Forms.TextBox inpAns;
        private System.Windows.Forms.Label label1;
    }
}
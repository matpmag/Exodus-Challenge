﻿namespace Exodus_Challenge
{
    partial class frmZ2B
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
            this.pbxCanvas = new System.Windows.Forms.PictureBox();
            this.tickerMovement = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCanvas
            // 
            this.pbxCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxCanvas.BackColor = System.Drawing.Color.Aquamarine;
            this.pbxCanvas.Location = new System.Drawing.Point(34, 38);
            this.pbxCanvas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxCanvas.Name = "pbxCanvas";
            this.pbxCanvas.Size = new System.Drawing.Size(1012, 404);
            this.pbxCanvas.TabIndex = 0;
            this.pbxCanvas.TabStop = false;
            this.pbxCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxCanvas_Paint);
            this.pbxCanvas.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmZ2B_PreviewKeyDown);
            // 
            // tickerMovement
            // 
            this.tickerMovement.Enabled = true;
            this.tickerMovement.Interval = 200;
            this.tickerMovement.Tick += new System.EventHandler(this.tickerMovement_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 1);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.tickerMovement_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // frmZ2B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1077, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbxCanvas);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmZ2B";
            this.Padding = new System.Windows.Forms.Padding(34, 38, 34, 38);
            this.Text = "frmZ2B";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmZ2B_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmZ2B_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCanvas;
        private System.Windows.Forms.Timer tickerMovement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}
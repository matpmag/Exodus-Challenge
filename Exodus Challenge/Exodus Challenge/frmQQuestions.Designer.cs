namespace Exodus_Challenge
{
    partial class frmQQuestions
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
            this.cbox1 = new System.Windows.Forms.ComboBox();
            this.tbar2 = new System.Windows.Forms.TrackBar();
            this.rbtn4a = new System.Windows.Forms.RadioButton();
            this.rbtn4b = new System.Windows.Forms.RadioButton();
            this.rbtn4c = new System.Windows.Forms.RadioButton();
            this.rbtn4d = new System.Windows.Forms.RadioButton();
            this.tbx3 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbar2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbox1
            // 
            this.cbox1.FormattingEnabled = true;
            this.cbox1.Items.AddRange(new object[] {
            "Reuben",
            "Simeon",
            "Levi",
            "Judah",
            "Zebulon",
            "Issachar",
            "Dan",
            "Gad",
            "Asher",
            "Naphtali",
            "Manasseh",
            "Ephraim",
            "Benjamin"});
            this.cbox1.Location = new System.Drawing.Point(306, 74);
            this.cbox1.Name = "cbox1";
            this.cbox1.Size = new System.Drawing.Size(201, 21);
            this.cbox1.TabIndex = 0;
            // 
            // tbar2
            // 
            this.tbar2.Location = new System.Drawing.Point(306, 124);
            this.tbar2.Maximum = 7;
            this.tbar2.Name = "tbar2";
            this.tbar2.Size = new System.Drawing.Size(201, 45);
            this.tbar2.TabIndex = 1;
            // 
            // rbtn4a
            // 
            this.rbtn4a.AutoSize = true;
            this.rbtn4a.Location = new System.Drawing.Point(306, 223);
            this.rbtn4a.Name = "rbtn4a";
            this.rbtn4a.Size = new System.Drawing.Size(85, 17);
            this.rbtn4a.TabIndex = 3;
            this.rbtn4a.TabStop = true;
            this.rbtn4a.Text = "radioButton1";
            this.rbtn4a.UseVisualStyleBackColor = true;
            // 
            // rbtn4b
            // 
            this.rbtn4b.AutoSize = true;
            this.rbtn4b.Location = new System.Drawing.Point(306, 246);
            this.rbtn4b.Name = "rbtn4b";
            this.rbtn4b.Size = new System.Drawing.Size(85, 17);
            this.rbtn4b.TabIndex = 4;
            this.rbtn4b.TabStop = true;
            this.rbtn4b.Text = "radioButton2";
            this.rbtn4b.UseVisualStyleBackColor = true;
            // 
            // rbtn4c
            // 
            this.rbtn4c.AutoSize = true;
            this.rbtn4c.Location = new System.Drawing.Point(306, 269);
            this.rbtn4c.Name = "rbtn4c";
            this.rbtn4c.Size = new System.Drawing.Size(85, 17);
            this.rbtn4c.TabIndex = 5;
            this.rbtn4c.TabStop = true;
            this.rbtn4c.Text = "radioButton3";
            this.rbtn4c.UseVisualStyleBackColor = true;
            // 
            // rbtn4d
            // 
            this.rbtn4d.AutoSize = true;
            this.rbtn4d.Location = new System.Drawing.Point(306, 292);
            this.rbtn4d.Name = "rbtn4d";
            this.rbtn4d.Size = new System.Drawing.Size(85, 17);
            this.rbtn4d.TabIndex = 6;
            this.rbtn4d.TabStop = true;
            this.rbtn4d.Text = "radioButton4";
            this.rbtn4d.UseVisualStyleBackColor = true;
            // 
            // tbx3
            // 
            this.tbx3.Location = new System.Drawing.Point(306, 197);
            this.tbx3.Name = "tbx3";
            this.tbx3.Size = new System.Drawing.Size(100, 20);
            this.tbx3.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmit.Location = new System.Drawing.Point(0, 441);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(519, 49);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(432, 12);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmQQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Exodus_Challenge.Properties.Resources.hieroglyph;
            this.ClientSize = new System.Drawing.Size(519, 490);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbx3);
            this.Controls.Add(this.rbtn4d);
            this.Controls.Add(this.rbtn4c);
            this.Controls.Add(this.rbtn4b);
            this.Controls.Add(this.rbtn4a);
            this.Controls.Add(this.tbar2);
            this.Controls.Add(this.cbox1);
            this.Name = "frmQQuestions";
            this.Text = "frmQQuestions";
            ((System.ComponentModel.ISupportInitialize)(this.tbar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox1;
        private System.Windows.Forms.TrackBar tbar2;
        private System.Windows.Forms.RadioButton rbtn4a;
        private System.Windows.Forms.RadioButton rbtn4b;
        private System.Windows.Forms.RadioButton rbtn4c;
        private System.Windows.Forms.RadioButton rbtn4d;
        private System.Windows.Forms.TextBox tbx3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnQuit;
    }
}
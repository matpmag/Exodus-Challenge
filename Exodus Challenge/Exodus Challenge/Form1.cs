using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exodus_Challenge
{
    public partial class Form1 : Form
    {
        int count = 0;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            
        }
        


        private void moleTicker_Tick(object sender, EventArgs e)
        {
            int maxLeft = this.Width - pbxMole.Width - 20;
            int maxTop = this.Height - pbxMole.Height - 20;
            pbxMole.Left = random.Next(20, maxLeft);
            pbxMole.Top = random.Next(20, maxTop);
        }

        private void pbxMole_Click(object sender, EventArgs e) // redundant
        {
            count++;
            label1.Text = count.ToString();
        }

        private void pbxMole_MouseDown(object sender, MouseEventArgs e)
        {
            count+=10;
            label1.Text = count.ToString();
        }
    }
}

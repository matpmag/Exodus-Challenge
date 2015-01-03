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
    public partial class frmZ4B : Form
    {
        public frmZ4B()
        {
            InitializeComponent();
            timer1.Enabled = true;
            KeyPreview = true;
            timer1.Start();
        }
        
        Random random = new Random();

        public int Total = 0;
        public int Missed = 0;
        public int Correct = 0;
        public int Accuracy = 0;

        public void Update(bool correctKey)
        {
            Total++;

            if (!correctKey)
            {
                Missed++;
            }
            else
            {
                Correct++;
            }

            Accuracy = 100 * Correct / (Missed + Correct);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lboxPlayArea.Items.Add((Keys)random.Next(65, 90));
            if (lboxPlayArea.Items.Count > 7)
            {
                lboxPlayArea.Items.Clear();
                lboxPlayArea.Items.Add("Game Over");
                timer1.Stop();
            }
            
            pbxGiant.Left += 30;
        }

        private void frmZ4B_KeyDown(object sender, KeyEventArgs e)
        {
            if (lboxPlayArea.Items.Contains(e.KeyCode))
            {
                lboxPlayArea.Items.Remove(e.KeyCode);
                lboxPlayArea.Refresh();
                if (timer1.Interval > 400)
                    timer1.Interval -= 10;
                if (timer1.Interval > 250)
                    timer1.Interval -= 7;
                if (timer1.Interval > 100)
                    timer1.Interval -= 2;
                Update(true);
                pbxGiant.Left -= 30;
            }
            else
                Update(false);
        }

        private void timerBK_Tick(object sender, EventArgs e)
        {
            bk1.Image = bk2.Image;
            bk2.Image = bk3.Image;
            bk3.Image = bk4.Image;
            bk4.Image = bk5.Image;
            bk5.Image = bk1.Image;
        }
    }
}

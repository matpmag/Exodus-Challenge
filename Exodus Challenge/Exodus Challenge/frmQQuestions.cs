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
    public partial class frmQQuestions : Form
    {
        int timeRemaining = 10;
        public frmQQuestions()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbox1.Text == "Judah" &&
                tbar2.Value == 5 &&
                tbx3.Text == "Jochebed" &&
                rbtn4a.Checked)
            {
                MessageBox.Show("Congratulations!");
                loginSystem.user.scoreManna += 10 * timeRemaining;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form lvl = new LevelSelect();
            lvl.Show();
        }
    }
}

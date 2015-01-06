using System;
using System.Windows.Forms;
using Exodus_Challenge.LoginSystem;

namespace Exodus_Challenge
{
    public partial class frmZ1H : Form
    {
        private int timeRemaining = 10;

        public frmZ1H()
        {
            InitializeComponent();
        }

        private void btnQuit_Click( object sender, EventArgs e )
        {
            this.Close();
            Form lvl = new LevelSelect();
            lvl.Show();
        }

        private void btnSubmit_Click( object sender, EventArgs e )
        {
            if ( cbox1.Text == "Judah" &&
                tbar2.Value == 5 &&
                tbx3.Text == "Jochebed" &&
                rbtn4a.Checked )
            {
                MessageBox.Show( "Congratulations!" );
                UserDatabaseAccess.user.userScoreManna += 10 * timeRemaining;
            }
        }

        private void tbar2_Scroll( object sender, EventArgs e )
        {
            label5.Text = tbar2.Value.ToString();
        }
    }
}
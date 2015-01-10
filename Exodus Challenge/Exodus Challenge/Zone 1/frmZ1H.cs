using System;
using System.Windows.Forms;
using Exodus_Challenge.LoginSystem;

namespace Exodus_Challenge
{
    public partial class frmZ1H : Form
    {
        internal int timeRemaining;
        private int scoreMultiplier = 50;
        public frmZ1H()
        {
            InitializeComponent();
            timeRemaining = verticalProgressBar1.Value;
        }


        private void btnQuit_Click( object sender, EventArgs e )
        {
            this.Close();
            Form lvl = new LevelSelect();
            lvl.Show();
        }

        private void btnSubmit_Click( object sender, EventArgs e )
        {
            if ( correct() )
            {
                MessageBox.Show( "Congratulations!" );
                UserDatabaseAccess.user.userScoreManna += 10 * timeRemaining;
            }
        }

        private bool correct()
        {
            if ( cboxQ1.Text != "Judah" )
                return false;
            if ( tbarQ2.Value != 7 )
                return false;
            if ( tbxQ3.Text.ToLower() != "jochebed" )
                return false;
            if ( !rbtnQ4c.Checked )
                return false;
            return true;

        }

        private void tbarQ2_Scroll( object sender, EventArgs e )
        {
            label5.Text = tbarQ2.Value.ToString();
        }

        private void whatDoIDoToolStripMenuItem_Click( object sender, EventArgs e )
        {
            //TODO: help form display
        }

        private void whereDoIFindTheAnswersToolStripMenuItem_Click( object sender, EventArgs e )
        {
            //TODO: Bible pointers for level
        }

        private void retryToolStripMenuItem_Click( object sender, EventArgs e )
        {
            
        }

        private void timerScoreDecrement_Tick( object sender, EventArgs e )
        {
            timeRemaining--;
            updateScoreMultiplier();
        }

        private void updateScoreMultiplier()
        {
            //verticalProgressBar1.Value = timeRemaining;
            //TODO: find why 1199/1200 = 0.0
            double proportionOfTimeRemaining = timeRemaining/1200;
            MessageBox.Show( proportionOfTimeRemaining.ToString() );
            if ( proportionOfTimeRemaining >= 0.9 )
            {
                scoreMultiplier = 50;
            }
            else if ( proportionOfTimeRemaining >= 0.75 )
            {
                scoreMultiplier = 25;
            }
            else if ( proportionOfTimeRemaining >= 0.5 )
            {
                scoreMultiplier = 10;
            }
            else if ( proportionOfTimeRemaining >= 0.25 )
            {
                scoreMultiplier = 5;
            }
            else if ( proportionOfTimeRemaining >= 0.1 )
            {
                scoreMultiplier = 2;
            }
            else
            {
                scoreMultiplier = 1;
            }
            lblScoreMultiplier.Text = scoreMultiplier.ToString();
        }
    }
}
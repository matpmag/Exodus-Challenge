using System;
using System.Windows.Forms;
using Exodus_Challenge.LoginSystem;
using Exodus_Challenge.CustomControls;

namespace Exodus_Challenge
{
    public partial class frmZ2M : Form
    {
        internal int timeRemaining;
        private int scoreMultiplier = 50;
        string q1Text = "What did Pharaoh command the taskmasters when Moses first requested him to let Israel go?";
        string q2Text = "How old was Moses when he spoke to Pharaoh?";
        string q3Text = "How did God make a difference between the Israelites and the Egyptians?";
        string q4Text = "How many years did the children of Israel live in Egypt?";
        public frmZ2M()
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
            if ( tabControl1.SelectedIndex != tabControl1.TabCount )
            {
                int i = tabControl1.SelectedIndex;
                tabControl1.SelectedIndex = i + 1;
            }
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
            if ( verticalProgressBar1.Value != 7 )
                return false;
            //if ( tbxQ3.Text.ToLower() != "jochebed" )
            //    return false;
            //if ( !rbtnQ4c.Checked )
            //    return false;
            return true;

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
            if ( timeRemaining >= 0 )
            {
                updateScoreMultiplier();
            }
        }
        double proportionOfTimeRemaining;
        private void updateScoreMultiplier()
        {
            verticalProgressBar1.Value = timeRemaining;
            proportionOfTimeRemaining = ( verticalProgressBar1.Value / (double)1200 );
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
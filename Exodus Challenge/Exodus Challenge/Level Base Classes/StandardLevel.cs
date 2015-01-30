using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exodus_Challenge.LoginSystem;
using Exodus_Challenge.CustomControls;
using System.Windows.Forms;

namespace Exodus_Challenge
{
    public class StandardLevel : Level
    {
        internal int timeRemaining;
        internal int scoreMultiplier = 50;
        double proportionOfTimeRemaining;

        internal string[] qText;
        internal string[] qAns;
        internal string[] qInput;
        internal int points = 0;

        internal TabControl tabControlRef;
        internal Label lblQTextRef;
        internal Label lblScoreMultiplierRef;
        internal VerticalProgressBar verticalProgressBarRef;

        internal void submitAns()
        {
            if ( tabControlRef.SelectedIndex < tabControlRef.TabCount - 1 )
            {
                if ( correct() )
                {
                    this.points++;
                }
                int i = tabControlRef.SelectedIndex;
                tabControlRef.SelectedIndex = i + 1;
                lblQTextRef.Text = qText[tabControlRef.SelectedIndex];                    
            }
            else
            {
                returnToMap();
                UserDatabaseAccess.user.userScoreManna += 10 * timeRemaining;
            }
        }

        private bool correct()
        {
            return ( qInput[tabControlRef.SelectedIndex] == qAns[tabControlRef.SelectedIndex] ) ? true : false;
        }

        private void updateScoreMultiplier()
        {
            verticalProgressBarRef.Value = timeRemaining;
            proportionOfTimeRemaining = ( verticalProgressBarRef.Value / (double)1200 );
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
            lblScoreMultiplierRef.Text = scoreMultiplier.ToString();
        }

        internal void decrementScore()
        {
            timeRemaining--;
            if ( timeRemaining >= 0 )
            {
                updateScoreMultiplier();
            }
        }
    }
}

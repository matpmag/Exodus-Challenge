using System;
using System.Windows.Forms;
using Exodus_Challenge.LoginSystem;
using Exodus_Challenge.CustomControls;

namespace Exodus_Challenge
{
    public partial class frmZ3M : StandardLevel
    {
        public frmZ3M()
        {
            InitializeComponent();
            setupReferences();
            setupAns();
        }

        internal void setupReferences()
        {
            tabControlRef = tabControl1;
            lblQTextRef = lblQText;
            timeRemaining = verticalProgressBar1.Value;
            lblScoreMultiplierRef = lblScoreMultiplier;
            verticalProgressBarRef = verticalProgressBar1;
        }

        internal void setupAns()
        {
            qText = new string[]
            {
                "What did Pharaoh command the taskmasters when Moses first requested him to let Israel go?",
                "How old was Moses when he spoke to Pharaoh?",
                "How did God make a difference between the Israelites and the Egyptians?",
                "How many years did the children of Israel live in Egypt?"
            };
            
            qAns = new string[]
            {
                "Take away their straw for making bricks",
                "80",
                "All of the above",
                "430"
            };

            qInput = new string[]
            {
               cboxQ1.Text,
               nudQ2.Value.ToString(),
               cboxQ3.Text,
               nudQ4.Value.ToString()
            };
        }


        private void btnQuit_Click( object sender, EventArgs e )
        {
            returnToMap();
        }

        private void btnSubmit_Click( object sender, EventArgs e )
        {
            submitAns();
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
            thisLevel = new frmZ2M();
            retry();
        }

        private void timerScoreDecrement_Tick( object sender, EventArgs e )
        {
            decrementScore();
        }
        
    }
}
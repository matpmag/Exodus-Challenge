using System;
using System.Windows.Forms;
using Exodus_Challenge.LoginSystem;

namespace Exodus_Challenge
{
    public partial class LevelSelect : Form
    {
        #region Private Fields

        private difficulty? diff = UserDatabaseAccess.user.userDifficulty;

        #endregion Private Fields

        #region Private Methods

        private void updateLabels()
        {
            lblMannaScore.Text = UserDatabaseAccess.user.userScoreManna.ToString();
            lblQuailScore.Text = UserDatabaseAccess.user.userScoreQuail.ToString();
        }

        #endregion Private Methods

        #region Public Constructors

        public LevelSelect()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        private void btnlvlG1_Click(object sender, System.EventArgs e)
        {
            if (UserDatabaseAccess.user.userScoreManna <= 50)
                MessageBox.Show("You must have 50+ manna");
            else
            {
                this.Close();
                Form frmGame1 = new frmZ1B();
                frmGame1.Show();
            }
        }

        private void btnlvlG2_Click(object sender, System.EventArgs e)
        {
            if (UserDatabaseAccess.user.userScoreManna <= 50)
                MessageBox.Show("You must have 50+ manna");
            else
            {
                this.Close();
                Form frmGame2 = new frmZ2B();
                frmGame2.Show();
            }
        }

        private void btnlvlG3_Click(object sender, System.EventArgs e)
        {
            if (UserDatabaseAccess.user.userScoreManna <= 50)
                MessageBox.Show("You must have 50+ manna");
            else
            {
                this.Close();
                Form frmGame3 = new frmZ3B();
                frmGame3.Show();
            }
        }

        private void btnlvlG4_Click(object sender, System.EventArgs e)
        {
            if (UserDatabaseAccess.user.userScoreManna <= 50)
                MessageBox.Show("You must have 50+ manna");
            else
            {
                this.Close();
                Form frmGame4 = new frmZ4B();
                frmGame4.Show();
            }
        }


        private void btnlvlQ1_Click(object sender, System.EventArgs e)
        {
        }

        private void btnlvlQ2_Click(object sender, System.EventArgs e)
        {

        }

        private void btnlvlQ3_Click(object sender, System.EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            AccountMainControls.Save();
            MessageBox.Show("Saved!");
        }

        private void btnSettingCheatsLevel_Click(object sender, System.EventArgs e)
        {
            //hiddenLevels = null;
        }

        private void btnSettingCheatsManna_Click(object sender, System.EventArgs e)
        {
            UserDatabaseAccess.user.userScoreManna += 99999;
            updateLabels();
        }

        private void btnSettingCheatsQuail_Click(object sender, System.EventArgs e)
        {
            UserDatabaseAccess.user.userScoreQuail += 99999;
            updateLabels();
        }

        private void btnSettingDifficultyEasy_Click(object sender, System.EventArgs e)
        {
            diff = difficulty.novice;
        }

        private void btnSettingDifficultyHard_Click(object sender, System.EventArgs e)
        {
            diff = difficulty.master;
        }

        private void btnSettingDifficultyMedium_Click(object sender, System.EventArgs e)
        {
            diff = difficulty.apprentice;
        }

        private void LevelSelect_Load(object sender, System.EventArgs e)
        {
            lblMannaScore.Text = UserDatabaseAccess.user.userScoreManna.ToString();
            lblQuailScore.Text = UserDatabaseAccess.user.userScoreQuail.ToString();
        }

        private void logOutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Restart();
        }

        private void btnSettings_Click(object sender, System.EventArgs e)
        {
            tabControl.SelectedTab = tabSettings;
        }

        private void btnSettingDifficultyActivate_Click(object sender, System.EventArgs e)
        {
            if (btnSettingDifficultyEasy.Visible == false)
            {
                btnSettingDifficultyEasy.Visible = true;
                btnSettingDifficultyMedium.Visible = true;
                btnSettingDifficultyHard.Visible = true;
            }
            else
            {
                btnSettingDifficultyEasy.Visible = false;
                btnSettingDifficultyMedium.Visible = false;
                btnSettingDifficultyHard.Visible = false;
            }
        }

        private void btnSettingAccountActivate_Click(object sender, System.EventArgs e)
        {

        }

        private void btnSettingCheatsActivate_Click(object sender, System.EventArgs e)
        {
            bool boolWantsToCheat = false;
            if (!UserDatabaseAccess.user.userIsCheater)
            {
                DialogResult dialogResult = MessageBox.Show("Enabling this option will prevent your scores from being" +
                                " saved or added to the leaderboards, are you sure you wish to accept?", "Enabling Cheats",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.Yes)
                    boolWantsToCheat = true;
            }
            if (boolWantsToCheat || UserDatabaseAccess.user.userIsCheater)
            {
                UserDatabaseAccess.user.userIsCheater = true;

                if (btnSettingConsoleActivate.Visible == false)
                {
                    btnSettingCheatsLevel.Visible = true;
                    btnSettingCheatsManna.Visible = true;
                    btnSettingCheatsQuail.Visible = true;
                    btnSettingConsoleActivate.Visible = true;
                }
                else
                {
                    btnSettingCheatsLevel.Visible = false;
                    btnSettingCheatsManna.Visible = false;
                    btnSettingCheatsQuail.Visible = false;
                    btnSettingConsoleActivate.Visible = false;
                }
            }
        }

        private void btnSettingConsoleActivate_Click(object sender, System.EventArgs e)
        {

        }

        private void btnZ1QA_Click( object sender, System.EventArgs e )
        {
            Form Z1A;
            try
            {
                switch ( diff )
                {
                    case difficulty.novice:
                        this.Close();
                        Z1A = new frmZ1E();
                        break;

                    case difficulty.apprentice:
                        this.Close();
                        Z1A = new frmZ1M();
                        break;

                    case difficulty.master:
                        this.Close();
                        Z1A = new frmZ1H();
                        break;

                    default:
                        throw new ArgumentException( "difficulty \"diff\" is invalid" );
                }
                Z1A.Show();
            }
            catch ( Exception ex )
            {
                string message = String.Format( "e.ToString(): {0}\ne.GetType().ToString(): {1} ex.ToString(): {2}, ex.GetType().ToString(): {3}, ex.Message: {4}", e.ToString(), e.GetType().ToString(), ex.ToString(), ex.GetType().ToString(), ex.Message );
                MessageBox.Show( message );
            }
        }

        private void btnZ1QB_Click( object sender, System.EventArgs e )
        {
            Form Z1B;
            try
            {
                switch ( diff )
                {
                    case difficulty.novice:
                        this.Close();
                        Z1B = new frmZ1M();
                        break;

                    case difficulty.apprentice:
                        this.Close();
                        Z1B = new frmZ1H();
                        break;

                    case difficulty.master:
                        //this.Close();
                        //TODO: MAKE frmZ1X
                        //Z1B = new frmZ1X();
                        throw new NotImplementedException( "You Haven't Implemented Z1X yet" );

                    default:
                        throw new ArgumentException( "difficulty \"diff\" is invalid" );
                }
                Z1B.Show();
            }
            catch ( Exception ex)
            {
                string message = String.Format( "e.ToString(): {0}\ne.GetType().ToString(): {1} ex.ToString(): {2}, ex.GetType().ToString(): {3}, ex.Message: {4}", e.ToString(), e.GetType().ToString(), ex.ToString(), ex.GetType().ToString(), ex.Message );
                MessageBox.Show(message);
            }
        }

        private void btnZ2QA_Click( object sender, System.EventArgs e )
        {
            Form Z2A;
            try
            {
                switch ( diff )
                {
                    case difficulty.novice:
                        this.Close();
                        Z2A = new frmZ2E();
                        break;

                    case difficulty.apprentice:
                        //this.Close();
                        //TODO: MAKE frmZ2M
                        //Z2A = new frmZ2M();
                        throw new NotImplementedException( "You Haven't Implemented Z2M yet" );

                    case difficulty.master:
                        //this.Close();
                        //TODO: MAKE frmZ2H
                        //Z2A = new frmZ2H();
                        throw new NotImplementedException( "You Haven't Implemented Z2H yet" );

                    default:
                        throw new ArgumentException( "difficulty \"diff\" is invalid" );
                }
                Z2A.Show();
            }
            catch ( Exception ex )
            {
                string message = String.Format( "e.ToString(): {0}\ne.GetType().ToString(): {1} ex.ToString(): {2}, ex.GetType().ToString(): {3}, ex.Message: {4}", e.ToString(), e.GetType().ToString(), ex.ToString(), ex.GetType().ToString(), ex.Message );
                MessageBox.Show( message );
            }
        }

        private void btnZ2QB_Click( object sender, System.EventArgs e )
        {
            Form Z2B;
            try
            {
                switch ( diff )
                {
                    case difficulty.novice:
                        //this.Close();
                        //TODO: MAKE frmZ2M
                        //Z2B = new frmZ2M();
                        throw new NotImplementedException( "You Haven't Implemented Z2M yet" );

                    case difficulty.apprentice:
                        //this.Close();
                        //TODO: MAKE frmZ2H
                        //Z2B = new frmZ2H();
                        throw new NotImplementedException( "You Haven't Implemented Z2H yet" );

                    case difficulty.master:
                        //this.Close();
                        //TODO: MAKE frmZ2X
                        //Z2B = new frmZ2X();
                        throw new NotImplementedException( "You Haven't Implemented Z2X yet" );

                    default:
                        throw new ArgumentException( "difficulty \"diff\" is invalid" );
                }
                Z2B.Show();
            }
            catch ( Exception ex )
            {
                string message = String.Format( "e.ToString(): {0}\ne.GetType().ToString(): {1} ex.ToString(): {2}, ex.GetType().ToString(): {3}, ex.Message: {4}", e.ToString(), e.GetType().ToString(), ex.ToString(), ex.GetType().ToString(), ex.Message );
                MessageBox.Show( message );
            }
        }

        private void btnZ3QA_Click( object sender, System.EventArgs e )
        {
            Form Z3A;
            try
            {
                switch ( diff )
                {
                    case difficulty.novice:
                        this.Close();
                        Z3A = new frmZ3E();
                        break;

                    case difficulty.apprentice:
                        //this.Close();
                        //TODO: MAKE frmZ3M
                        //Z3A = new frmZ3M();
                        throw new NotImplementedException( "You Haven't Implemented Z3M yet" );

                    case difficulty.master:
                        //this.Close();
                        //TODO: MAKE frmZ3H
                        //Z3A = new frmZ3H();
                        throw new NotImplementedException( "You Haven't Implemented Z3H yet" );

                    default:
                        throw new ArgumentException( "difficulty \"diff\" is invalid" );
                }
                Z3A.Show();
            }
            catch ( Exception ex )
            {
                string message = String.Format( "e.ToString(): {0}\ne.GetType().ToString(): {1} ex.ToString(): {2}, ex.GetType().ToString(): {3}, ex.Message: {4}", e.ToString(), e.GetType().ToString(), ex.ToString(), ex.GetType().ToString(), ex.Message );
                MessageBox.Show( message );
            }
        }

        private void btnZ3QB_Click( object sender, System.EventArgs e )
        {
            Form Z3B;
            try
            {
                switch ( diff )
                {
                    case difficulty.novice:
                        //this.Close();
                        //TODO: MAKE frmZ3M
                        //Z3B = new frmZ3M();
                        throw new NotImplementedException( "You Haven't Implemented Z3M yet" );

                    case difficulty.apprentice:
                        //this.Close();
                        //TODO: MAKE frmZ3H
                        //Z3B = new frmZ3H();
                        throw new NotImplementedException( "You Haven't Implemented Z3H yet" );

                    case difficulty.master:
                        //this.Close();
                        //TODO: MAKE frmZ3X
                        //Z3B = new frmZ3X();
                        throw new NotImplementedException( "You Haven't Implemented Z3X yet" );

                    default:
                        throw new ArgumentException( "difficulty \"diff\" is invalid" );
                }
                Z3B.Show();
            }
            catch ( Exception ex )
            {
                string message = String.Format( "e.ToString(): {0}\ne.GetType().ToString(): {1} ex.ToString(): {2}, ex.GetType().ToString(): {3}, ex.Message: {4}", e.ToString(), e.GetType().ToString(), ex.ToString(), ex.GetType().ToString(), ex.Message );
                MessageBox.Show( message );
            }
        }

        private void btnZ4QA_Click( object sender, System.EventArgs e )
        {
            Form Z4A;
            try
            {
                switch ( diff )
                {
                    case difficulty.novice:
                        //this.Close();
                        //TODO: MAKE frmZ4E
                        //Z4A = new frmZ4E();
                        throw new NotImplementedException( "You Haven't Implemented Z4E yet" );

                    case difficulty.apprentice:
                        //this.Close();
                        //TODO: MAKE frmZ4M
                        //Z4A = new frmZ4M();
                        throw new NotImplementedException( "You Haven't Implemented Z4M yet" );

                    case difficulty.master:
                        //this.Close();
                        //TODO: MAKE frmZ4H
                        //Z4A = new frmZ4H();
                        throw new NotImplementedException( "You Haven't Implemented Z4H yet" );

                    default:
                        throw new ArgumentException( "difficulty \"diff\" is invalid" );
                }
                Z4A.Show();
            }
            catch ( Exception ex )
            {
                string message = String.Format( "e.ToString(): {0}\ne.GetType().ToString(): {1} ex.ToString(): {2}, ex.GetType().ToString(): {3}, ex.Message: {4}", e.ToString(), e.GetType().ToString(), ex.ToString(), ex.GetType().ToString(), ex.Message );
                MessageBox.Show( message );
            }
        }

        private void btnZ4QB_Click( object sender, System.EventArgs e )
        {
            Form Z4B;
            try
            {
                switch ( diff )
                {
                    case difficulty.novice:
                        //this.Close();
                        //TODO: MAKE frmZ4M
                        //Z4B = new frmZ4M();
                        throw new NotImplementedException( "You Haven't Implemented Z4M yet" );

                    case difficulty.apprentice:
                        //this.Close();
                        //TODO: MAKE frmZ4H
                        //Z4B = new frmZ4H();
                        throw new NotImplementedException( "You Haven't Implemented Z4H yet" );

                    case difficulty.master:
                        //this.Close();
                        //TODO: MAKE frmZ4X
                        //Z4B = new frmZ4X();
                        throw new NotImplementedException( "You Haven't Implemented Z4X yet" );

                    default:
                        throw new ArgumentException( "difficulty \"diff\" is invalid" );
                }
                Z4B.Show();
            }
            catch ( Exception ex )
            {
                string message = String.Format( "e.ToString(): {0}\ne.GetType().ToString(): {1} ex.ToString(): {2}, ex.GetType().ToString(): {3}, ex.Message: {4}", e.ToString(), e.GetType().ToString(), ex.ToString(), ex.GetType().ToString(), ex.Message );
                MessageBox.Show( message );
            }
        }
    }
}
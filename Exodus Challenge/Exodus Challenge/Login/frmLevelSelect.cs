using System;
using System.Windows.Forms;
using Exodus_Challenge.LoginSystem;

namespace Exodus_Challenge
{
    public partial class frmLevelSelect : Form
    {
        private void btnZ1QA_Click( object sender, System.EventArgs e )
        {
            Form Z1A;
            try
            {
                switch ( UserDatabaseAccess.user.userDifficulty )
                {
                    case difficulty.novice:
                        this.Close();
                        Z1A = new frmZ1E();
                        break;

                    case difficulty.apprentice:
                        this.Close();
                        Z1A = new frmZ1E();
                        break;

                    case difficulty.master:
                        this.Close();
                        Z1A = new frmZ1M();
                        break;

                    default:
                        throw new ArgumentException( "difficulty \"diff\" is invalid" );
                }
                Z1A.Show();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void btnZ1QB_Click( object sender, System.EventArgs e )
        {
            Form Z1B;
            try
            {
                switch ( UserDatabaseAccess.user.userDifficulty )
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
                        this.Close();
                        Z1B = new frmZ1H();
                        break;

                    default:
                        throw new ArgumentException( "difficulty \"diff\" is invalid" );
                }
                Z1B.Show();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void btnZ2QA_Click( object sender, System.EventArgs e )
        {
            Form Z2A;
            try
            {
                switch ( UserDatabaseAccess.user.userDifficulty )
                {
                    case difficulty.novice:
                        this.Close();
                        Z2A = new frmZ2E();
                        break;

                    case difficulty.apprentice:
                        this.Close();
                        Z2A = new frmZ2E();
                        break;

                    case difficulty.master:
                        this.Close();
                        Z2A = new frmZ2M();
                        break;

                    default:
                        throw new ArgumentException( "difficulty \"diff\" is invalid" );
                }
                Z2A.Show();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void btnZ2QB_Click( object sender, System.EventArgs e )
        {
            Form Z2B;
            try
            {
                switch ( UserDatabaseAccess.user.userDifficulty )
                {
                    case difficulty.novice:
                        this.Close();
                        Z2B = new frmZ2M();
                        break;

                    case difficulty.apprentice:
                        this.Close();
                        Z2B = new frmZ2H();
                        break;

                    case difficulty.master:
                        this.Close();
                        Z2B = new frmZ2H();
                        break;

                    default:
                        throw new ArgumentException( "difficulty \"diff\" is invalid" );
                }
                Z2B.Show();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void btnZ3QA_Click( object sender, System.EventArgs e )
        {
            Form Z3A;
            try
            {
                switch ( UserDatabaseAccess.user.userDifficulty )
                {
                    case difficulty.novice:
                        this.Close();
                        Z3A = new frmZ3E();
                        break;

                    case difficulty.apprentice:
                        this.Close();
                        Z3A = new frmZ3E();
                        break;

                    case difficulty.master:
                        this.Close();
                        Z3A = new frmZ3M();
                        break;

                    default:
                        throw new ArgumentException( "difficulty \"diff\" is invalid" );
                }
                Z3A.Show();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void btnZ3QB_Click( object sender, System.EventArgs e )
        {
            Form Z3B;
            try
            {
                switch ( UserDatabaseAccess.user.userDifficulty )
                {
                    case difficulty.novice:
                        this.Close();
                        Z3B = new frmZ3M();
                        break;

                    case difficulty.apprentice:
                        this.Close();
                        Z3B = new frmZ3M();
                        break;

                    case difficulty.master:
                        this.Close();
                        Z3B = new frmZ3H();
                        break;

                    default:
                        throw new ArgumentException( "difficulty \"diff\" is invalid" );
                }
                Z3B.Show();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void btnZ4QA_Click( object sender, System.EventArgs e )
        {
            Form Z4A;
            try
            {
                switch ( UserDatabaseAccess.user.userDifficulty )
                {
                    case difficulty.novice:
                        this.Close();
                        Z4A = new frmZ4E();
                        break;

                    case difficulty.apprentice:
                        this.Close();
                        Z4A = new frmZ4E();
                        break;

                    case difficulty.master:
                        this.Close();
                        Z4A = new frmZ4M();
                        break;

                    default:
                        throw new ArgumentException( "difficulty \"diff\" is invalid" );
                }
                Z4A.Show();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void btnZ4QB_Click( object sender, System.EventArgs e )
        {
            Form Z4B;
            try
            {
                switch ( UserDatabaseAccess.user.userDifficulty )
                {
                    case difficulty.novice:
                        this.Close();
                        Z4B = new frmZ4M();
                        break;

                    case difficulty.apprentice:
                        this.Close();
                        Z4B = new frmZ4H();
                        break;

                    case difficulty.master:
                        this.Close();
                        Z4B = new frmZ4H();
                        break;

                    default:
                        throw new ArgumentException( "difficulty \"diff\" is invalid" );
                }
                Z4B.Show();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void LevelSelect_Load( object sender, System.EventArgs e )
        {
            lblMannaScore.Text = UserDatabaseAccess.user.userScoreManna.ToString();
            lblQuailScore.Text = UserDatabaseAccess.user.userScoreQuail.ToString();
        }

        private void logOutToolStripMenuItem_Click( object sender, System.EventArgs e )
        {
            Application.Restart();
        }

        private void UnlockLevels()
        {
            Button[] levels = new Button[]
            {
                btnZ1QA,
                btnZ1QB,
                btnlvlG1,
                btnZ2QA,
                btnZ2QB,
                btnlvlG2,
                btnZ3QA,
                btnZ3QB,
                btnlvlG3,
                btnZ4QA,
                btnZ4QB,
                btnlvlG4
            };
            foreach ( Button btn in levels )
            {
                btn.Visible = false;
            }
            if ( UserDatabaseAccess.user.userZoneUnlock == 0 )
            {
                btnWatch1.Visible = true;
            }
            if ( UserDatabaseAccess.user.userZoneUnlock > 0 )
            {
                btnWatch1.Visible = false;
                levels[0].Visible = true;
                levels[1].Visible = true;
                levels[2].Visible = true;
                btnWatch2.Visible = true;
            }
            if ( UserDatabaseAccess.user.userZoneUnlock > 1 )
            {
                btnWatch2.Visible = false;
                levels[3].Visible = true;
                levels[4].Visible = true;
                levels[5].Visible = true;
                btnWatch3.Visible = true;
            }
            if ( UserDatabaseAccess.user.userZoneUnlock > 2 )
            {
                btnWatch3.Visible = false;
                levels[6].Visible = true;
                levels[7].Visible = true;
                levels[8].Visible = true;
                btnWatch4.Visible = true;
            }
            if ( UserDatabaseAccess.user.userZoneUnlock > 3 )
            {
                btnWatch4.Visible = false;
                levels[9].Visible = true;
                levels[10].Visible = true;
                levels[11].Visible = true;
                btnWatch5.Visible = true;
            }
        }

        private void updateLabels()
        {
            lblMannaScore.Text = UserDatabaseAccess.user.userScoreManna.ToString();
            lblQuailScore.Text = UserDatabaseAccess.user.userScoreQuail.ToString();
        }

        private string cutscene1 = @"\Media\Video\cutscene1.mp4";

        private string cutscene2 = @"\Media\Video\cutscene2.mp4";

        private string cutscene3 = @"\Media\Video\cutscene3.mp4";

        private string cutscene4 = @"\Media\Video\cutscene4.mp4";

        private string cutscene5 = @"\Media\Video\cutscene5.mp4";

        public frmLevelSelect()
        {
            InitializeComponent();
            UnlockLevels();
        }

        private void btnlvlG1_Click( object sender, System.EventArgs e )
        {
            if ( UserDatabaseAccess.user.userScoreManna <= 50 )
                MessageBox.Show( "You must have 50+ manna" );
            else
            {
                this.Close();
                Form frmGame1 = new frmZ1B();
                frmGame1.Show();
            }
        }

        private void btnlvlG2_Click( object sender, System.EventArgs e )
        {
            if ( UserDatabaseAccess.user.userScoreManna <= 100 )
                MessageBox.Show( "You must have 100+ manna" );
            else
            {
                this.Close();
                Form frmGame2 = new frmZ2B();
                frmGame2.Show();
            }
        }

        private void btnlvlG3_Click( object sender, System.EventArgs e )
        {
            if ( UserDatabaseAccess.user.userScoreManna <= 150 )
                MessageBox.Show( "You must have 150+ manna" );
            else
            {
                this.Close();
                Form frmGame3 = new frmZ3B();
                frmGame3.Show();
            }
        }

        private void btnlvlG4_Click( object sender, System.EventArgs e )
        {
            if ( UserDatabaseAccess.user.userScoreManna <= 200 )
                MessageBox.Show( "You must have 200+ manna" );
            else
            {
                this.Close();
                Form frmGame4 = new frmZ4B();
                frmGame4.Show();
            }
        }

        private void btnQuit_Click( object sender, System.EventArgs e )
        {
            Application.Exit();
        }

        private void btnSave_Click( object sender, System.EventArgs e )
        {
            AccountMainControls.Save();
            MessageBox.Show( "Saved!" );
        }

        private void btnSettingAccountActivate_Click( object sender, System.EventArgs e )
        {
        }

        private void btnSettingCheatsActivate_Click( object sender, System.EventArgs e )
        {
            bool boolWantsToCheat = false;
            if ( !UserDatabaseAccess.user.userIsCheater )
            {
                DialogResult dialogResult = MessageBox.Show( "Enabling this option will prevent your scores from being" +
                                " saved or added to the leaderboards, are you sure you wish to accept?", "Enabling Cheats",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2 );
                if ( dialogResult == DialogResult.Yes )
                    boolWantsToCheat = true;
            }
            if ( boolWantsToCheat || UserDatabaseAccess.user.userIsCheater )
            {
                UserDatabaseAccess.user.userIsCheater = true;

                if ( btnSettingConsoleActivate.Visible == false )
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

        private void btnSettingCheatsLevel_Click( object sender, System.EventArgs e )
        {
            UserDatabaseAccess.user.userZoneUnlock = 4;
        }

        private void btnSettingCheatsManna_Click( object sender, System.EventArgs e )
        {
            UserDatabaseAccess.user.userScoreManna += 99999;
            updateLabels();
        }

        private void btnSettingCheatsQuail_Click( object sender, System.EventArgs e )
        {
            UserDatabaseAccess.user.userScoreQuail += 99999;
            updateLabels();
        }

        private void btnSettingConsoleActivate_Click( object sender, System.EventArgs e )
        {
        }

        private void btnSettingDifficultyActivate_Click( object sender, System.EventArgs e )
        {
            if ( btnSettingDifficultyEasy.Visible == false )
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

        private void btnSettingDifficultyEasy_Click( object sender, System.EventArgs e )
        {
            UserDatabaseAccess.user.userDifficulty = difficulty.novice;
        }

        private void btnSettingDifficultyHard_Click( object sender, System.EventArgs e )
        {
            UserDatabaseAccess.user.userDifficulty = difficulty.master;
        }

        private void btnSettingDifficultyMedium_Click( object sender, System.EventArgs e )
        {
            UserDatabaseAccess.user.userDifficulty = difficulty.apprentice;
        }

        private void btnSettings_Click( object sender, System.EventArgs e )
        {
            tabControl.SelectedTab = tabSettings;
        }

        private void btnWatch1_Click( object sender, EventArgs e )
        {
            UserDatabaseAccess.user.userZoneUnlock++;
            AccountMainControls.PlayMovie( cutscene1 );
            UnlockLevels();
        }

        private void btnWatch2_Click( object sender, EventArgs e )
        {
            UserDatabaseAccess.user.userZoneUnlock++;
            AccountMainControls.PlayMovie( cutscene2 );
            UnlockLevels();
        }

        private void btnWatch3_Click( object sender, EventArgs e )
        {
            UserDatabaseAccess.user.userZoneUnlock++;
            AccountMainControls.PlayMovie( cutscene3 );
            UnlockLevels();
        }

        private void btnWatch4_Click( object sender, EventArgs e )
        {
            UserDatabaseAccess.user.userZoneUnlock++;
            AccountMainControls.PlayMovie( cutscene4 );
            UnlockLevels();
        }

        private void btnWatch5_Click( object sender, EventArgs e )
        {
            AccountMainControls.PlayMovie( cutscene5 );
            UnlockLevels();
        }
    }
}
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

        private void btnlvlG6_Click(object sender, System.EventArgs e)
        {
            if (UserDatabaseAccess.user.userScoreQuail <= 100)
                MessageBox.Show("You must have 100+ quail");
            else
            {
                UserDatabaseAccess.user.userScoreQuail -= 100;
                MessageBox.Show("Level unlocked");
                updateLabels();
            }
        }

        private void btnlvlQ1_Click(object sender, System.EventArgs e)
        {
            switch (diff)
            {
                case difficulty.novice:
                    this.Close();
                    Form q1e = new frmZ1E();
                    q1e.Show();
                    break;

                case difficulty.apprentice:
                    this.Close();
                    Form q1m = new frmZ1M();
                    q1m.Show();
                    break;

                case difficulty.master:
                    this.Close();
                    Form q1h = new frmZ1H();
                    q1h.Show();
                    break;

                default:
                    break;
            }
        }

        private void btnlvlQ2_Click(object sender, System.EventArgs e)
        {
            switch (diff)
            {
                case difficulty.novice:
                    this.Close();
                    Form q2e = new frmZ2E();
                    q2e.Show();
                    break;
                //case difficulty.apprentice:
                //    this.Close();
                //     Form q2m = new frmZ2M();
                //     q2m.Show();
                //    break;
                //case difficulty.master:
                //    this.Close();
                //    Form q2h = new frmZ2H();
                //    q2h.Show();
                //    break;
                default:
                    break;
            }
        }

        private void btnlvlQ3_Click(object sender, System.EventArgs e)
        {
            switch (diff)
            {
                case difficulty.novice:
                    this.Close();
                    Form q3e = new frmZ3E();
                    q3e.Show();
                    break;
                //case difficulty.apprentice:
                //    this.Close();
                //     Form q3m = new frmZ3M();
                //     q3m.Show();
                //    break;
                //case difficulty.master:
                //    this.Close();
                //    Form q3h = new frmZ3H();
                //    q3h.Show();
                //    break;
                default:
                    break;
            }
        }

        private void btnlvlQ4_Click(object sender, System.EventArgs e)
        {
            /*switch (diff)
            {
                case difficulty.novice:
                    this.Close();
                    Form q3e = new frmZ3E();
                    q3e.Show();
                    break;

                case difficulty.apprentice:
                    this.Close();
                     Form q3m = new frmZ3M();
                     q3m.Show();
                    break;

                case difficulty.master:
                    this.Close();
                    Form q3h = new frmZ3H();
                    q3h.Show();
                    break;

                default:
                    break;
            }*/
        }

        private void btnQuit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            //save score and progress
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
            if (!UserDatabaseAccess.user.cheater)
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
        }

        private void btnSettingConsoleActivate_Click(object sender, System.EventArgs e)
        {

        }
    }
}
using System.Windows.Forms;

namespace Exodus_Challenge
{
    public partial class LevelSelect : Form
    {
        difficulty diff = difficulty.apprentice;
        #region Public Constructors

        public LevelSelect()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        private void btnlvlG1_Click(object sender, System.EventArgs e)
        {
            if (loginSystem.user.scoreManna <= 50)
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
            if (loginSystem.user.scoreManna <= 50)
                MessageBox.Show("You must have 50+ manna");
            else
            {
                //this.Close();
                //Form frmGame2 = new frmZ2B();
                //frmGame2.Show();
            }
        }

        private void btnlvlG3_Click(object sender, System.EventArgs e)
        {
            if (loginSystem.user.scoreManna <= 50)
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
            if (loginSystem.user.scoreManna <= 50)
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
            if (loginSystem.user.scoreQuail <= 100)
                MessageBox.Show("You must have 100+ quail");
            else
            {
                loginSystem.user.scoreQuail -= 100;
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

        private void button1_Click(object sender, System.EventArgs e)
        {
            loginSystem.user.scoreManna += 9000;
            loginSystem.user.scoreQuail += 9000;
            updateLabels();
        }

        private void LevelSelect_Load(object sender, System.EventArgs e)
        {
            lblMannaScore.Text = loginSystem.user.scoreManna.ToString();
            lblQuailScore.Text = loginSystem.user.scoreQuail.ToString();
        }

        private void updateLabels()
        {
            lblMannaScore.Text = loginSystem.user.scoreManna.ToString();
            lblQuailScore.Text = loginSystem.user.scoreQuail.ToString();
        }

        #endregion Private Methods

        private void button2_Click(object sender, System.EventArgs e)
        {
            diff = difficulty.novice;
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            diff = difficulty.apprentice;
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            diff = difficulty.master;
        }

        private void logOutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Restart();
        }
    }
    enum difficulty
    {
        novice,
        apprentice,
        master
    }
}
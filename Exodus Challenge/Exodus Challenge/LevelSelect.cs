using System.Windows.Forms;

namespace Exodus_Challenge
{
    public partial class LevelSelect : Form
    {
        #region Public Constructors

        public LevelSelect()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        private void btnlv4_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Form frmQ4 = new frmQReorder();
            frmQ4.Show();
        }

        private void btnlvlG1_Click(object sender, System.EventArgs e)
        {
            if (loginSystem.user.scoreManna <= 50)
                MessageBox.Show("You must have 50+ manna");
            else
            {
                this.Close();
                Form frmGame1 = new frmWackamole();
                frmGame1.Show();
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
            this.Close();
            Form frmQ1 = new frmQCrossword();
            frmQ1.Show();
        }

        private void btnlvlQ2_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Form frmQ2 = new frmQQuestions();
            frmQ2.Show();
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
    }
}
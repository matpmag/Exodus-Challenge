using System;
using System.Media;
using System.Windows.Forms;

namespace Exodus_Challenge
{
    public partial class frmWackamole : Form
    {
        SoundPlayer sfx = new SoundPlayer();

        #region Public Fields

        #endregion Public Fields

        #region Private Fields

        private Random chanceSelect = new Random();
        private int clicksThisTick = 0;
        private int count = 0;
        private Random random = new Random();

        #endregion Private Fields

        #region Public Constructors

        public frmWackamole()
        {
            InitializeComponent();
            evenProb();
            sfx.SoundLocation = "../../../Media/SFX/Sharp Punch.wav";

        }

        #endregion Public Constructors

        #region Private Methods

        private Panel evenProb()
        {
            double totalAreaA = areaA.Height * areaA.Width;
            double totalAreaB = areaB.Height * areaB.Width;
            double totalAreaC = areaC.Height * areaC.Width;
            double totalArea = totalAreaA + totalAreaB + totalAreaC;
            double chanceA = totalAreaA / totalArea;
            double chanceB = totalAreaB / totalArea;
            double chanceC = totalAreaC / totalArea;
            double selected = chanceSelect.NextDouble();
            if (selected <= chanceA)
                return areaA;
            else if (selected <= (chanceA + chanceB))
                return areaB;
            else
                return areaC;
        }

        private void moleTicker_Tick(object sender, EventArgs e)
        {
            pbxSpout.Left = pbxMole.Left;
            pbxSpout.Top = pbxMole.Top;
            pbxSpout.Top += 15;
            waitTicker.Start();
            if (clicksThisTick == 2)
            {
                count += 10;
                pbxSpout.Visible = true;


            }
            clicksThisTick = 0;
            scoreCount.Text = count.ToString();
            Panel areaForTarget = evenProb();
            int minLeft = areaForTarget.Left;
            int maxLeft = areaForTarget.Right - pbxMole.Width;
            int minTop = areaForTarget.Top;
            int maxTop = areaForTarget.Bottom - pbxMole.Height;
            pbxMole.Left = random.Next(minLeft, maxLeft);
            pbxMole.Top = random.Next(minTop, maxTop);
            pbxMole.Visible = true;
        }

        private void pbxMole_MouseDown(object sender, MouseEventArgs e)
        {
            clicksThisTick++;
            sfx.Play();
        }

        private void timeInLevel_Tick(object sender, EventArgs e)
        {
            loginSystem.user.scoreManna-=10;
            if (loginSystem.user.scoreManna <= 0)
            {
                loginSystem.user.scoreQuail += count;
                this.Close();
                Form lvl = new LevelSelect();
                lvl.Show();
            }
        }

        #endregion Private Methods

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form lvl = new LevelSelect();
            lvl.Show();
        }

        private void waitTicker_Tick(object sender, EventArgs e)
        {
            pbxSpout.Visible = false;
            waitTicker.Stop();
        }
    }
}
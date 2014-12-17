using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Exodus_Challenge
{
    public partial class Escape : Form
    {

        #region Private Methods

        private void timerAdd_Tick(object sender, EventArgs e)
        {
            PictureBox nextObsArea = pictureBox2;
            Point nextObsStart = new Point(0, 0);
            switch (rand.Next(1, 4))
            {
                case 1:
                    nextObsArea = areaObsTop;
                    nextObsStart = obsStartTop.Location;
                    break;

                case 2:
                    nextObsArea = areaObsMid;
                    nextObsStart = obsStartMid.Location;
                    break;

                case 3:
                    nextObsArea = areaObsBot;
                    nextObsStart = obsStartBot.Location;
                    break;
            }
            PictureBox pbxNew = new PictureBox
            {
                Image = obsStartMid.Image,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.PeachPuff,
                Size = obsStartMid.Size,
                Height = obsStartMid.Height,
                Location = nextObsStart
            };
            this.Controls.Add(pbxNew);
            pbxNew.BringToFront();
            pbxNew.Show();
            Obstacle obsNew = new Obstacle
            {
                pbx = pbxNew,
                area = nextObsArea
            };
            obstacles.Add(obsNew);
            if (!timerMove.Enabled)
            {
                timerMove.Start();
            }
        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            foreach (Obstacle obs in obstacles)
            {
                if (obs.run)
                {
                    if (obs.move(israeliteCurrent))
                    {
                        obs.run = false;
                        this.Controls.Remove(obs.pbx);
                        obstacles.Remove(obs);
                        break;
                    }
                }
            }
        }

        #endregion Private Methods

        #region Private Fields

        private PictureBox israeliteCurrent;

        private IList<Obstacle> obstacles = new List<Obstacle>();

        private Random rand = new Random();

        #endregion Private Fields

        #region Public Constructors

        public Escape()
        {
            InitializeComponent();
            israeliteCurrent = pbxIsraelitesMid;
        }

        #endregion Public Constructors

        private void Escape_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (israeliteCurrent == pbxIsraelitesMid)
                {
                    israeliteCurrent = pbxIsraelitesTop;
                }
                else if (israeliteCurrent == pbxIsraelitesBot)
                {
                    israeliteCurrent = pbxIsraelitesMid;
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (israeliteCurrent == pbxIsraelitesTop)
                {
                    israeliteCurrent = pbxIsraelitesMid;
                }
                else if (israeliteCurrent == pbxIsraelitesMid)
                {
                    israeliteCurrent = pbxIsraelitesBot;
                }
            }
            pbxIsraelitesTop.ImageLocation = "";
            pbxIsraelitesMid.ImageLocation = "";
            pbxIsraelitesBot.ImageLocation = "";
            israeliteCurrent.ImageLocation = "../../../Media/Images/gif.gif";
        }
    }
}
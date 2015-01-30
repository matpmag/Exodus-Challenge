using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Exodus_Challenge.LoginSystem;

namespace Exodus_Challenge
{
    public struct Z1BGameInfo
    {
        public static bool? collision = null;
    }

    public partial class frmZ1B : Level
    {
        private Image randomObsImageGen()
        {
            Random random = new Random();
            int randomObsImageIndex = random.Next( 1, 4 );
            switch ( randomObsImageIndex )
            {
                case 1:
                    return obsStartTop.Image;

                case 2:
                    return obsStartMid.Image;

                case 3:
                    return obsStartBot.Image;

                default:
                    try
                    {
                        throw new IndexOutOfRangeException();
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show(string.Format("The random number generator returned an unexpected value: {0}",
                                                       randomObsImageIndex.ToString()), e.ToString());
                        return obsStartTop.Image;
                    }
            }
            
        }
        private void timerAdd_Tick( object sender, EventArgs e )
        {
            PictureBox nextObsArea = pictureBox2;
            Point nextObsStart = new Point( 0, 0 );
            switch ( rand.Next( 1, 4 ) )
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

                Image = randomObsImageGen(),
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = obsStartMid.Size,
                Height = obsStartMid.Height,
                Location = nextObsStart
            };
            this.Controls.Add( pbxNew );
            pbxNew.BringToFront();
            pbxNew.Show();
            Obstacle obsNew = new Obstacle
            {
                pbx = pbxNew,
                area = nextObsArea
            };
            obstacles.Add( obsNew );
            if ( !timerMove.Enabled )
            {
                timerMove.Start();
            }
        }

        private void timerMove_Tick( object sender, EventArgs e )
        {
            foreach ( Obstacle obs in obstacles )
            {
                if ( obs.run )
                {
                    if ( obs.move( israeliteCurrent ) )
                    {
                        if ( Z1BGameInfo.collision == true )
                            attackersPos++;
                        obs.run = false;
                        this.Controls.Remove( obs.pbx );
                        obstacles.Remove( obs );
                        break;
                    }
                }
            }
            switch ( attackersPos )
            {
                case 0:
                    pictureBox1.Visible = true;
                    break;

                case 1:
                    pictureBox2.Visible = true;
                    break;

                case 2:
                    pictureBox3.Visible = true;
                    break;

                default:
                    Form LevelSelectScreen = new frmLevelSelect();
                    this.Close();
                    LevelSelectScreen.Show();
                    break;
            }
        }

        private int attackersPos = 0;
        private PictureBox israeliteCurrent;

        private IList<Obstacle> obstacles = new List<Obstacle>();

        private Random rand = new Random();

        public frmZ1B()
        {
            InitializeComponent();
            israeliteCurrent = pbxIsraelitesMid;
        }

        private void Escape_KeyDown( object sender, KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Up )
            {
                if ( israeliteCurrent == pbxIsraelitesMid )
                {
                    israeliteCurrent = pbxIsraelitesTop;
                }
                else if ( israeliteCurrent == pbxIsraelitesBot )
                {
                    israeliteCurrent = pbxIsraelitesMid;
                }
            }
            else if ( e.KeyCode == Keys.Down )
            {
                if ( israeliteCurrent == pbxIsraelitesTop )
                {
                    israeliteCurrent = pbxIsraelitesMid;
                }
                else if ( israeliteCurrent == pbxIsraelitesMid )
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

    internal class Obstacle
    {
        internal PictureBox area;
        internal PictureBox pbx;
        internal bool run = true;

        internal bool move( PictureBox israeliteCurrent )
        {
            Z1BGameInfo.collision = null;
            pbx.Left -= 10;
            if ( pbx.Location.X + pbx.Width < israeliteCurrent.Location.X )
                Z1BGameInfo.collision = false;
            if ( israeliteCurrent.Location.X + israeliteCurrent.Width < pbx.Location.X )
                Z1BGameInfo.collision = false;
            if ( pbx.Location.Y + pbx.Height < israeliteCurrent.Location.Y )
                Z1BGameInfo.collision = false;
            if ( israeliteCurrent.Location.Y + israeliteCurrent.Height < pbx.Location.Y )
                Z1BGameInfo.collision = false;

            if ( Z1BGameInfo.collision != false )
                Z1BGameInfo.collision = true;

            if ( Z1BGameInfo.collision == true )
                return true;

            if ( pbx.Left < 10 )
            {
                UserDatabaseAccess.user.userScoreQuail += 5;
                return true;
            }
            return false;
        }
    }
}
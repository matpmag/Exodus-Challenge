using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Exodus_Challenge.LoginSystem;

namespace Exodus_Challenge
{
    public partial class frmZ1B : Form
    {
        int attackersPos = 0;
        #region Private Methods

        #region Methods

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
                Image = obsStartMid.Image,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.PeachPuff,
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
                    Form LevelSelectScreen = new LevelSelect();
                    this.Close();
                    LevelSelectScreen.Show();
                    break;
            }
        }

        #endregion Methods

        #endregion Private Methods



        #region Fields

        private PictureBox israeliteCurrent;

        private IList<Obstacle> obstacles = new List<Obstacle>();

        private Random rand = new Random();

        #endregion Fields

        #region Constructors

        public frmZ1B()
        {
            InitializeComponent();
            israeliteCurrent = pbxIsraelitesMid;
        }

        #endregion Constructors

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
    public struct Z1BGameInfo
    {
        public static bool? collision = null;
    }
    internal class Obstacle
    {
        #region Public Fields

        #region Fields

        public PictureBox area;
        public PictureBox pbx;
        public bool run = true;
        #endregion Fields

        #endregion Public Fields

        #region Public Methods

        #region Methods

        public bool move( PictureBox israeliteCurrent )
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

        #endregion Methods

        #endregion Public Methods
    }
}
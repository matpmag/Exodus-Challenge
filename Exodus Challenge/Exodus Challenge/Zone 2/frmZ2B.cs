using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Exodus_Challenge.LoginSystem;

namespace Exodus_Challenge
{
    public partial class frmZ2B : Form
    {
        private void tickerMovement_Tick( object sender, EventArgs e )
        {
            g = pbxCanvas.CreateGraphics();
            //if ( false )
            //{
            //    UserDatabaseAccess.user.userScoreManna -= 10;
            //    if ( UserDatabaseAccess.user.userScoreManna <= 10 )
            //    {
            //        Form LevelSelectScreen = new LevelSelect();
            //        LevelSelectScreen.Show();
            //        this.Close();
            //    }
            //}
            g.Clear( Color.ForestGreen );
            if ( collision() )
            {
                tickerMovement.Stop();
                MessageBox.Show( "Game Over" );
            }
            if ( consumedFood() )
            {
                foodGenNew();
                nomnomnom = false;
            }
            else
            {
                foodPersist();
            }
            foreach ( SnakeSection part in snakeQueue )
            {
                part.LastX = part.X;
                part.LastY = part.Y;
                switch ( part.NextMove )
                {
                    case Direction.up:
                        part.Y -= 32;
                        break;

                    case Direction.down:
                        part.Y += 32;
                        break;

                    case Direction.left:
                        part.X -= 32;
                        break;

                    case Direction.right:
                        part.X += 32;
                        break;

                    default:
                        break;
                }

                g.DrawImage( part.image, part.X, part.Y, 32, 32 );
                switch ( part.WillMove )
                {
                    case Direction.right:
                        part.image.RotateFlip( RotateFlipType.Rotate90FlipNone );
                        break;
                    case Direction.down:
                        break;
                    case Direction.left:
                        break;
                    case Direction.up:
                        break;
                    default:
                        break;
                }
            }
        }

        public static SnakeHead head;

        public static SnakeSection lastAdded;

        public static Queue<SnakeSection> snakeQueue = new Queue<SnakeSection>();

        private bool debug = false;

        private int foodX;

        private int foodY;

        private Graphics g;

        private bool nomnomnom = false;

        public frmZ2B()
        {
            InitializeComponent();
            Application.DoEvents();
            g = pbxCanvas.CreateGraphics();
            if ( UserDatabaseAccess.user.userUsername == "" || UserDatabaseAccess.user.userUsername == "admin" )
            {
                debug = true;
            }
            foodX = new Random().Next( 0, pbxCanvas.Width / 32 ) * 32;
            foodY = new Random().Next( 0, pbxCanvas.Height / 32 ) * 32;
            nomnomnom = false;
            head = new SnakeHead();
            head.previous = head;
            snakeQueue.Enqueue( head );
            lastAdded = snakeQueue.ElementAt( snakeQueue.Count - 1 );
            foodGenNew();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            snakeQueue.Enqueue( new SnakeBody() );
            lastAdded = snakeQueue.ElementAt( snakeQueue.Count - 1 );
            lastAdded.previous = snakeQueue.ElementAt( snakeQueue.Count - 2 );
            lastAdded.X = lastAdded.previous.LastX;
            lastAdded.Y = lastAdded.previous.LastY;
        }

        private bool collision()
        {
            foreach ( SnakeSection part in snakeQueue )
            {
                if ( part.GetType() != head.GetType() && part.X == head.X && part.Y == head.Y )
                {
                    return true;
                }
            }
            if ( head.X < 0 || head.X >= pbxCanvas.Width - 32 ||
                head.Y < 0 || head.Y >= pbxCanvas.Height - 32 )
            {
                return true;
            }
            return false;
        }

        private bool consumedFood()
        {
            if ( snakeQueue.First().X == foodX && snakeQueue.First().Y == foodY )
            {
                nomnomnom = true;
                snakeQueue.Enqueue( new SnakeBody() );
                lastAdded = snakeQueue.ElementAt( snakeQueue.Count - 1 );
                lastAdded.previous = snakeQueue.ElementAt( snakeQueue.Count - 2 );
                lastAdded.X = lastAdded.previous.LastX;
                lastAdded.Y = lastAdded.previous.LastY;
            }
            else
            {
                nomnomnom = false;
            }
            return nomnomnom;
        }

        private void foodGenNew()
        {
            Brush selBrush = new SolidBrush( Color.Purple );
            bool verifiedFoodGen = false;

            while ( !verifiedFoodGen )
            {

                foodX = new Random().Next( 0, pbxCanvas.Width / 32 ) * 32;
                foodY = new Random().Next( 0, pbxCanvas.Height / 32 ) * 32;
                bool badGeneration = snakeQueue.Any( p => p.X == foodX && p.Y == foodY );
                if ( badGeneration )
                {
                    foodX = new Random().Next( 0, pbxCanvas.Width / 32 ) * 32;
                    foodY = new Random().Next( 0, pbxCanvas.Height / 32 ) * 32;
                }
                else
                {
                    verifiedFoodGen = true;
                }
            }
            g.FillRectangle( selBrush, foodX, foodY, 32, 32 );
        }

        private void foodPersist()
        {
            Brush selBrush = new SolidBrush( Color.Purple );
            g.FillRectangle( selBrush, foodX, foodY, 32, 32 );
        }

        private void frmZ2B_KeyDown( object sender, KeyEventArgs e )
        {
            switch ( e.KeyCode )
            {
                case Keys.S:
                case Keys.Down:
                    if ( head.WillMove != Direction.up )
                    {
                        SnakeGameInfo.lastKey = Keys.Down;
                    }
                    break;

                case Keys.A:
                case Keys.Left:
                    if ( head.WillMove != Direction.right )
                    {
                        SnakeGameInfo.lastKey = Keys.Left;
                    }
                    break;

                case Keys.D:
                case Keys.Right:
                    if ( head.WillMove != Direction.left )
                    {
                        SnakeGameInfo.lastKey = Keys.Right;
                    }
                    break;

                case Keys.W:
                case Keys.Up:
                    if ( head.WillMove != Direction.down )
                    {
                        SnakeGameInfo.lastKey = Keys.Up;
                    }
                    break;

                default:
                    break;
            }
        }

        private void frmZ2B_PreviewKeyDown( object sender, PreviewKeyDownEventArgs e )
        {
            e.IsInputKey = true;
        }

        private void pbxCanvas_Paint( object sender, PaintEventArgs e )
        {
            g.Dispose();
            g = pbxCanvas.CreateGraphics();
            Pen pen = new Pen( Color.Red );
            g.DrawRectangle( pen, 0, 0, 10, 10 );
        }
    }
}
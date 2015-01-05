﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exodus_Challenge
{
    public partial class frmZ2B : Form
    {
        public static SnakeHead head;
        public static Queue<SnakeSection> snakeQueue = new Queue<SnakeSection>();
        public static SnakeSection lastAdded;
        Graphics g;
        int foodX;
        int foodY;
        bool nomnomnom = false;
        public frmZ2B()
        {
            InitializeComponent();
            g = pbxCanvas.CreateGraphics();
            nomnomnom = true;
            head = new SnakeHead();
            snakeQueue.Enqueue(head);
            lastAdded = snakeQueue.ElementAt( snakeQueue.Count - 1 );
            lastAdded.SnakeSetup();
            foodGenNew();
        }

        private void tickerMovement_Tick(object sender, EventArgs e)
        {
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
                Brush selBrush = new SolidBrush( part.color );
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
                g.FillRectangle( selBrush, part.X, part.Y, 32, 32 );
                string fullpath = Application.ExecutablePath.Substring( 0, Application.ExecutablePath.LastIndexOf( @"\" ) - 27 ) + part.image;
                part.image = Image.FromFile(fullpath);
                g.DrawImage(part.image, part.X, part.Y, 32, 32);
            }
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

        private bool collision()
        {
            foreach ( SnakeSection part in snakeQueue )
            {
                if ( part.GetType() != head.GetType() && part.X == head.X && part.Y == head.Y )
                {
                    return true;
                }
            }
            if( head.X < 0 || head.X >= pbxCanvas.Width - 32 ||
                head.Y < 0 ||  head.Y >= pbxCanvas.Height - 32 )
            {
                return true;
            }
            return false;
        }

        private void foodGenNew()
        {
            Brush selBrush = new SolidBrush( Color.Purple );
            foodX = new Random().Next( 0, pbxCanvas.Width / 32 ) * 32;
            foodY = new Random().Next( 0, pbxCanvas.Height / 32 ) * 32; 
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
                    if ( head.LastMove != Direction.up )
                    {

                        SnakeGameInfo.lastKey = Keys.Down;
                    }
                    break;
                case Keys.A:
                case Keys.Left:
                    if ( head.LastMove != Direction.right )
                    {
                        SnakeGameInfo.lastKey = Keys.Left;
                    }
                    break;
                case Keys.D:
                case Keys.Right:
                    if ( head.LastMove != Direction.left )
                    {
                        SnakeGameInfo.lastKey = Keys.Right;
                    }
                    break;
                case Keys.W:
                case Keys.Up:
                    if ( head.LastMove != Direction.down )
                    {
                        SnakeGameInfo.lastKey = Keys.Up;
                    }
                    break;

                default:
                    break;
            }
        }

        private void button1_Click( object sender, EventArgs e )
        {
            snakeQueue.Enqueue( new SnakeBody() );
            lastAdded = snakeQueue.ElementAt( snakeQueue.Count - 1 );
            lastAdded.previous = snakeQueue.ElementAt( snakeQueue.Count - 2 );
            lastAdded.X = lastAdded.previous.LastX;
            lastAdded.Y = lastAdded.previous.LastY;
        }

        private void frmZ2B_PreviewKeyDown( object sender, PreviewKeyDownEventArgs e )
        {
            e.IsInputKey = true;
        }
    }
}

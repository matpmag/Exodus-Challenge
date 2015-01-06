using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Exodus_Challenge
{
    public enum Direction
    {
        up,
        down,
        left,
        right
    }

    public struct SnakeGameInfo
    {
        public static Keys lastKey = Keys.Right;
        public static IList<string> possibleImagePaths;
    }

    public class SnakeBody : SnakeSection
    {
        public override Direction NextMove
        {
            get
            {
                this.LastMove = this.WillMove;
                this.WillMove = this.previous.LastMove;
                return this.WillMove;
            }
        }

        public override void SnakeSetup()
        {
            imageDirectory = "../../../Media/Israelites";
        }
    }

    public class SnakeHead : SnakeSection
    {
        public override Direction NextMove
        {
            get
            {
                this.LastMove = this.WillMove;
                switch ( SnakeGameInfo.lastKey )
                {
                    case Keys.Up:
                        this.WillMove = Direction.up;
                        return this.WillMove;

                    case Keys.Down:
                        this.WillMove = Direction.down;
                        return this.WillMove;

                    case Keys.Left:
                        this.WillMove = Direction.left;
                        return this.WillMove;

                    default:
                        this.WillMove = Direction.right;
                        return this.WillMove;
                }
            }
        }

        public override void SnakeSetup()
        {
            previous = this;
            imageDirectory = "../../../Media/Israelites/Moses";
        }
    }

    public abstract class SnakeSection
    {
        public Color color = Color.Red;

        //TODO: get image path string from folder
        public Image image;

        public string imageDirectory;
        public string imagepath;
        public Direction LastMove;
        public SnakeSection previous;
        public Direction WillMove;
        private bool imageSet = false;

        public SnakeSection()
        {
            SnakeSetup();
            X = 0;
            Y = 0;
            LastX = X;
            LastY = Y;
            SnakeGameInfo.possibleImagePaths = Directory.GetFiles( imageDirectory );
            while ( !imageSet )
            {
                imagepath = SnakeGameInfo.possibleImagePaths[new Random().Next( 0, SnakeGameInfo.possibleImagePaths.Count )];
                if ( !imagepath.EndsWith( ".db" ) )
                {
                    image = Image.FromFile( imagepath );
                    imageSet = true;
                }
            }
        }

        public int LastX
        {
            get;
            set;
        }

        public int LastY
        {
            get;
            set;
        }

        public abstract Direction NextMove
        {
            get;
        }

        public int X
        {
            get;
            set;
        }

        public int Y
        {
            get;
            set;
        }

        public abstract void SnakeSetup();
    }
}
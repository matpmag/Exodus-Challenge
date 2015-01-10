using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Exodus_Challenge
{
    public enum Direction
    {
        right = 1,
        down = 2,
        left = 3,
        up = 0
    }

    public struct SnakeGameInfo
    {
        public static Keys lastKey = Keys.Right;
        public static IList<string> possibleImagePaths;
    }

    public class SnakeBody : SnakeSection
    {
        public override string ImageDirectory
        {
            get
            {
                return "../../../Media/Israelites";
            }
        }

        public override Direction NextMove
        {
            get
            {
                this.LastMove = this.WillMove;
                this.WillMove = this.previous.LastMove;
                return this.WillMove;
            }
        }
    }

    public class SnakeHead : SnakeSection
    {
        public override string ImageDirectory
        {
            get
            {
                return "../../../Media/Israelites/Moses";
            }
        }

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
    }

    public abstract class SnakeSection
    {
        public int rotateSize;

        public Image image;

        private string imageDirectory;

        public abstract string ImageDirectory
        {
            get;
        }
        
        public string imagepath;
        public Direction LastMove;
        public SnakeSection previous;
        public Direction WillMove;

        public SnakeSection()
        {
            X = 0;
            Y = 0;
            LastX = X;
            LastY = Y;
            SnakeGameInfo.possibleImagePaths = Directory.GetFiles( imageDirectory );
            bool imageSet = false;
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
    }
}
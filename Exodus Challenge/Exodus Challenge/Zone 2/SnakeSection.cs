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
        public static string bodyImageDir = "../../../Media/Israelites";
        public static string headImageDir = "../../../Media/Israelites/Moses";
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
    }

    public abstract class SnakeSection
    {
        public int rotateSize;

        public Image image;
        
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
            string imageDirectory = ( this.GetType().ToString() == "Exodus_Challenge.SnakeHead" ) ?
                SnakeGameInfo.headImageDir : SnakeGameInfo.bodyImageDir;
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
            image.RotateFlip( RotateFlipType.Rotate270FlipNone );
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
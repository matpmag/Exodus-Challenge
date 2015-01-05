using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

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
    }
    public abstract class SnakeSection
    {
        public Color color = Color.Red;
        public string imagepath;
        //TODO: get imagepath string from folder
        public Image image;
        public int X { get; set; }
        public int Y { get; set;}
        public int LastX { get; set; }
        public int LastY { get; set; }
        public SnakeSection previous;
        public Direction WillMove;
        public Direction LastMove;

        public abstract Direction NextMove { get; }

        public abstract void SnakeSetup();

        public SnakeSection()
        {
            SnakeSetup();
        }
    }

    public class SnakeBody : SnakeSection
    {
        public override void SnakeSetup()
        {
            X = 0;
            Y = 0;
            LastX = X;
            LastY = Y;
            //image = Image.FromFile();
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
        public override void SnakeSetup()
        {
            X = 0;
            Y = 0;
            LastX = X;
            LastY = Y;
            previous = this;
            color = Color.Red;
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
}

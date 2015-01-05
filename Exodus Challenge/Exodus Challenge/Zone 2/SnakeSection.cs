using System.Drawing;
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
        #region Fields

        public static Keys lastKey = Keys.Right;

        #endregion Fields
    }

    public class SnakeBody : SnakeSection
    {
        #region Properties

        public override Direction NextMove
        {
            get
            {
                this.LastMove = this.WillMove;
                this.WillMove = this.previous.LastMove;
                return this.WillMove;
            }
        }

        #endregion Properties

        #region Methods

        public override void SnakeSetup()
        {
            X = 0;
            Y = 0;
            LastX = X;
            LastY = Y;
            //image = Image.FromFile();
        }

        #endregion Methods
    }

    public class SnakeHead : SnakeSection
    {
        #region Properties

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

        #endregion Properties

        #region Methods

        public override void SnakeSetup()
        {
            X = 0;
            Y = 0;
            LastX = X;
            LastY = Y;
            previous = this;
            color = Color.Red;
        }

        #endregion Methods
    }

    public abstract class SnakeSection
    {
        #region Fields

        public Color color = Color.Red;

        //TODO: get imagepath string from folder
        public Image image;

        public string imagepath;
        public Direction LastMove;

        public SnakeSection previous;

        public Direction WillMove;

        #endregion Fields

        #region Constructors

        public SnakeSection()
        {
            SnakeSetup();
        }

        #endregion Constructors

        #region Properties

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

        #endregion Properties

        #region Methods

        public abstract void SnakeSetup();

        #endregion Methods
    }
}
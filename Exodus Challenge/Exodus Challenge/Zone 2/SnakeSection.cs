using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exodus_Challenge
{
    public enum Direction
    {
        up,
        down,
        left,
        right
    }
    public abstract class SnakeSection
    {
        public int X { get; set; }
        public int Y { get; set; }

        public abstract Direction NextMove { get; }

        public SnakeSection()
        {
            X = 0;
            Y = 0;
        }

        
    }

    public class SnakeBody : SnakeSection
    {
        public override Direction NextMove
        {
            get
            {
                return Direction.up;
            }
        }
    }

    public class SnakeHead : SnakeSection
    {
        public override Direction NextMove
        {
            get
            {
                return Direction.down;
            }
        }
    }
}

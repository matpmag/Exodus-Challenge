using System.Windows.Forms;

namespace Exodus_Challenge
{
    internal class Obstacle
    {
        #region Public Fields

        public PictureBox area;
        public PictureBox pbx;
        public bool run = true;

        #endregion Public Fields

        #region Public Methods

        public bool move(PictureBox israeliteCurrent)
        {
            bool? collision = null;
            pbx.Left -= 10;
            if (pbx.Location.X + pbx.Width < israeliteCurrent.Location.X)
                collision = false;
            if (israeliteCurrent.Location.X + israeliteCurrent.Width < pbx.Location.X)
                collision = false;
            if (pbx.Location.Y + pbx.Height < israeliteCurrent.Location.Y)
                collision = false;
            if (israeliteCurrent.Location.Y + israeliteCurrent.Height < pbx.Location.Y)
                collision = false;

            if (collision != false)
                collision = true;
            if (collision == true)
            {
                return true;
            }
            if (pbx.Left < 10)
                return true;
            return false;
        }

        #endregion Public Methods
    }
}
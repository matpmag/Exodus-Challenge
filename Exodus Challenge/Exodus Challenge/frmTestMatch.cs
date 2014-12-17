using System;
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
    internal enum from
    {
        pbx1,
        pbx2,
        pbx3
    }

    public partial class frmTestMatch : Form
    {
        #region Private Methods

        private void timeRedraw_Tick(object sender, EventArgs e)
        {
            if (start != null && !set)
            {
                end = new Point(Cursor.Position.X, Cursor.Position.Y);
            }
            this.Refresh();
        }

        #endregion Private Methods

        #region Private Fields

        private Point begin;

        private int clicks = 0;

        private Point end;

        private Pen pen = new Pen(Color.Black, 4);

        private bool set = false;

        private from? start = null;

        #endregion Private Fields

        #region Public Constructors

        public frmTestMatch()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        private void boxClicked(PictureBox box)
        {
            switch (clicks)
            {
                case 0:
                    set = false;
                    begin = new Point(box.Location.X + box.Width / 2, box.Location.Y + box.Height / 2);
                    start = from.pbx1;
                    break;

                case 1:
                    end = new Point(box.Location.X + box.Width / 2, box.Location.Y + box.Height / 2);
                    set = true;
                    break;

                default:
                    clicks = -1;
                    end = begin;
                    break;
            }
            clicks++;
        }

        private void formQMatch_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y);
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }

        private void formQMatch_Paint(object sender, PaintEventArgs e)
        {
            if (start != null)
            {
                e.Graphics.DrawLine(pen, begin, end);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            boxClicked(pictureBox1);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            boxClicked(pictureBox2);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            boxClicked(pictureBox3);
        }
    }
}
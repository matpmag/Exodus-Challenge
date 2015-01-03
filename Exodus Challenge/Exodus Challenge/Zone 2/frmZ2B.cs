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
    public partial class frmZ2B : Form
    {
        public static Queue<SnakeSection> snakeQueue = new Queue<SnakeSection>();
        public static SnakeSection lastAdded = snakeQueue.ElementAt(snakeQueue.Count - 1);
        public frmZ2B()
        {
            InitializeComponent();
        }

        private void tickerMovement_Tick(object sender, EventArgs e)
        {

        }
    }
}

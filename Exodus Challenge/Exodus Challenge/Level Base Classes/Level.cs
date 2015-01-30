using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exodus_Challenge
{
    public class Level : Form
    {
        public Form thisLevel;

        public void returnToMap()
        {
            this.Hide();
            Form LevelSelect = new frmLevelSelect();
            LevelSelect.Show();
            Application.DoEvents();
            this.Close();
        }
        internal void retry()
        {
            this.Close();
            thisLevel.Show();
        }
    }
}

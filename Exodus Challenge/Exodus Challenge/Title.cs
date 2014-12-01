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
    public partial class Title : Form
    {
        #region Public Constructors

        public Title()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        private void time2start_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

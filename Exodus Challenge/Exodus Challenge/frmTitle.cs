using System;
using System.Windows.Forms;

namespace Exodus_Challenge
{
    public partial class frmTitle : Form
    {
        public frmTitle()
        {
            InitializeComponent();
        }

        private void time2start_Tick( object sender, EventArgs e )
        {
            time2start.Stop();
            this.Hide();
            Form login = new frmLogin();
            login.Show();
        }
    }
}
using System;
using System.Windows.Forms;

namespace Exodus_Challenge
{
    public partial class frmTitle : Form
    {
        #region Public Constructors

        #region Constructors

        public frmTitle()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #endregion Public Constructors

        #region Private Methods

        #region Methods

        private void time2start_Tick( object sender, EventArgs e )
        {
            time2start.Stop();
            this.Hide();
            Form login = new frmLogin();
            login.Show();
        }

        #endregion Methods

        #endregion Private Methods
    }
}
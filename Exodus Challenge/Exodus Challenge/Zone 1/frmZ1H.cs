using System;
using System.Windows.Forms;
using Exodus_Challenge.LoginSystem;

namespace Exodus_Challenge
{
    public partial class frmZ1H : Form
    {
        #region Private Fields

        #region Fields

        private int timeRemaining = 10;

        #endregion Fields

        #endregion Private Fields

        #region Public Constructors

        #region Constructors

        public frmZ1H()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #endregion Public Constructors

        #region Private Methods

        #region Methods

        private void btnQuit_Click( object sender, EventArgs e )
        {
            this.Close();
            Form lvl = new LevelSelect();
            lvl.Show();
        }

        private void btnSubmit_Click( object sender, EventArgs e )
        {
            if ( cbox1.Text == "Judah" &&
                tbar2.Value == 5 &&
                tbx3.Text == "Jochebed" &&
                rbtn4a.Checked )
            {
                MessageBox.Show( "Congratulations!" );
                UserDatabaseAccess.user.userScoreManna += 10 * timeRemaining;
            }
        }

        private void tbar2_Scroll( object sender, EventArgs e )
        {
            label5.Text = tbar2.Value.ToString();
        }

        #endregion Methods

        #endregion Private Methods
    }
}
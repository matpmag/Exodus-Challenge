using System;
using System.Windows.Forms;

namespace Exodus_Challenge
{
    public partial class frmLogin : Form
    {
        #region Public Constructors

        public frmLogin()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginSystem.login(inpUser.Text, inpPass.Text);
            loginSystem.debug();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            Form register = new frmRegister();
            register.Show();
        }

        private void inpPass_Click(object sender, EventArgs e)
        {
            inpPass.Text = "";
        }

        private void inpPass_TextChanged(object sender, EventArgs e)
        {
            if (inpPass.Text != "Password")
                inpPass.UseSystemPasswordChar = true;
        }

        private void inpUser_Click(object sender, EventArgs e)
        {
            inpUser.Text = "";
        }

        private void inpUser_TextChanged(object sender, EventArgs e)
        {
            //Test code
        }

        #endregion Private Methods
    }
}
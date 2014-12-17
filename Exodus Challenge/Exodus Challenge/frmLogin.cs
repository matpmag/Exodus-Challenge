using System;
using System.Drawing;
using System.Windows.Forms;

namespace Exodus_Challenge
{
    public partial class frmLogin : Form
    {
        #region Private Methods

        private void regEmail_Enter(object sender, EventArgs e)
        {
            regEmail.Text = "";
        }

        private void regEmail_TextChanged(object sender, EventArgs e)
        {
            if (regEmail.Text == "Email") regEmail.ForeColor = Color.Silver;
            else regEmail.ForeColor = Color.Black;
        }

        private void regPassword_Enter(object sender, EventArgs e)
        {
            regPassword.Text = "";
        }

        private void regPassword_TextChanged(object sender, EventArgs e)
        {
            if (regPassword.Text != "Password")
            {
                regPassword.UseSystemPasswordChar = true;
                regPassword.ForeColor = Color.Black;
            }
            else regPassword.ForeColor = Color.Silver;
        }

        private void regUsername_Enter(object sender, EventArgs e)
        {
            regUsername.Text = "";
        }

        private void regUsername_TextChanged(object sender, EventArgs e)
        {
            if (regUsername.Text == "Username") regUsername.ForeColor = Color.Silver;
            else regUsername.ForeColor = Color.Black;
        }

        #endregion Private Methods

        #region Public Fields

        public bool changingForm = false;

        public string loginAvatarPath;

        #endregion Public Fields

        #region Private Fields

        private bool diffSet = false;

        #endregion Private Fields

        #region Public Constructors

        public frmLogin()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        private static string avatarTranslate(int avatarNumber)
        {
            switch (avatarNumber)
            {
                case 1:
                    return "../../../Media/Avatars/moses.png";

                default:
                    return "";
            }
        }

        private void btnEasy_MouseEnter(object sender, EventArgs e)
        {
            pbxDiff.ImageLocation = "../../../Media/Images/scarabMin.png";
        }

        private void btnHard_MouseEnter(object sender, EventArgs e)
        {
            pbxDiff.ImageLocation = "../../../Media/Images/scarabMax.png";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (loginSystem.login(logUsername.Text, logPassword.Text))
            {
                changingForm = true;
                this.Close();
                Application.DoEvents();
                Form lvl = new LevelSelect();
                lvl.Show();
                changingForm = false;
            }
        }

        private void btnMedium_MouseEnter(object sender, EventArgs e)
        {
            pbxDiff.ImageLocation = "../../../Media/Images/scarabMid.png";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!diffSet)
            {
                panelDifficulty.Visible = true;
                diffSet = true;
            }
            else
            {
                string[] output = new string[]
                {
                    regUsername.Text,
                    regEmail.Text,
                    regPassword.Text,
                    regConfirm.Text,
                    0.ToString(),
                    0.ToString(),
                    avatarTranslate((int)regDBGAvatar.Value)
                };
                loginSystem.register(output);
            }
        }

        private void bypass_Click(object sender, EventArgs e)
        {
            if (loginSystem.login("admin", "admin"))
            {
                changingForm = true;
                this.Close();
                Application.DoEvents();
                Form lvl = new LevelSelect();
                lvl.Show();
                changingForm = false;
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!changingForm)
                Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            loginSystem.dateDOB = regDOB;
        }

        private void logPassword_Enter(object sender, EventArgs e)
        {
            logPassword.Text = "";
        }

        private void logPassword_TextChanged(object sender, EventArgs e)
        {
            if (logPassword.Text != "Password")
            {
                logPassword.UseSystemPasswordChar = true;
                logPassword.ForeColor = Color.Black;
            }
            else logPassword.ForeColor = Color.Silver;
        }

        private void logUsername_Enter(object sender, EventArgs e)
        {
            logUsername.Text = "";
        }

        private void logUsername_TextChanged(object sender, EventArgs e)
        {
            if (logUsername.Text == "Username") logUsername.ForeColor = Color.Silver;
            else logUsername.ForeColor = Color.Black;
            if (loginSystem.userCheck(logUsername.Text, out loginAvatarPath))
                logAvatar.ImageLocation = loginAvatarPath;
        }

        private void regConfirm_Enter(object sender, EventArgs e)
        {
            regConfirm.Text = "";
        }

        private void regConfirm_TextChanged(object sender, EventArgs e)
        {
            if (regConfirm.Text != "Password")
            {
                regConfirm.UseSystemPasswordChar = true;
                regConfirm.ForeColor = Color.Black;
            }
            else regConfirm.ForeColor = Color.Silver;
        }

        private void regDBGAvatar_ValueChanged(object sender, EventArgs e)
        {
            regAvatar.ImageLocation = avatarTranslate((int)regDBGAvatar.Value);
        }
    }
}
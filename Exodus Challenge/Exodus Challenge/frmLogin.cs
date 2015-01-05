﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Exodus_Challenge.LoginSystem;

namespace Exodus_Challenge
{
    public partial class frmLogin : Form
    {
        #region Fields

        #region Fields

        public bool changingForm = false;

        public string loginAvatarPath;

        private bool diffSet = false;

        private difficulty regDifficulty;

        #endregion Fields

        #endregion Fields

        #region Constructors

        #region Constructors

        public frmLogin()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #endregion Constructors

        #region Methods

        #region Methods

        private static string avatarTranslate( int avatarNumber )
        {
            switch ( avatarNumber )
            {
                case 1:
                    return "../../../Media/Avatars/1.png";
                case 2:
                    return "../../../Media/Avatars/2.png";
                case 3:
                    return "../../../Media/Avatars/3.png";
                case 4:
                    return "../../../Media/Avatars/4.png";
                case 5:
                    return "../../../Media/Avatars/5.png";
                case 6:
                    return "../../../Media/Avatars/6.png";
                default:
                    return "";
            }
        }

        private void btnEasy_Click( object sender, EventArgs e )
        {
            regDifficulty = difficulty.novice;
            diffSet = true;
            panelDifficulty.Visible = false;
        }

        private void btnEasy_MouseEnter( object sender, EventArgs e )
        {
            pbxDiff.ImageLocation = "../../../Media/Images/scarabMin.png";
        }

        private void btnHard_Click( object sender, EventArgs e )
        {
            regDifficulty = difficulty.master;
            diffSet = true;
            panelDifficulty.Visible = false;
        }

        private void btnHard_MouseEnter( object sender, EventArgs e )
        {
            pbxDiff.ImageLocation = "../../../Media/Images/scarabMax.png";
        }

        private void btnLogin_Click( object sender, EventArgs e )
        {
            if ( AccountMainControls.Login( logUsername.Text, logPassword.Text ) )
            {
                changingForm = true;
                this.Close();
                Application.DoEvents();
                AccountMainControls.levelselectscreen = new LevelSelect();
                AccountMainControls.levelselectscreen.Show();
                changingForm = false;
            }
        }

        private void btnMedium_Click( object sender, EventArgs e )
        {
            regDifficulty = difficulty.apprentice;
            diffSet = true;
            panelDifficulty.Visible = false;
        }

        private void btnMedium_MouseEnter( object sender, EventArgs e )
        {
            pbxDiff.ImageLocation = "../../../Media/Images/scarabMid.png";
        }

        private void btnRegister_Click( object sender, EventArgs e )
        {
            string[] output = new string[]
            {
                regUsername.Text,
                regEmail.Text,
                regPassword.Text,
                avatarTranslate((int)regDBGAvatar.Value),
                0.ToString()
            };
            if ( !diffSet && RegistrationErrorControl.validRegister( output, regConfirm.Text, true ) )
            {
                panelDifficulty.Visible = true;
                btnRegister.Text = "Register";
            }
            else
                AccountMainControls.Register( output, regDifficulty );
        }

        private void bypass_Click( object sender, EventArgs e )
        {
            if ( AccountMainControls.Login( "admin", "Admin123" ) )
            {
                changingForm = true;
                Form lvl = new LevelSelect();
                this.Close();
                lvl.Show();
                Application.DoEvents();
                changingForm = false;
            }
        }

        private void frmLogin_FormClosing( object sender, FormClosingEventArgs e )
        {
            if ( !changingForm )
                Application.Exit();
        }

        private void frmLogin_Load( object sender, EventArgs e )
        {
            RegistrationErrorControl.dateDOB = regDOB;
        }

        private void logPassword_Enter( object sender, EventArgs e )
        {
            logPassword.Text = "";
        }

        private void logPassword_TextChanged( object sender, EventArgs e )
        {
            if ( logPassword.Text != "Password" )
            {
                logPassword.UseSystemPasswordChar = true;
                logPassword.ForeColor = Color.Black;
            }
            else
                logPassword.ForeColor = Color.Silver;
        }

        private void logUsername_Enter( object sender, EventArgs e )
        {
            logUsername.Text = "";
        }

        private void logUsername_TextChanged( object sender, EventArgs e )
        {
            if ( logUsername.Text == "Username" )
                logUsername.ForeColor = Color.Silver;
            else
                logUsername.ForeColor = Color.Black;
            if ( AccountMainControls.UserCheck( logUsername.Text, out loginAvatarPath ) )
                logAvatar.ImageLocation = loginAvatarPath;
        }

        private void regConfirm_Enter( object sender, EventArgs e )
        {
            regConfirm.Text = "";
        }

        private void regConfirm_TextChanged( object sender, EventArgs e )
        {
            if ( regConfirm.Text != "Password" )
            {
                regConfirm.UseSystemPasswordChar = true;
                regConfirm.ForeColor = Color.Black;
            }
            else
                regConfirm.ForeColor = Color.Silver;
        }

        private void regDBGAvatar_ValueChanged( object sender, EventArgs e )
        {
            regAvatar.ImageLocation = avatarTranslate( (int)regDBGAvatar.Value );
        }

        private void regEmail_Enter( object sender, EventArgs e )
        {
            regEmail.Text = "";
        }

        private void regEmail_TextChanged( object sender, EventArgs e )
        {
            if ( regEmail.Text == "Email" )
                regEmail.ForeColor = Color.Silver;
            else
                regEmail.ForeColor = Color.Black;
        }

        private void regPassword_Enter( object sender, EventArgs e )
        {
            regPassword.Text = "";
        }

        private void regPassword_TextChanged( object sender, EventArgs e )
        {
            if ( regPassword.Text != "Password" )
            {
                regPassword.UseSystemPasswordChar = true;
                regPassword.ForeColor = Color.Black;
            }
            else
                regPassword.ForeColor = Color.Silver;
        }

        private void regUsername_Enter( object sender, EventArgs e )
        {
            regUsername.Text = "";
        }

        private void regUsername_TextChanged( object sender, EventArgs e )
        {
            if ( regUsername.Text == "Username" )
                regUsername.ForeColor = Color.Silver;
            else
                regUsername.ForeColor = Color.Black;
        }

        #endregion Methods

        #endregion Methods
    }
}
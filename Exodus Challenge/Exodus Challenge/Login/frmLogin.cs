using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Exodus_Challenge.LoginSystem;
using System.Linq;

namespace Exodus_Challenge
{
    public partial class frmLogin : Form
    {

        public string loginAvatarPath;

        private bool diffSet = false;

        private difficulty regDifficulty;

        public frmLogin()
        {
            InitializeComponent();
            UserDatabaseAccess.SetupAvatars();
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
                switchToMap();
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
                regAvatar.ImageLocation,
                0.ToString()
            };
            if ( !diffSet && RegistrationErrorControl.validRegister( output, regConfirm.Text, true ) )
            {
                panelDifficulty.Visible = true;
                btnRegister.Text = "Register";
            }
            else
            {

                AccountMainControls.Register( output, regDifficulty );
                switchToMap();

            }
        }

        private void bypass_Click( object sender, EventArgs e )
        {
            if ( AccountMainControls.Login( "admin", "Admin123" ) )
            {
                switchToMap();
            }
        }

        private void switchToMap()
        {
            this.Hide();
            Program.OpenNewForm( FormType.Map );
            this.Close();
        }

        private void frmLogin_FormClosing( object sender, FormClosingEventArgs e )
        {
            if ( e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.WindowsShutDown )
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
            if ( logUsername.Text != "" && AccountMainControls.UserCheck( logUsername.Text, out loginAvatarPath ) )
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

        private void btnNextAvatar_Click( object sender, EventArgs e )
        {
            int selectedAvatarIndex = Array.IndexOf(UserDatabaseAccess.avatarArray, regAvatar.ImageLocation);
            if ( selectedAvatarIndex < UserDatabaseAccess.avatarArray.Length - 1 )
            {
                regAvatar.ImageLocation = UserDatabaseAccess.avatarArray[selectedAvatarIndex + 1];
            }
        }

        private void btnPreviousAvatar_Click( object sender, EventArgs e )
        {
            int selectedAvatarIndex = Array.IndexOf( UserDatabaseAccess.avatarArray, regAvatar.ImageLocation );
            if ( selectedAvatarIndex > 0 )
            {
                regAvatar.ImageLocation = UserDatabaseAccess.avatarArray[selectedAvatarIndex - 1];
            }
        }

        private void button1_Click( object sender, System.EventArgs e )
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = System.Environment.GetFolderPath( Environment.SpecialFolder.MyPictures );
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if ( openFileDialog1.ShowDialog() == DialogResult.OK )
            {
                string sourceFileName = openFileDialog1.FileName;
                string destFileName = Path.GetFullPath( "../../../Media/Avatars/" ) + sourceFileName.Split( '\\' ).Last();
                File.Copy( sourceFileName, destFileName, true );
                UserDatabaseAccess.AddAvatars( destFileName );
                regAvatar.ImageLocation = UserDatabaseAccess.avatarArray[UserDatabaseAccess.avatarArray.Length - 1];
            }
        }
    }
}
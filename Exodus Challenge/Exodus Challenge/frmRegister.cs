using System;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace Exodus_Challenge
{
    public partial class frmRegister : Form
    {
        #region Private Fields

        private string path = "../../userData/testUser.txt";
        private StreamWriter userData;

        #endregion Private Fields

        #region Public Constructors

        public frmRegister()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        private void addToFile(string dataToWrite)
        {
            userData = new StreamWriter(path, true);
            //userCount = File.ReadAllLines(path).Length;
            userData.WriteLine(dataToWrite);
            userData.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Form login = new frmLogin();
            login.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userInfo;
            bool validUser = false;
            if (validateUser() == "Success")
                validUser = true;
            if (validUser)
            {
                userInfo = string.Join(",", newUser(inpPass.Text));
                sendMail();
                addToFile(userInfo);
            }
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
            //
        }

        private string[] newUser(string password)
        {
            string[] output = new string[6] { inpUser.Text, inpMail.Text, password, "" + 0, "" + 0, "" + nudTempAvatar.Value };
            loginSystem.user = new User()
            {
                username = output[0],
                email = output[1],
                password = output[2],
                scoreManna = 0,
                scoreQuail = 0,
                avatar = output[5]
            };
            return output;
        }

        private void sendMail()
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("exoduschallenge@gmail.com");
            mail.To.Add(loginSystem.user.email);
            mail.Subject = "Welcome to the EXODUS CHALLENGE";
            mail.Body = "Welcome " + loginSystem.user.username + ", to an adventure of monumental proportions. Join us on a journey as we hear Moses' story - from the Egypt to the Promised Land";

            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("exoduschallenge", "ggsssd123");
            smtp.EnableSsl = true;

            smtp.Send(mail);
        }

        private string validateUser()
        {
            string[] conflictingUser;
            bool conflict = loginSystem.userCheck(inpUser.Text, out conflictingUser);
            if (conflict)
            {
                return "Username not unique";
            }
            if (inpPass.Text != inpPassConfirm.Text)
                return "Passwords do not match";
            if (!loginSystem.validEmail(inpMail.Text))
                return "Invalid Email";
            else
                return "Success";
        }

        #endregion Private Methods
    }
}
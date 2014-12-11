using System;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace Exodus_Challenge
{
    internal enum accountError
    {
        userBlank,
        userAlphaNum,
        userConflict,
        passBlank,
        passLength,
        passNoUpper,
        passNoDigit,
        passNoSymbol,
        passMismatch,
        mailBlank,
        mailInvalid,
        age
    }

    public struct User
    {
        #region Public Fields

        public string avatar;
        public string email;
        public string password;
        public int scoreManna;
        public int scoreQuail;
        public string username;

        #endregion Public Fields
    }

    public class loginSystem
    {
        #region Public Fields

        public static string[] allUserArray;

        public static string[] currentUser;
        public static DateTimePicker dateDOB;
        public static string path = "../../userData/testUser.txt";
        public static StreamReader readUserData;
        public static User user;
        public static StreamWriter writeUserData;

        #endregion Public Fields

        #region Public Methods

        public static string avatarTranslate(int avatarNumber)
        {
            switch (avatarNumber)
            {
                case 1:
                    return "../../../Media/Avatars/moses.png";

                default:
                    return "";
            }
        }

        public static bool login(string paramUsername, string paramPassword)
        {
            bool success = false;
            string[] loginAs;
            if (userCheck(paramUsername, paramPassword, out loginAs))
            {
                setUser(loginAs);
                success = true;
            }
            return success;
        }

        public static void register(string[] registerAs)
        {
            if (validRegister(registerAs))
            {
                credentialsAdd(registerAs);
                setUser(registerAs);
            }
        }

        public static void setUser(string[] userArray)
        {
            user = new User()
            {
                username = userArray[0],
                email = userArray[1],
                password = userArray[2],
                scoreManna = int.Parse(userArray[4]),
                scoreQuail = int.Parse(userArray[5]),
                avatar = userArray[6]
            };
        }

        public static bool userCheck(string username, out string avatar)
        {
            credentialsLookup();
            foreach (string record in allUserArray)
            {
                string trim = record.Trim();
                string[] trimArray = trim.Split(',');
                if (trimArray[0] == username)
                {
                    avatar = trimArray[6];
                    return true;
                }
            }
            avatar = null;
            return false;
        }

        public static bool validEmail(string email)
        {
            try { return new System.Net.Mail.MailAddress(email).Address == email; }
            catch { return false; }
        }

        public static bool validRegister(string[] input)
        {
            accountError? error;

            int age = DateTime.Now.Year - dateDOB.Value.Year;
            if (dateDOB.Value.Month < DateTime.Now.Month || (dateDOB.Value.Month == DateTime.Now.Month && dateDOB.Value.Day > DateTime.Now.Day)) age++;

            if (input[0] == "") error = accountError.userBlank;
            else if (!input[0].All(char.IsLetterOrDigit))
                error = accountError.userAlphaNum;
            else if (userCheck(input[0]))
                error = accountError.userConflict;
            else if (input[2] == "")
                error = accountError.passBlank;
            else if (input[2].Length < 8)
                error = accountError.passLength;
            else if (!input[2].Any(char.IsDigit))
                error = accountError.passNoDigit;
            else if (!input[2].Any(char.IsUpper))
                error = accountError.passNoUpper;
            else if (!input[2].Any(c => !char.IsLetterOrDigit(c)))
                error = accountError.passNoSymbol;
            else if (input[2] != input[3])
                error = accountError.passMismatch;
            else if (!validEmail(input[1]))
                error = accountError.mailInvalid;
            else if (age < 13)
                error = accountError.age;
            else error = null;
            return feedback(error);
        }

        #endregion Public Methods

        #region Internal Methods

        internal static void credentialsAdd(string[] arrWrite)
        {
            string dataToWrite = string.Join(",", arrWrite) + ";";
            writeUserData = new StreamWriter(path, true);
            writeUserData.WriteLine(dataToWrite);
            writeUserData.Close();
        }

        internal static string[] credentialsLookup()
        {
            readUserData = new StreamReader(path);
            string allUsers = readUserData.ReadToEnd();
            allUserArray = allUsers.Split(';');
            readUserData.Close();
            return allUserArray;
        }

        internal static bool userCheck(string username)
        {
            credentialsLookup();
            foreach (string record in allUserArray)
            {
                string trim = record.Trim();
                string[] trimArray = trim.Split(',');
                if (trimArray[0] == username)
                    return true;
            }
            return false;
        }

        internal static bool userCheck(string username, string password, out string[] arrayOut)
        {
            credentialsLookup();
            string[] notFound = { "" };
            foreach (string record in allUserArray)
            {
                string recordTester = record.Trim();
                string[] tempUser = recordTester.Split(',');
                try
                {
                    if (tempUser[0] == username && tempUser[2] == password) //error if tempUser[0] = null
                    {
                        arrayOut = tempUser;
                        return true;
                    }
                }
                catch { }
            }
            arrayOut = null;
            return false;
        }

        #endregion Internal Methods

        #region Private Methods

        private static bool feedback(accountError? error)
        {
            switch (error)
            {
                case accountError.userBlank:
                    MessageBox.Show("Username field cannot be left blank.", "Blank Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case accountError.userAlphaNum:
                    MessageBox.Show("Username must contain alphanumeric characters only (a-z, A-Z and 0-9).", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case accountError.userConflict:
                    MessageBox.Show("Username has already been taken. Please choose another. If you meant to login instead, please click login.", "Username Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case accountError.passBlank:
                    MessageBox.Show("Password field cannot be left blank.", "Blank Password Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case accountError.passLength:
                    MessageBox.Show("Password must be at least eight characters long.", "Password too short", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case accountError.passNoUpper:
                    MessageBox.Show("Ensure that your password contains at least one uppercase letter", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case accountError.passNoDigit:
                    MessageBox.Show("Ensure that your password contains at least one number", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case accountError.passNoSymbol:
                    MessageBox.Show("Ensure that your password contains at least one special character", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case accountError.passMismatch:
                    MessageBox.Show("Passwords do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case accountError.mailBlank:
                    MessageBox.Show("Email field cannot be left blank.", "Blank Email Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case accountError.mailInvalid:
                    MessageBox.Show("Please enter a valid email address to continue.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case accountError.age:
                    MessageBox.Show("Children age 13 or younger require permission from their parent/guardian to signup", "Too young!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                default:
                    return true;
            }
            return false;
        }

        private void sendMail()
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("exoduschallenge@gmail.com");
            mail.To.Add(user.email);
            mail.Subject = "Welcome to the EXODUS CHALLENGE";
            mail.Body = "Welcome " + user.username + ", to an adventure of monumental proportions. Join us on a journey as we hear Moses' story - from the Egypt to the Promised Land";

            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("exoduschallenge", "ggsssd123");
            smtp.EnableSsl = true;

            smtp.Send(mail);
        }

        #endregion Private Methods
    }
}
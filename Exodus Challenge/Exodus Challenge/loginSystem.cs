using System.IO;

namespace Exodus_Challenge
{
    public class loginSystem
    {
        #region Public Fields

        public static string[] currentUser;
        public static string path = "../../userData/testUser.txt";
        public static User user;
        public static string[] userArray;
        public static StreamReader userData;

        #endregion Public Fields

        #region Public Methods

        public static void debug()
        {
            if (user != null)
                System.Windows.Forms.MessageBox.Show(user.username + " " + user.password + " " + user.email);
        }

        public static void login(string username, string password)
        {
            if (userCheck(username, out currentUser))
                user = new User()
                {
                    username = currentUser[0],
                    email = currentUser[1],
                    password = currentUser[2],
                    scoreManna = int.Parse(currentUser[3]),
                    scoreQuail = int.Parse(currentUser[4]),
                    avatar = currentUser[5]
                };
        }

        public static bool userCheck(string username, out string[] arrayOut)
        {
            usersGetAll();
            string[] notFound = { "" };
            foreach (string record in userArray)
            {
                string recordTester = record.Trim();
                string[] tempUser = recordTester.Split(',');
                if (tempUser[0] == username)
                {
                    arrayOut = tempUser;
                    return true;
                }
            }
            arrayOut = notFound;
            return false;
        }

        public static string[] usersGetAll()
        {
            userData = new StreamReader(path);
            string allUsers = userData.ReadToEnd();
            userArray = allUsers.Split(';');
            userData.Close();
            return userArray;
        }

        public static bool validEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        #endregion Public Methods
    }
}
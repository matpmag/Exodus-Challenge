﻿using System;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace Exodus_Challenge
{
	namespace LoginSystem
	{
		public enum difficulty
		{
			novice,
			apprentice,
			master
		}

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
			public string userAvatar;
			public difficulty? userDifficulty;
			public string userEmail;
			public int userID;
			public string userPassword;
			public int userScoreManna;
			public int userScoreQuail;
			public string userUsername;
			public int userZoneUnlock;
		}

		public class LoginOrRegister
		{
			public static bool login(string paramUsername, string paramPassword)
			{
				bool success = false;
				string[] userRecord;
				string[] loginAs = new string[8];
				difficulty? userDifficultyFromFile = null;
				if (UserDatabaseAccess.userCheck(paramUsername, paramPassword, out userRecord))
				{
					for (int i = 0; i < userRecord.Length - 1; i++)
					{
						loginAs[i] = userRecord[i];
					}
					switch (userRecord[8])
					{
						case "novice":
							userDifficultyFromFile = difficulty.novice;
							break;

						case "apprentice":
							userDifficultyFromFile = difficulty.apprentice;
							break;

						case "master":
							userDifficultyFromFile = difficulty.master;
							break;
					}
					UserDatabaseAccess.setUser(loginAs, userDifficultyFromFile);
					success = true;
				}
				return success;
			}

			public static void register(string[] registerAs, difficulty regDifficulty)
			{
				string[] fullCredentials = new string[registerAs.Length + 1];
				fullCredentials[0] = UserDatabaseAccess.uniqueID.ToString();
				for (int i = 1; i < registerAs.Length; i++)
				{
					fullCredentials[i] = registerAs[i - 1];
				}
				if (RegistrationErrorControl.validRegister(registerAs, false))
				{
					UserDatabaseAccess.credentialsAdd(fullCredentials, regDifficulty);
					UserDatabaseAccess.setUser(fullCredentials, regDifficulty);
					UserDatabaseAccess.sendMail();
				}
			}

			public static bool userCheck(string username, out string avatar)
			{
				UserDatabaseAccess.credentialsLookup();
				foreach (string record in UserDatabaseAccess.allUserArray)
				{
					string trim = record.Trim();
					string[] trimArray = trim.Split(',');
					if (trimArray[1] == username)
					{
						avatar = trimArray[7];
						return true;
					}
				}
				avatar = null;
				return false;
			}
		}

		public class RegistrationErrorControl
		{
			public static DateTimePicker dateDOB;

			public static bool validRegister(string[] input, bool showFeedback)
			{
				accountError? error;

				int age = DateTime.Now.Year - dateDOB.Value.Year;
				if (dateDOB.Value.Month < DateTime.Now.Month ||
				   (dateDOB.Value.Month == DateTime.Now.Month &&
					dateDOB.Value.Day > DateTime.Now.Day))
					age++;
				if (input[0] == "") error = accountError.userBlank;
				else if (!input[0].All(char.IsLetterOrDigit))
					error = accountError.userAlphaNum;
				else if (UserDatabaseAccess.userCheck(input[0]))
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
				else if (!UserDatabaseAccess.validEmail(input[1]))
					error = accountError.mailInvalid;
				else if (age < 13)
					error = accountError.age;
				else error = null;
				return feedback(error, showFeedback);
			}

			private static bool feedback(accountError? error, bool showFeedback)
			{
				string errorMessageContent;
				string errorMessageDiscription;
				switch (error)
				{
					case accountError.userBlank:
						errorMessageContent = "Username field cannot be left blank.";
						errorMessageDiscription = "Blank Username";
						break;

					case accountError.userAlphaNum:
						errorMessageContent = "Username must contain alphanumeric characters only (a-z, A-Z and 0-9).";
						errorMessageDiscription = "Invalid Username";
						break;

					case accountError.userConflict:
						errorMessageContent = "Username has already been taken. Please choose another. If you meant to login instead, please click login.";
						errorMessageDiscription = "Username Already Exists";
						break;

					case accountError.passBlank:
						errorMessageContent = "Password field cannot be left blank.";
						errorMessageDiscription = "Blank Password Field";
						break;

					case accountError.passLength:
						errorMessageContent = "Password must be at least eight characters long.";
						errorMessageDiscription = "Password too short";
						break;

					case accountError.passNoUpper:
						errorMessageContent = "Ensure that your password contains at least one uppercase letter";
						errorMessageDiscription = "Invalid Password";
						break;

					case accountError.passNoDigit:
						errorMessageContent = "Ensure that your password contains at least one number";
						errorMessageDiscription = "Invalid Password";
						break;

					// case accountError.passNoSymbol: errorMessageContent = "Ensure that your
					// password contains at least one special character"; errorMessageDiscription =
					// "Invalid Password" break;

					case accountError.passMismatch:
						errorMessageContent = "Passwords do not match.";
						errorMessageDiscription = "Password Mismatch";
						break;

					case accountError.mailBlank:
						errorMessageContent = "Email field cannot be left blank.";
						errorMessageDiscription = "Blank Email Field";
						break;

					case accountError.mailInvalid:
						errorMessageContent = "Please enter a valid email address to continue.";
						errorMessageDiscription = "Invalid Email";
						break;

					case accountError.age:
						errorMessageContent = "Children age 13 or younger require permission from their parent/guardian to signup";
						errorMessageDiscription = "Too young!";
						break;

					default:
						return true;
				}
				if (showFeedback)
				{
					MessageBox.Show(errorMessageContent, errorMessageDiscription, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				return false;
			}
		}
		public class UserDatabaseAccess
		{
			public static string[] allUserArray;
			public static string pathProgressSerializer = "../../userdata/userScores.dat";
			public static string pathUserData = "../../userdata/testUser.txt";
			public static BinaryReader readUserBinary;
			public static StreamReader readUserData;
			public static User user;
			public static BinaryWriter writeUserBinary;
			public static StreamWriter writeUserData;

			public static int uniqueID
			{
				get
				{
					int UID;
					using (StreamReader getUID = new StreamReader("../../userdata/UniqueID.txt"))
					{
						UID = getUID.Read();
						UID++;
					}
					using (StreamWriter setUID = new StreamWriter("../../userdata/UniqueID.txt"))
					{
						setUID.Write(UID);
					}
					return UID;
				}
			}

			private static void binaryWrite(string[] arrWrite)
			{
			}

			internal static void credentialsAdd(string[] arrWrite, difficulty regDifficulty)
			{
				writeUserData = new StreamWriter(pathUserData, true);
				string dataToWrite = string.Join(",", arrWrite) + "," + regDifficulty.ToString() + ";";
				writeUserData.WriteLine(dataToWrite);
				writeUserData.Close();
			}

			internal static string[] credentialsLookup()
			{
				readUserData = new StreamReader(pathUserData);
				string allUsers = readUserData.ReadToEnd();
				allUserArray = allUsers.Split(';');
				readUserData.Close();
				return allUserArray;
			}

			internal static void sendMail()
			{
				MailMessage mail = new MailMessage();
				SmtpClient smtp = new SmtpClient("smtp.gmail.com");

				mail.From = new MailAddress("exoduschallenge@gmail.com");
				mail.To.Add(user.userEmail);
				mail.Subject = "Welcome to the EXODUS CHALLENGE";
				mail.Body = "Welcome " + user.userUsername + ", to an adventure of monumental proportions. Join us on a journey as we hear Moses' story - from the Egypt to the Promised Land";

				smtp.Port = 587;
				smtp.Credentials = new System.Net.NetworkCredential("exoduschallenge", "ggsssd123");
				smtp.EnableSsl = true;

				smtp.Send(mail);
			}

			internal static void setUser(string[] userArray, difficulty? regDifficulty)
			{
				user = new User()
				{
					userID = int.Parse(userArray[0]),
					userUsername = userArray[1],
					userEmail = userArray[2],
					userPassword = userArray[3],
					userScoreManna = int.Parse(userArray[5]),
					userScoreQuail = int.Parse(userArray[6]),
					userAvatar = userArray[7],
					userDifficulty = regDifficulty
				};
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
				foreach (string record in allUserArray)
				{
					string recordTester = record.Trim();
					string[] tempUser = recordTester.Split(',');
					try
					{
						if (tempUser[1] == username && tempUser[3] == password)
						{
							arrayOut = tempUser;
							return true;
						}
					}
					catch {  }
				}
				arrayOut = null;
				return false;
			}

			internal static bool validEmail(string email)
			{
				try { return new System.Net.Mail.MailAddress(email).Address == email; }
				catch { return false; }
			}
		}
	}
}
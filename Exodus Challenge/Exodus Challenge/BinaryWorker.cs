using Exodus_Challenge.LoginSystem;
using System;
using System.Collections.Generic;
using System.IO;

namespace Exodus_Challenge
{
    class BinaryWorker
    {
        private static byte[] binaryData;
        private static IList<Byte> byteList = new List<byte>();
        private static IList<int> intList = new List<int>();
        private static StreamWriter FileWriter;
        private static StreamReader FileReader;
        private static FileStream inFile;
        private static string pathProgressTemporaryFile = "../../userData/progressTempFile.temp";
        private static string pathProgressOutputFile = "../../userData/outputbin.bin";

        public void aaatesteraaa()
        {
            int[] progress = new int[]
            {
                UserDatabaseAccess.user.userID,
                UserDatabaseAccess.user.userZoneUnlock,
                UserDatabaseAccess.user.userScoreManna,
                UserDatabaseAccess.user.userScoreQuail
            };
        }

        public void Setup()
        {
            File.Delete(pathProgressTemporaryFile);
            File.Delete(pathProgressOutputFile);
            int[] user1Score = new int[] { 999991, 54, 300, 100 };
            int[] user2Score = new int[] { 2, 32, 600, 110 };
            int[] user3Score = new int[] { 12, 332, 4600, 5110 };
            WriteBinary(user1Score);
            WriteBinary(user2Score);
            WriteBinary(user3Score);
            int[] userScore;
            ReadBinary(12, out userScore);
        }

        static void WriteBinary(int[] input)
        {
            byteList.Clear();
            #region Prepare Scores For Conversion
            string progressToWrite = string.Format("{0,8:D8}{1,8:D8}{2,8:D8}{3,8:D8}", input[0], input[1], input[2], input[3]);

            using (FileWriter = new StreamWriter(pathProgressTemporaryFile))
            {
                FileWriter.Write(progressToWrite);
            }
            #endregion

            #region Read From Temporary File, Then Delete
            using (inFile = new FileStream(pathProgressTemporaryFile, FileMode.Open))
            {
                binaryData = new byte[inFile.Length];
                long bytesRead = inFile.Read(binaryData, 0, (int)inFile.Length);
            }
            File.Delete(pathProgressTemporaryFile);
            #endregion

            #region Convert To Binary
            foreach (byte val in binaryData)
            {
                byteList.Add(val);
            }
            string[] bitStringArray = new string[byteList.Count];
            for (int i = 0; i < byteList.Count; i++)
            {
                bitStringArray[i] = Convert.ToString(byteList[i], 2).PadLeft(8, '0');
            }
            #endregion

            #region Write Bits To File
            string binaryToWrite = string.Join("", bitStringArray);
            binaryToWrite = binaryToWrite.Replace(" ", "");

            using (FileWriter = new StreamWriter("../../outputbin.bin", true))
            {
                FileWriter.WriteLine(binaryToWrite);
            }
            #endregion
        }

        static void ReadBinary(int userID, out int[] userProgress)
        {
            userProgress = new int[4];
            int numberOfRecords = File.ReadAllLines("../../outputbin.bin").Length;
            using (FileReader = new StreamReader("../../outputbin.bin"))
            {
                for (int i = 0; i < numberOfRecords; i++)
                {
                    string record = FileReader.ReadLine();
                    char[] recordCharArray = record.ToCharArray();
                    char[] userIDAsBinary = new char[64];
                    Array.Copy(recordCharArray, 0, userIDAsBinary, 0, 64);
                    int recoveredUserID = int.Parse(binaryToText(userIDAsBinary));
                    if (userID == recoveredUserID)
                    {
                        char[] furthestUnlockAsBinary = new char[64];
                        char[] mannaAsBinary = new char[64];
                        char[] quailAsBinary = new char[64];
                        Array.Copy(recordCharArray, 64, furthestUnlockAsBinary, 0, 64);
                        Array.Copy(recordCharArray, 128, mannaAsBinary, 0, 64);
                        Array.Copy(recordCharArray, 192, quailAsBinary, 0, 64);

                        int recoveredFurthestUnlock = int.Parse(binaryToText(furthestUnlockAsBinary));
                        int recoveredManna = int.Parse(binaryToText(mannaAsBinary));
                        int recoveredQuail = int.Parse(binaryToText(quailAsBinary));

                        userProgress[0] = recoveredUserID;
                        userProgress[1] = recoveredFurthestUnlock;
                        userProgress[2] = recoveredManna;
                        userProgress[3] = recoveredQuail;
                    }
                }
            }
        }


        static string binaryToText(char[] input)
        {
            int result;
            int bitVal;
            char[] digitAsBinaryCharArr = new char[8];
            int[] digitAsBinaryIntArr = new int[8];
            List<char> translatedList = new List<char>();
            for (int i = 0; i < 64; i += 8)
            {
                result = 0;
                bitVal = 1;
                Array.Copy(input, i, digitAsBinaryCharArr, 0, 8);
                for (int j = 0; j < digitAsBinaryCharArr.Length; j++)
                {
                    digitAsBinaryIntArr[j] = int.Parse(digitAsBinaryCharArr[j].ToString());
                }

                for (int m = digitAsBinaryIntArr.Length; m > 0; m--)
                {
                    result += digitAsBinaryIntArr[m - 1] * bitVal;
                    bitVal *= 2;
                }
                translatedList.Add((char)result);
            }
            return string.Join("", translatedList.ToArray());
        }
    }
}
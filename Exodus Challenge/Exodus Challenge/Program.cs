using System;
using System.Windows.Forms;

namespace Exodus_Challenge
{
    internal static class Program
    {
        #region Private Methods

        #region Methods

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new frmZ2B() );
            //new BinaryWorker().Setup();
        }

        #endregion Methods

        #endregion Private Methods
    }
}
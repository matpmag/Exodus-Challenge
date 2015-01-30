using System;
using System.Windows.Forms;

namespace Exodus_Challenge
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new frmTitle() );
        }

        public static void OpenNewForm(FormType formToOpenType)
        {
            Form formToOpen;
            bool unassigned = false;

            switch ( formToOpenType )
            {

                case FormType.Title:
                    formToOpen = new frmTitle();
                    break;
                case FormType.Login:
                    formToOpen = new frmLogin();
                    break;
                case FormType.Map:
                    formToOpen = new frmLevelSelect();
                    break;
                case FormType.VideoPlayer:
                    formToOpen = new VideoPlayer();
                    break;

                case FormType.Zone1Easy:
                    formToOpen = new frmZ1E();
                    break;
                case FormType.Zone1Medium:
                    formToOpen = new frmZ1M();
                    break;
                case FormType.Zone1Hard:
                    formToOpen = new frmZ1H();
                    break;
                case FormType.Zone1Boss:
                    formToOpen = new frmZ1B();
                    break;

                case FormType.Zone2Easy:
                    formToOpen = new frmZ2E();
                    break;
                case FormType.Zone2Medium:
                    formToOpen = new frmZ2M();
                    break;
                case FormType.Zone2Hard:
                    formToOpen = new frmZ2H();
                    break;
                case FormType.Zone2Boss:
                    formToOpen = new frmZ2B();
                    break;

                case FormType.Zone3Easy:
                    formToOpen = new frmZ3E();
                    break;
                case FormType.Zone3Medium:
                    formToOpen = new frmZ3M();
                    break;
                case FormType.Zone3Hard:
                    formToOpen = new frmZ3H();
                    break;
                case FormType.Zone3Boss:
                    formToOpen = new frmZ3B();
                    break;

                case FormType.Zone4Easy:
                    formToOpen = new frmZ4E();
                    break;
                case FormType.Zone4Medium:
                    formToOpen = new frmZ4M();
                    break;
                case FormType.Zone4Hard:
                    formToOpen = new frmZ4H();
                    break;
                case FormType.Zone4Boss:
                    formToOpen = new frmZ4B();
                    break;
                default:
                    unassigned = true;
                    formToOpen = new Form();
                    break;
            }
            if (!unassigned)
                formToOpen.Show();
        }
    }
    public enum FormType
    {
        Title,
        Login,
        Map,
        VideoPlayer,

        Zone1Easy,
        Zone1Medium,
        Zone1Hard,
        Zone1Boss,

        Zone2Easy,
        Zone2Medium,
        Zone2Hard,
        Zone2Boss,

        Zone3Easy,
        Zone3Medium,
        Zone3Hard,
        Zone3Boss,

        Zone4Easy,
        Zone4Medium,
        Zone4Hard,
        Zone4Boss,
    }
}
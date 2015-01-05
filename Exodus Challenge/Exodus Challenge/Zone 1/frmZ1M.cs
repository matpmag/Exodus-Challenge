using System.Windows.Forms;

namespace Exodus_Challenge
{
    public partial class frmZ1M : Form
    {
        #region Private Methods

        #region Methods

        private void checkAll()
        {
            bool count = false;
            if ( !checkAns( arrDn1, ansDn1 ) )
                count = true;
            if ( !checkAns( arrDn2, ansDn2 ) )
                count = true;
            if ( !checkAns( arrDn3, ansDn3 ) )
                count = true;
            if ( !checkAns( arrDn6, ansDn6 ) )
                count = true;
            if ( !checkAns( arrDn9, ansDn9 ) )
                count = true;
            if ( !checkAns( arrAc4, ansAc4 ) )
                count = true;
            if ( !checkAns( arrAc5, ansAc5 ) )
                count = true;
            if ( !checkAns( arrAc7, ansAc7 ) )
                count = true;
            if ( !checkAns( arrAc8, ansAc8 ) )
                count = true;
            if ( !checkAns( arrAc10, ansAc10 ) )
                count = true;
            if ( !checkAns( arrAc11, ansAc11 ) )
                count = true;
            if ( !checkAns( arrAc12, ansAc12 ) )
                count = true;
            if ( !count )
                MessageBox.Show( "Congratulations!!!" );
        }

        private bool checkAns( TextBox[] tbxArray, char[] ansArray )
        {
            int count = 0;
            for ( int i = 0; i < tbxArray.Length; i++ )
            {
                if ( tbxArray[i].Text == ansArray[i].ToString() )
                    count++;
            }
            if ( count == tbxArray.Length )
            {
                ticker.Stop();
                return true;
            }
            else
                return false;
        }

        private void setupArrays()
        {
            arrDown = new TextBox[5][]
            {
                arrDn1 = new TextBox[] { tbxA11, tbxB11, tbxC11, tbxD11, tbxE11 },
                arrDn2 = new TextBox[] { tbxB1, tbxC1, tbxD1, tbxE1 },
                arrDn3 = new TextBox[] { tbxB5, tbxC5, tbxD5, tbxE5, tbxF5 },
                arrDn6 = new TextBox[] { tbxC9, tbxD9, tbxE9, tbxF9, tbxG9, tbxH9, tbxI9, tbxJ9 },
                arrDn9 = new TextBox[] { tbxF7, tbxG7, tbxH7 },
            };

            arrAccross = new TextBox[7][]
            {
                arrAc4 = new TextBox[] { tbxB10, tbxB11, tbxB12, tbxB13 },
                arrAc5 = new TextBox[] { tbxC4, tbxC5, tbxC6, tbxC7, tbxC8, tbxC9 },
                arrAc7 = new TextBox[] { tbxE1, tbxE2, tbxE3, tbxE4, tbxE5, tbxE6 },
                arrAc8 = new TextBox[] { tbxE8, tbxE9, tbxE10, tbxE11, tbxE12 },
                arrAc10 = new TextBox[] { tbxG6, tbxG7, tbxG8, tbxG9, tbxG10, tbxG11 },
                arrAc11 = new TextBox[] { tbxI9, tbxI10, tbxI11, tbxI12, tbxI13 },
                arrAc12 = new TextBox[] { tbxJ4, tbxJ5, tbxJ6, tbxJ7, tbxJ8, tbxJ9 },
            };

            ansDown = new char[5][]
            {
                ansDn1 = new char[] { 'M', 'O', 'S', 'E', 'S' },
                ansDn2 = new char[] { 'W', 'A', 'S', 'H' },
                ansDn3 = new char[] { 'R', 'I', 'V', 'E', 'R' },
                ansDn6 = new char[] { 'D', 'A', 'U', 'G', 'H', 'T', 'E', 'R' },
                ansDn9 = new char[] { 'B', 'O', 'Y'},
            };

            ansAccross = new char[7][]
            {
                ansAc4 = new char[] { 'B', 'O', 'A', 'T' },
                ansAc5 = new char[] { 'K', 'I', 'L', 'L', 'E', 'D' },
                ansAc7 = new char[] { 'H', 'E', 'B', 'R', 'E', 'W' },
                ansAc8 = new char[] { 'N', 'U', 'R', 'S', 'E' },
                ansAc10 = new char[] { 'M', 'O', 'T', 'H', 'E', 'R' },
                ansAc11 = new char[] { 'E', 'G', 'Y', 'P', 'T' },
                ansAc12 = new char[] { 'S', 'I', 'S', 'T', 'E', 'R', },
            };
        }

        private void setupHints()
        {
            string txtdn1 = "(1 Down)";
            string txtdn2 = "(2 Down)";
            string txtdn3 = "(3 Down)";
            string txtdn6 = "(6 Down)";
            string txtdn9 = "(9 Down)";

            string txtac4 = "(4 Across)";
            string txtac5 = "(5 Across)";
            string txtac7 = "(7 Across)";
            string txtac8 = "(8 Across)";
            string txtac10 = "(10 Across)";
            string txtac11 = "(11 Across)";
            string txtac12 = "(12 Across)";

            string hints =
                "The ruler of " + txtac11 + " had decreed that all " + txtdn9 + " babies were to be " + txtac5 + ".\r\n" +
                "One family however decided to disobey the order. Instead they made a small " + txtac4 + "\r\n" +
                " and hid the child in it near the " + txtdn3 + " bank. Pharaoh's " + txtdn6 + " came to " + txtdn2 + "\r\n" +
                "in the river and discovered the" + txtac7 + " child and she decided to care for it.\r\n" +
                "The child's " + txtac12 + " meanwhile had been watching and volunteered to get a " + txtac8 + ".\r\n" +
                "Of course she got her " + txtac10 + ". Eventually the child was big enough\r\n" +
                "to live with Pharaoh's family. He was given the name " + txtdn1 + ".";
            tbxHints.Text = hints;
        }

        private void tbx_TextChanged( object sender, System.EventArgs e )
        {
            checkAll();
        }

        private void ticker_Tick( object sender, System.EventArgs e )
        {
            time += 0.1;
            lblTime.Text = time.ToString();
        }

        #endregion Methods

        #endregion Private Methods



        #region Fields

        private char[] ansAc10;

        private char[] ansAc11;

        private char[] ansAc12;

        private char[] ansAc4;

        private char[] ansAc5;

        private char[] ansAc7;

        private char[] ansAc8;

        private char[][] ansAccross;

        private char[] ansDn1;

        private char[] ansDn2;

        private char[] ansDn3;

        private char[] ansDn6;

        private char[] ansDn9;

        private char[][] ansDown;

        private TextBox[] arrAc10;

        private TextBox[] arrAc11;

        private TextBox[] arrAc12;

        private TextBox[] arrAc4;

        private TextBox[] arrAc5;

        private TextBox[] arrAc7;

        private TextBox[] arrAc8;

        private TextBox[][] arrAccross;

        private TextBox[] arrDn1;

        private TextBox[] arrDn2;

        private TextBox[] arrDn3;

        private TextBox[] arrDn6;

        private TextBox[] arrDn9;

        private TextBox[][] arrDown;

        private double time = 0;

        #endregion Fields

        #region Constructors

        public frmZ1M()
        {
            InitializeComponent();
            setupHints();
            setupArrays();
        }

        #endregion Constructors

        private void btnQuit_Click( object sender, System.EventArgs e )
        {
            this.Close();
            Form lvl = new LevelSelect();
            lvl.Show();
        }
    }
}
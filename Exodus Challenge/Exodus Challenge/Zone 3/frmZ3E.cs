using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Exodus_Challenge
{
    public partial class frmZ3E : Form
    {
        #region Private Methods

        #region Methods

        private void checkAns()
        {
            if ( btnA.Text == c1 &&
               btnB.Text == c2 &&
               btnC.Text == c3 &&
               btnD.Text == c4 &&
               btnE.Text == c5 &&
               btnF.Text == c6 &&
               btnG.Text == c7 &&
               btnH.Text == c8 &&
               btnI.Text == c9 &&
               btnJ.Text == c10 )
                MessageBox.Show( "CONGRATULATIONS!!!" );
            ;
        }

        private void setAns( Button btn, byte val )
        {
            switch ( val )
            {
                case 1:
                    btn.Text = c1;
                    break;

                case 2:
                    btn.Text = c2;
                    break;

                case 3:
                    btn.Text = c3;
                    break;

                case 4:
                    btn.Text = c4;
                    break;

                case 5:
                    btn.Text = c5;
                    break;

                case 6:
                    btn.Text = c6;
                    break;

                case 7:
                    btn.Text = c7;
                    break;

                case 8:
                    btn.Text = c8;
                    break;

                case 9:
                    btn.Text = c9;
                    break;

                case 10:
                    btn.Text = c10;
                    break;
            }
        }

        private void shuffle()
        {
            poss = new byte[10];
            for ( int i = 0; i < poss.Length; i++ )
            {
                poss[i] = (byte)( i + 1 );
            }
            shuffled = RandomiseBytes( poss );
            setAns( btnA, shuffled[0] );
            setAns( btnB, shuffled[1] );
            setAns( btnC, shuffled[2] );
            setAns( btnD, shuffled[3] );
            setAns( btnE, shuffled[4] );
            setAns( btnF, shuffled[5] );
            setAns( btnG, shuffled[6] );
            setAns( btnH, shuffled[7] );
            setAns( btnI, shuffled[8] );
            setAns( btnJ, shuffled[9] );
        }

        private void source( Button original )
        {
            from.btn = original;
            original.DoDragDrop( original.Text, DragDropEffects.All );
        }

        private void swap( Button reciver )
        {
            to.btn = reciver;
            from.txt = from.btn.Text;
            to.txt = to.btn.Text;
            to.btn.Text = from.txt;
            from.btn.Text = to.txt;
            checkAns();
        }

        #endregion Methods

        #endregion Private Methods

        #region Private Structs

        #region Structs

        private struct from
        {
            #region Public Fields

            #region Fields

            public static Button btn;
            public static string txt;

            #endregion Fields

            #endregion Public Fields
        };

        private struct to
        {
            #region Public Fields

            #region Fields

            public static Button btn;
            public static string txt;

            #endregion Fields

            #endregion Public Fields
        };

        #endregion Structs

        #endregion Private Structs



        #region Fields

        public string c1 = "Keep God First";

        public string c10 = "Don't covet";

        public string c2 = "Don't worship false gods";

        public string c3 = "Don't use God's name in vain";

        public string c4 = "Keep the rest day holy";

        public string c5 = "Obey your parents";

        public string c6 = "Don't murder";

        public string c7 = "Don't commit adultery";

        public string c8 = "Don't steal";

        public string c9 = "Don't lie";

        private static Random random = new Random();

        private byte[] poss;

        private byte[] shuffled;

        #endregion Fields

        #region Constructors

        public frmZ3E()
        {
            InitializeComponent();
            shuffle();
        }

        #endregion Constructors

        public byte[] RandomiseBytes( byte[] input )
        {
            List<KeyValuePair<int, byte>> list = new List<KeyValuePair<int, byte>>();

            foreach ( byte s in input )
            {
                list.Add( new KeyValuePair<int, byte>( random.Next(), s ) );
            }

            var sorted = from item in list
                         orderby item.Key
                         select item;

            byte[] shuffle = new byte[input.Length];

            int i = 0;
            foreach ( KeyValuePair<int, byte> pair in sorted )
            {
                shuffle[i] = pair.Value;
                i++;
            }
            return shuffle;
        }

        private void btn_DragDrop( object sender, DragEventArgs e )
        {
            swap( sender as Button );
        }

        private void btn_DragEnter( object sender, DragEventArgs e )
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btn_MouseDown( object sender, MouseEventArgs e )
        {
            source( sender as Button );
        }

        private void btnQuit_Click( object sender, EventArgs e )
        {
            this.Close();
            Form lvl = new LevelSelect();
            lvl.Show();
        }
    }
}
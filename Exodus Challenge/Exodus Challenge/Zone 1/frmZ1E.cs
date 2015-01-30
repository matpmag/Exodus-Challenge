using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Exodus_Challenge
{
    public partial class frmZ1E : Level
    {
        private Queue<byte> ansOrder = new Queue<byte>();

        private List<byte> ansPoss = new List<byte>();

        private string path = "../../../Media/Images/Baby/";

        private Random random = new Random();

        public frmZ1E()
        {
            InitializeComponent();
            for ( byte i = 1; i <= 6; i++ )
            {
                ansPoss.Add( i );
            }
            pbxA.AllowDrop = true;
            pbxB.AllowDrop = true;
            pbxC.AllowDrop = true;
            pbxD.AllowDrop = true;
            pbxE.AllowDrop = true;
            pbxF.AllowDrop = true;
            setupOriginalOrder();
        }

        private void check()
        {
            if ( pbxA.ImageLocation == "../../../Media/Images/Baby/slaves.png" &&
                pbxB.ImageLocation == "../../../Media/Images/Baby/pharoh.png" &&
                pbxC.ImageLocation == "../../../Media/Images/Baby/babys.png" &&
                pbxD.ImageLocation == "../../../Media/Images/Baby/basket.png" &&
                pbxE.ImageLocation == "../../../Media/Images/Baby/daughter.png" &&
                pbxF.ImageLocation == "../../../Media/Images/Baby/nurse.png" )
            {
                MessageBox.Show( "Correct" );
            }
        }

        private string imgLoc( byte index )
        {
            switch ( index )
            {
                case 1:
                    return "slaves.png";

                case 2:
                    return "pharoh.png";

                case 3:
                    return "babys.png";

                case 4:
                    return "basket.png";

                case 5:
                    return "daughter.png";

                case 6:
                    return "nurse.png";

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private string matchCaptions( string imgLoc )
        {
            switch ( imgLoc )
            {
                case "../../../Media/Images/Baby/slaves.png":
                    return "<SlavesCaptionGoesHere>";

                case "../../../Media/Images/Baby/pharoh.png":
                    return "<PharohCaptionGoesHere>";

                case "../../../Media/Images/Baby/babys.png":
                    return "<BabysCaptionGoesHere>";

                case "../../../Media/Images/Baby/basket.png":
                    return "<BasketCaptionGoesHere>";

                case "../../../Media/Images/Baby/daughter.png":
                    return "<DaughterCaptionGoesHere>";

                case "../../../Media/Images/Baby/nurse.png":
                    return "<NurseCaptionGoesHere>";

                default:
                    throw new ArgumentException();
            }
        }

        private void pbx_DragDrop( object sender, DragEventArgs e )
        {
            to.pbx = sender as PictureBox;
            from.img = from.pbx.ImageLocation;
            to.img = to.pbx.ImageLocation;
            to.pbx.ImageLocation = from.img;
            from.pbx.ImageLocation = to.img;
            updateCaptions();
            check();
        }

        private void pbx_DragEnter( object sender, DragEventArgs e )
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pbx_MouseDown( object sender, MouseEventArgs e )
        {
            from.pbx = sender as PictureBox;
            from.pbx.DoDragDrop( from.pbx.Image, DragDropEffects.Copy );
        }

        private void setupOriginalOrder()
        {
            for ( int i = 1; i <= 6; i++ )
            {
                int randomIndex = random.Next( 0, ansPoss.Count );
                byte toUse = ansPoss.ElementAt( randomIndex );
                ansPoss.Remove( toUse );
                ansOrder.Enqueue( toUse );
            }
            pbxA.ImageLocation = path + imgLoc( ansOrder.Dequeue() );
            pbxB.ImageLocation = path + imgLoc( ansOrder.Dequeue() );
            pbxC.ImageLocation = path + imgLoc( ansOrder.Dequeue() );
            pbxD.ImageLocation = path + imgLoc( ansOrder.Dequeue() );
            pbxE.ImageLocation = path + imgLoc( ansOrder.Dequeue() );
            pbxF.ImageLocation = path + imgLoc( ansOrder.Dequeue() );
        }

        private void updateCaptions()
        {
            tbxA.Text = matchCaptions( pbxA.ImageLocation );
            tbxB.Text = matchCaptions( pbxB.ImageLocation );
            tbxC.Text = matchCaptions( pbxC.ImageLocation );
            tbxD.Text = matchCaptions( pbxD.ImageLocation );
            tbxE.Text = matchCaptions( pbxE.ImageLocation );
            tbxF.Text = matchCaptions( pbxF.ImageLocation );
        }

        private struct from
        {
            public static string img;
            public static PictureBox pbx;
        };

        private struct to
        {
            public static string img;
            public static PictureBox pbx;
        };
    }
}
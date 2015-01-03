using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exodus_Challenge
{
    public partial class frmZ2E : Form
    {

        #region Private Methods

        private void next()
        {
            if (ansOrder.Count > 0)
            {
                pbxCurrent.Image = pbxNext.Image;
                correctAns = nextAns;
                byte getNext = ansOrder.Dequeue();
                nextAns = getNext;
                pbxNext.ImageLocation = path + imgLoc(getNext);
            }
            else if (!allAnswered)
            {
                pbxCurrent.Image = pbxNext.Image;
                correctAns = nextAns;
                nextAns = 0;
                pbxNext.ImageLocation = "";
                allAnswered = true;
            }
            else
            {
                correctAns = 0;
                pbxCurrent.Image = null;
            }
        }

        private void setupAnsOrder()
        {
            for (int i = 1; i <= 10; i++)
            {
                int randomIndex = random.Next(0, ansPoss.Count);
                byte toUse = ansPoss.ElementAt(randomIndex);
                ansPoss.Remove(toUse);
                ansOrder.Enqueue(toUse);
            }
        }

        private void setupPbxFirst2()
        {
            byte getFirst = ansOrder.Dequeue();
            correctAns = getFirst;
            pbxCurrent.ImageLocation = path + imgLoc(getFirst);
            byte getSecond = ansOrder.Dequeue();
            nextAns = getSecond;
            pbxNext.ImageLocation = path + imgLoc(getSecond);
        }

        #endregion Private Methods

        #region Private Fields

        private bool allAnswered = false;

        private Queue<byte> ansOrder = new Queue<byte>();

        private List<byte> ansPoss = new List<byte>();

        private byte correctAns;

        private byte nextAns;

        private string path = "../../../Media/Images/Plagues/";

        private Random random = new Random();

        private int totalCorrect = 0;

        #endregion Private Fields

        #region Public Constructors

        public frmZ2E()
        {
            InitializeComponent();
            for (byte i = 1; i <= 10; i++)
            {
                ansPoss.Add(i);
            }
            setupAnsOrder();
            setupPbxFirst2();
        }

        #endregion Public Constructors

        private string imgLoc(byte index)
        {
            switch (index)
            {
                case 1:
                    return "plague1.png";

                case 2:
                    return "plague2.png";

                case 3:
                    return "plague3.png";

                case 4:
                    return "plague4.png";

                case 5:
                    return "plague5.png";

                case 6:
                    return "plague6.png";

                case 7:
                    return "plague7.png";

                case 8:
                    return "plague8.png";

                case 9:
                    return "plague9.png";

                case 10:
                    return "plague10.png";

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void inpAns_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (inpAns.Text == correctAns.ToString())
                    totalCorrect++;
                inpAns.Text = "";
                label1.Text = totalCorrect.ToString();
                next();
            }
        }
    }
}
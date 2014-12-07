using System.Windows.Forms;

namespace Exodus_Challenge
{
    public partial class LevelSelect : Form
    {
        #region Public Constructors

        public LevelSelect()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        private void btnlv4_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Form lvl4 = new frmQReorder();
            lvl4.Show();
        }

        private void btnlvlQ1_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Form lvl1 = new frmQCrossword();
            lvl1.Show();
        }
    }
}
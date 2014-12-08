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
            Form frmQ4 = new frmQReorder();
            frmQ4.Show();
        }

        private void btnlvlQ1_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Form frmQ1 = new frmQCrossword();
            frmQ1.Show();
        }

        private void btnlvlG1_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Form frmGame1 = new frmWackamole();
            frmGame1.Show();
        }
    }
}
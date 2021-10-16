using System.Windows.Forms;

namespace Ventus
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {
            new Form1 { MdiParent = this }.Show();
        }

        private void toolStripButton2_Click(object sender, System.EventArgs e)
        {
            new Form2 { MdiParent = this }.Show();
        }
    }
}

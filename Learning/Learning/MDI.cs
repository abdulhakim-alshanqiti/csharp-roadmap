using System;
using System.Windows.Forms;

namespace Learning
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }
        private readonly Form Subform = new MDISubForm();

        private void button1_Click(object sender, EventArgs e)
        {
            Subform.MdiParent = this;
            Subform.Show();
        }

        private void findXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Find X Screen");
        }
    }
}

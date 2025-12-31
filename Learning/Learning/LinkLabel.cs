using System.Windows.Forms;

namespace Learning
{
    public partial class LinkLabel : Form
    {
        public LinkLabel()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://abdulhakim-alshanqiti.sa/");
            linkLabel1.LinkVisited = true;
        }
    }
}

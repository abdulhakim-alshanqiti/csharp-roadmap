using System;
using System.Windows.Forms;

namespace Learning
{
    public partial class Trackbar : Form
    {
        public Trackbar()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblValue.Text = trackBar1.Value.ToString();
        }
    }
}

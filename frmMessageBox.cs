using System.Windows.Forms;

namespace Pizza_App
{
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("This is A Message");
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("This is A Message", "This Is The Title");
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("This Actions Isn't Reversable Are You Sure ?", "Confirm", MessageBoxButtons.YesNo);
        }

        private void button4_Click(object sender, System.EventArgs e)
        {

        }

    }
}

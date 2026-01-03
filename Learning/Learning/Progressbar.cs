using System;
using System.Threading;
using System.Windows.Forms;

namespace Learning
{
    public partial class Progressbar : Form
    {
        public Progressbar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;

            for (int i = 0; i < 10; i++)
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {

                    progressBar1.Value += 10;
                    label1.Text = "...Loading %" + (((float)progressBar1.Value / progressBar1.Maximum) * 100);

                    progressBar1.Refresh();
                    label1.Refresh();
                    Thread.Sleep(500);
                }


            }

            label1.Text = "Done";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            progressBar1.Value = 0;
            button1.Enabled = true;
        }
    }
}

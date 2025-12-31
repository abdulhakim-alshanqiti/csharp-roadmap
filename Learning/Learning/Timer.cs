using System;
using System.Drawing;
using System.Windows.Forms;

namespace Learning
{
    public partial class Timer : Form
    {
        short counter = 0;
        public Timer()
        {
            InitializeComponent();
        }

        private void TimerTicked(object sender, EventArgs e)
        {
            if (counter < 100)
                counter++;
            else
            {
                button1.Enabled = false; button1.Text = "وصلت الى 100 تسبيحة";
            }

            label1.Text = counter.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (timer1.Enabled)
                timer1.Stop();
            else
                timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "This Is The Title";
            notifyIcon1.BalloonTipText = "This Is The Message";
            notifyIcon1.ShowBalloonTip(5000);

        }
    }
}

using System;
using System.Windows.Forms;

namespace Learning
{
    public partial class DateTimePicker : Form
    {
        public DateTimePicker()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dddd,dd/MM/yyyy") + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToLongDateString());
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
        }
    }
}

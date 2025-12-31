using System.Windows.Forms;

namespace Learning
{
    public partial class CheckedListBox : Form
    {
        public CheckedListBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            for (byte i = 1; i <= 5; i++)
            {
                checkedListBox1.Items.Add("Box" + i);
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("There isn't any selected items ");
                return;
            }
            for (byte i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                MessageBox.Show("This Is The Item Number : " + checkedListBox1.CheckedItems[i].ToString());

            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;

            btn.Tag = (btn.Tag.ToString() == "check") ? "uncheck" : "check";

            if (btn.Tag.ToString() == "check")
                for (byte i = 0; i < checkedListBox1.Items.Count; i++)
                    checkedListBox1.SetItemChecked(i, true);
            else
                for (byte i = 0; i < checkedListBox1.Items.Count; i++)
                    checkedListBox1.SetItemChecked(i, false);

        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            if (checkedListBox1.Items.Count > 2)
                checkedListBox1.Items.RemoveAt(2);
        }
    }
}

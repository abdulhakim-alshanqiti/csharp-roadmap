using System;
using System.Windows.Forms;

namespace Learning
{
    public partial class Dialogs : Form
    {
        public Dialogs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.ForeColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = button1.Font;
            fontDialog1.Color = button1.ForeColor;


            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.Font = fontDialog1.Font;
                button1.ForeColor = fontDialog1.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Txt Files |*.txt |All Files | *.*";
            saveFileDialog1.FilterIndex = 0;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Txt Files |*.txt |All Files | *.*";
            openFileDialog1.FilterIndex = 0;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Txt Files |*.txt |All Files | *.*";
            openFileDialog1.FilterIndex = 0;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string FileName in openFileDialog1.FileNames)
                {
                    MessageBox.Show(FileName);

                }



            }


            openFileDialog1.Multiselect = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDialog1.SelectedPath);
            }
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
            }
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.ForeColor = colorDialog1.Color;
            }
        }



    }
}

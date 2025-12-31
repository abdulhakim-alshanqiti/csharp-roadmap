using Learning.Properties;
using System.Windows.Forms;
enum Fruits
{
    Apple,
    Kiwi,
    Orange,
    Watermelon
}

namespace Learning
{
    public partial class ComboBox : Form
    {

        public ComboBox()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
            //switch ((Fruits)cb.SelectedIndex)
            //{
            //    case Apple: pictureBox1.Image = Resources.apple; break;
            //    case Kiwi: pictureBox1.Image = Resources.kiwi; break;
            //    case Orange: pictureBox1.Image = Resources.orange; break;
            //    case Watermelon: pictureBox1.Image = Resources.watermelon; break;
            //}

            switch (cb.SelectedItem.ToString().ToLower())
            {
                case "apple":
                    pictureBox1.Image = Resources.apple;
                    lblTitle.Text = "Apple";
                    break;
                case "kiwi":
                    pictureBox1.Image = Resources.kiwi;
                    lblTitle.Text = "Kiwi";
                    break;
                case "orange":
                    pictureBox1.Image = Resources.orange;
                    lblTitle.Text = "Orange";
                    break;
                case "watermelon":
                    pictureBox1.Image = Resources.watermelon;
                    lblTitle.Text = "Watermelon";
                    break;
            }


        }
    }
}

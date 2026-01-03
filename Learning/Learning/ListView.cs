using System;
using System.Windows.Forms;

namespace Learning
{
    public partial class ListView : Form
    {

        public ListView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Random rng = new Random();
            for (int i = 1; i <= 10; i++)
            {
                ListViewItem Item = new ListViewItem(i.ToString());
                switch (rng.Next(3))
                {
                    case 0: { Item.SubItems.Add("Kiwi"); Item.SubItems.Add("Fruit"); } break;
                    case 1: { Item.SubItems.Add("Watermelon"); Item.SubItems.Add("Fruit"); } break;
                    case 2: { Item.SubItems.Add("Tomato"); Item.SubItems.Add("Vegetable"); } break;
                    case 3: { Item.SubItems.Add("Carrots"); Item.SubItems.Add("Vegetable"); } break;
                }




                listView1.Items.Add(Item);


            }



        }
    }
}

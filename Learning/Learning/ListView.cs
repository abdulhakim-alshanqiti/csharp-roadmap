using System;

using System.Windows.Forms;
namespace Learning
{





    public partial class ListView : Form
    {
        int IdCounter = 0;

        public ListView()
        {
            InitializeComponent();
        }
        void AddFruit(ListViewItem Item, string name)
        {
            Item.SubItems.Add(name); Item.SubItems.Add("Fruit");
        }

        void AddVeggie(ListViewItem Item, string name)
        {
            Item.SubItems.Add(name); Item.SubItems.Add("Vegetable");
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

            Random rng = new Random();

            for (int i = 0; i < 10; i++, IdCounter++)
            {
                ListViewItem Item = new ListViewItem(IdCounter.ToString());



                switch (rng.Next(4))
                {
                    case 0:
                        AddFruit(Item, "Kiwi");
                        break;
                    case 1:
                        AddFruit(Item, "Watermelon");
                        break;
                    case 2:
                        AddVeggie(Item, "Tomato");
                        break;
                    case 3:
                        AddVeggie(Item, "Carrot");
                        break;

                }





                listView1.Items.Add(Item);


            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox2.SelectedItem.ToString())
            {
                case "Details":

                    listView1.View = View.Details;

                    break;
                case "List":
                    listView1.View = View.List;
                    break;
                default:
                    listView1.View = View.Tile;

                    break;
            }
            ;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Hey Fill In The TextBox Please Sir");
            }

            if (string.IsNullOrEmpty(comboBox1.SelectedItem.ToString()))
            {
                MessageBox.Show("Hey Choose a Category For The ComboBox Please Sir");

            }

            ListViewItem Item = new ListViewItem(IdCounter.ToString());

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Fruit":
                    AddFruit(Item, textBox1.Text);
                    break;
                default:
                    AddVeggie(Item, textBox1.Text);
                    break;
            }

            listView1.Items.Add(Item);
            IdCounter++;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                listView1.SelectedItems[0].Remove();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pizza_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOrderPizza_Click(object sender, System.EventArgs e)
        {
            decimal Cash = 0;

            if (!radioThick.Checked && !radioThin.Checked)
            {
                MessageBox.Show("Please Choose A Crust Type For The Pizza !", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!radioEatIn.Checked && !radioTakeOut.Checked)
            {
                MessageBox.Show("Please Choose The Place You Want The Pizza To Be !", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            decimal pToppings = 0;
            foreach (CheckBox checkBox in gbToppings.Controls)
            {
                if (checkBox.Checked)
                {
                    pToppings += 2.75m;
                    labelToppings.Text += checkBox.Text + ",";
                }

            }
            labelToppings.Text = labelToppings.Text.Substring(0, labelToppings.Text.Length - 1);


            Dictionary<string, decimal> PizzaSize = new Dictionary<string, decimal>
            {
                ["Small"] = 15m,
                ["Medium"] = 20m,
                ["Large"] = 25m,
            };

            decimal pPizzaSize = 0;
            foreach (RadioButton Radio in gbSize.Controls)
            {
                if (Radio.Checked)
                {
                    PizzaSize.TryGetValue(Radio.Text, out pPizzaSize);
                    labelSize.Text += Radio.Text;
                }
            }
            if (pPizzaSize == 0)
            {
                MessageBox.Show("Please Choose A Pizza Size !", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            Cash += pToppings + pPizzaSize;
            labelCash.Text = Cash.ToString() + "$";


            labelCrust.Text = "Crust Type : " + ((radioThick.Checked) ? "Thick" : "Thin");
            labelWhereToEat.Text = "Where To Eat : " + ((radioEatIn.Checked) ? "Eat In" : "Take Out");
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            labelCash.Text = "0$";
            labelToppings.Text = "Toppings : ";
            labelSize.Text = "Size : ";
            labelCrust.Text = "Crust Type : ";
            labelWhereToEat.Text = "Where To Eat : ";
            foreach (RadioButton radioBtn in this.gbPlace.Controls)
            {

                radioBtn.Checked = false;

            }
            foreach (RadioButton radioBtn in this.gbSize.Controls)
            {

                radioBtn.Checked = false;

            }
            foreach (RadioButton radioBtn in this.gbCrust.Controls)
            {

                radioBtn.Checked = false;

            }
            foreach (CheckBox checkBox in this.gbToppings.Controls)
            {

                checkBox.Checked = false;

            }



        }
    }
}

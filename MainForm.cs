using System;
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

            gbPlace.Enabled = false;
            gbSize.Enabled = false;
            gbCrust.Enabled = false;
            gbToppings.Enabled = false;

            UpdateOrderSummary();
        }

        private void ResetForm(object sender, EventArgs e)
        {
            labelTotalPrice.Text = "0$";
            labelToppings1.Text = "";
            labelSize.Text = "";
            labelCrust.Text = "";
            labelWhereToEat.Text = "";

            gbPlace.Enabled = true;
            gbSize.Enabled = true;
            gbCrust.Enabled = true;
            gbToppings.Enabled = true;


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


            radioEatIn.Checked = true;
            radioSmall.Checked = true;
            radioThin.Checked = true;
            chkExtraCheese.Checked = true;

            UpdateOrderSummary();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void UpdateOrderSummary()
        {
            UpdateToppings();
            UpdateSize();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }
        private void UpdateTotalPrice(object sender = null, EventArgs e = null)
        {
            float Cash = 0;

            Cash += CalculateToppingsPrice() + CalculateSizePrice() + CalculateCrustPrice();
            labelTotalPrice.Text = Cash.ToString() + "$";
        }

        private float CalculateCrustPrice()
        {
            return (radioThin.Checked) ? 0 : 5;
        }

        private float CalculateSizePrice()
        {
            foreach (RadioButton Radio in gbSize.Controls)
                if (Radio.Checked)
                    return Convert.ToSingle(Radio.Tag.ToString());
            return 0f;
        }

        private float CalculateToppingsPrice()
        {
            float pToppings = 0;
            foreach (CheckBox checkBox in gbToppings.Controls)
            {

                if (checkBox.Checked)
                {
                    pToppings += Convert.ToSingle(checkBox.Tag.ToString());
                }

            }
            return pToppings;
        }

        private void UpdateToppings(object sender = null, EventArgs e = null)
        {
            UpdateTotalPrice();
            string sToppings = "";
            float pToppings = 0;
            foreach (CheckBox checkBox in gbToppings.Controls)
            {

                if (checkBox.Checked)
                {
                    pToppings += float.Parse(checkBox.Tag.ToString());

                    sToppings += checkBox.Text + ", ";
                }

            }

            labelToppings1.Text = sToppings.Remove(sToppings.Length - 2, 2);
        }

        private void UpdateWhereToEat(object sender = null, EventArgs e = null)
        {
            labelWhereToEat.Text = ((radioEatIn.Checked) ? "Eat In" : "Take Out");
        }

        private void UpdateCrust(object sender = null, EventArgs e = null)
        {
            UpdateTotalPrice();
            labelCrust.Text = ((radioThin.Checked) ? "Thin" : "Thick");
        }

        private void UpdateSize(object sender = null, EventArgs e = null)
        {
            UpdateTotalPrice();
            if (sender == null)
            {
                foreach (RadioButton Radio in gbSize.Controls)
                    if (Radio.Checked)
                    { labelSize.Text = Radio.Text; return; }
            }
            else
            {
                RadioButton radio = (RadioButton)sender;
                labelSize.Text = radio.Text;
            }

        }
    }
}

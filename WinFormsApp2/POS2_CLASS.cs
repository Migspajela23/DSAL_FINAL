using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class POS2_CLASS : Form
    {
        private Price_Item_Value price_discount_amount, item_priceValue;

        public object PrintListBox { get; private set; }

        public POS2_CLASS()
        {
            InitializeComponent();
            price_discount_amount = new Price_Item_Value
            {
                price = string.Empty,
                item_name = string.Empty,
                discount_amount = string.Empty
            };
        }

        private void QuantityTxtBox()
        {
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void FoodradioBtn()
        {
            foodARdbtn.Checked = false;
            foodBRdbtn.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Item_priceValue("Pizza", "350");
            displayListBox.Items.Add(checkBox1.Text + "" + priceTxtbox.Text);
            QuantityTxtBox();
        }

        private void Item_priceValue(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Item_priceValue("Pizza", "350");
            QuantityTxtBox();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Item_priceValue("Pizza", "350");
            QuantityTxtBox();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Item_priceValue("Pizza", "350");
            QuantityTxtBox();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Item_priceValue("Pizza", "350");
            QuantityTxtBox();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            Item_priceValue("Pizza", "350");
            QuantityTxtBox();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            Item_priceValue("Pizza", "350");
            QuantityTxtBox();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            Item_priceValue("Pizza", "350");
            QuantityTxtBox();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            Item_priceValue("Pizza", "350");
            QuantityTxtBox();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            Item_priceValue("Pizza", "350");
            QuantityTxtBox();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            Item_priceValue("Pizza", "350");
            QuantityTxtBox();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            Item_priceValue("Pizza", "350");
            QuantityTxtBox();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            Item_priceValue("Pizza", "350");
            QuantityTxtBox();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            Item_priceValue("Pizza", "350");
            QuantityTxtBox();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            Item_priceValue("Pizza", "350");
            QuantityTxtBox();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            Item_priceValue("Pizza", "350");
            QuantityTxtBox();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            Item_priceValue("Pizza", "350");
            QuantityTxtBox();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            Item_priceValue("Pizza", "350");
            QuantityTxtBox();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            Item_priceValue("Pizza", "350");
            QuantityTxtBox();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            Item_priceValue("Pizza", "350");
            QuantityTxtBox();
        }

        private void POS2_CLASS_Load(object sender, EventArgs e)
        {
            // Disabling text boxes that display calculated values to prevent user input.
            priceTxtbox.Enabled = false;
            discountedTxtBox.Enabled = false;
            changeTxtBox.Enabled = false;
            totalBillsTxtBox.Enabled = false;
            discountTxtbox.Enabled = false;
            totalQtyTxtBox.Enabled = false;

            pictureBox1.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\peperoni.jpg");
            pictureBox2.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\olive pizza.jpeg");
            pictureBox3Txt.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\pizza3.jpg");
            pictureBox4Txt.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\pizza 2.jpg");
            pictureBox5.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\chicken parm.jpeg");
            pictureBox6.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\margherita.jpeg");
            pictureBox7Txt.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\pizza 1.jpg");
            pictureBox8Txt.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\pizzza 4.jpg");
            pictureBox9txt.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\pizza 5.jpg");
            pictureBox10.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\proper pizza.jpeg");
            pictureBox11.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\supreme pizza.jpeg");
            pictureBox12.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\white pie pizza.jpeg");
            pictureBox13.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\hot honey.jpeg");
            pictureBox14.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\marco pizza.jpeg");
            pictureBox15.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\peperoni.jpg");
        }

        private void foodARdbtn_CheckedChanged(object sender, EventArgs e)
        {
            // Change the form background color to indicate selection
            this.BackColor = Color.IndianRed;

            // Ensure Food Bundle B radio button is not selected
            foodBRdbtn.Checked = false;

            // Display the image for Food Bundle A and stretch it to fit the PictureBox
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\bundle a.jpg");
            DisplayPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // Check all checkboxes related to Food Bundle A
            A_ChickencheckBox.Checked = true;
            A_FriescheckBox.Checked = true;
            A_SpecialPizzacheckBox.Checked = true;


            // Uncheck all checkboxes related to Food Bundle B
            B_ChickencheckBox.Checked = false;
            B_CarbonaracheckBox.Checked = false;
            B_MediumPizzacheckBox.Checked = false;

            // Display price and discount information for Food Bundle A
            PricesTxtBox.Text = "300.00";
            discountAmtTxtBox.Text = "50";
            double Price = Convert.ToDouble(PricesTxtBox.Text);
            displayListBox.Items.Add(foodARdbtn.Text + "          " + PricesTxtBox.Text);
            displayListBox.Items.Add("Discount: " + discountAmtTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void foodBRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGoldenrodYellow;

            foodARdbtn.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\bundle a.jpg");
            DisplayPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            B_ChickencheckBox.Checked = true;
            B_CarbonaracheckBox.Checked = true;
            B_MediumPizzacheckBox.Checked = true;

            A_ChickencheckBox.Checked = false;
            A_FriescheckBox.Checked = false;
            A_SpecialPizzacheckBox.Checked = false;

            PricesTxtBox.Text = "250.00";
            discountAmtTxtBox.Text = "30";

            double Price = Convert.ToDouble(PricesTxtBox.Text);
            displayListBox.Items.Add(foodBRdbtn.Text + "          " + PricesTxtBox.Text);
            displayListBox.Items.Add("Discount: " + discountAmtTxtBox.Text);
            qtyTxtBox.Text = "0";
            qtyTxtBox.Focus();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            FoodradioBtn();
            foodARdbtn.Checked = false;
            foodBRdbtn.Checked = false;
            A_ChickencheckBox.Checked = false;
            A_FriescheckBox.Checked = false;
            A_SpecialPizzacheckBox.Checked = false;
            B_ChickencheckBox.Checked = false;
            B_CarbonaracheckBox.Checked = false;
            B_MediumPizzacheckBox.Checked = false;

            PricesTxtBox.Clear();
            qtyTxtBox.Clear();
            cashGivenTxtBox.Clear();
            displayListBox.Items.Clear();

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
                displayListBox.Items.RemoveAt(displayListBox.SelectedIndex);
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            TRANSACTION print = new TRANSACTION();
            print.PrintListBox.Items.AddRange(this.displayListBox.Items);
            print.Show();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {

            try
            {
                double cashGiven, totalAmountPaid, change;

                cashGiven = Convert.ToDouble(cashGivenTxtBox.Text);
                totalAmountPaid = Convert.ToDouble(totalBillsTxtBox.Text);
                change = cashGiven - totalAmountPaid;
                changeTxtBox.Text = change.ToString("n");
                displayListBox.Items.Add("Total Bills: " + "          " + totalBillsTxtBox.Text);
                displayListBox.Items.Add("Cash Given: " + "          " + cashGivenTxtBox.Text);
                displayListBox.Items.Add("Change: " + "          " + changeTxtBox.Text);
                displayListBox.Items.Add("Total No. of Items: " + "          " + totalQtyTxtBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter amount of cash given!");
                cashGivenTxtBox.Clear();
                cashGivenTxtBox.Focus();
            }
        }

        private void qtyTxtBox_TextChanged(object sender, EventArgs e)
        {
            int qty, discountedAmount;
            double Price, discountAmount;
            // Initialize totalQty and totalAmount to 0 to avoid CS0165
            int totalQty = 0, totalAmount = 0;

            Price = Convert.ToDouble(PricesTxtBox.Text);
            qty = Convert.ToInt32(qtyTxtBox.Text);
            discountAmount = Convert.ToDouble(discountAmtTxtBox.Text);
            discountedAmount = (int)((Price * qty) - discountAmount);
            totalQty += qty;
            totalQtyTxtBox.Text = totalQty.ToString();
            totalAmount += discountedAmount;
            totalBillsTxtBox.Text = totalAmount.ToString("n");
            discountedTxtBox.Text = discountedAmount.ToString("n");
        }
    }
}

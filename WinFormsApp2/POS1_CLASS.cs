using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class POS1_CLASS : Form
    {
        private Price_Item_Value price_item_value;
        private Variables1 Variables1;

        public POS1_CLASS()
        {
            InitializeComponent();
            price_item_value = new Price_Item_Value
            {
                price = string.Empty,
                item_name = string.Empty,
                discount_amount = string.Empty
            };
            Variables1 = new Variables1();
        }

        private void computation_Formula_and_DisplayData()
        {
            // Ensure Variables1.price and Variables1.quantity are up-to-date
            quantity_price_Convert();

            Variables1.discounted_amt = (Variables1.quantity * Variables1.price) - Variables1.discount_amt;
            discount_txtbox.Text = Variables1.discount_amt.ToString("n");
            discounted_txtbox.Text = Variables1.discounted_amt.ToString("n");
        }

        public void GetPriceItemValue()
        {
            itemnametxtbox.Text = price_item_value.GetItemName();
            pricetxtbox.Text = price_item_value.GetPrice();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Variables1.quantity = Convert.ToInt32(quantitytxtbox.Text);
            Variables1.discount_amt = Convert.ToDouble(discount_txtbox.Text);
            Variables1.discounted_amt = Convert.ToDouble(discounted_txtbox.Text);
            Variables1.cash_given = Convert.ToDouble(cash_renderedtxtbox.Text);

            Variables1.qty_total += Variables1.quantity;
            Variables1.discount_totalgiven += Variables1.discount_amt;
            Variables1.discounted_total += Variables1.discounted_amt;
            Variables1.change = Variables1.cash_given - Variables1.discounted_amt;

            qty_totalbox.Text = Variables1.qty_total.ToString("n");
            discount_totalbox.Text = Variables1.discount_totalgiven.ToString("n");
            discounted_totalbox.Text = Variables1.discounted_total.ToString("n");
            changetxtbox.Text = Variables1.change.ToString("n");
            cash_renderedtxtbox.Text = Variables1.cash_given.ToString("n");


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Stir Fry Noodles", "100.00");
            GetPriceItemValue();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Stir Fry Noodles", "100.00");
            GetPriceItemValue();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Stir Fry Noodles", "100.00");
            GetPriceItemValue();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Stir Fry Noodles", "100.00");
            GetPriceItemValue();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Stir Fry Noodles", "100.00");
            GetPriceItemValue();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Rice Bowl", "100.00");
            GetPriceItemValue();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Rice Bowl", "100.00");
            GetPriceItemValue();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Rice Bowl", "100.00");
            GetPriceItemValue();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Rice Bowl", "100.00");
            GetPriceItemValue();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Rice Bowl", "100.00");
            GetPriceItemValue();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Drinks", "50.00");
            GetPriceItemValue();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Drinks", "50.00");
            GetPriceItemValue();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Drinks", "50.00");
            GetPriceItemValue();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Drinks", "50.00");
            GetPriceItemValue();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Drinks", "50.00");
            GetPriceItemValue();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Ramen", "100.00");
            GetPriceItemValue();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Ramen", "100.00");
            GetPriceItemValue();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Ramen", "100.00");
            GetPriceItemValue();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Ramen", "100.00");
            GetPriceItemValue();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Ramen", "100.00");
            GetPriceItemValue();
        }

        private void seniorCtznRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                Variables1.discount_amt = (Variables1.quantity * Variables1.price) * 0.30;
                computation_Formula_and_DisplayData();
                regularRBtn.Checked = false;
                employeeDiscRdBtn.Checked = false;
                noDiscRdBtn.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying senior citizen discount: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quantity_price_Convert()
        {
            // Example implementation: parse quantity and price from textboxes
            // Adjust the control names as needed to match your form
            if (double.TryParse(quantitytxtbox.Text, out double qty))
                Variables1.quantity = qty;
            else
                Variables1.quantity = 0;

            if (double.TryParse(pricetxtbox.Text, out double price))
                Variables1.price = price;
            else
                Variables1.price = 0;
        }

        private void regularRBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                Variables1.discount_amt = (Variables1.quantity * Variables1.price) * 0.10;
                computation_Formula_and_DisplayData();
                seniorCtznRdBtn.Checked = false;
                employeeDiscRdBtn.Checked = false;
                noDiscRdBtn.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying regular citizen discount: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void employeeDiscRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                Variables1.discount_amt = (Variables1.quantity * Variables1.price) * 0.15;
                computation_Formula_and_DisplayData();
                regularRBtn.Checked = false;
                seniorCtznRdBtn.Checked = false;
                noDiscRdBtn.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying employee discount: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void noDiscRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                Variables1.discount_amt = (Variables1.quantity * Variables1.price) * 0;
                computation_Formula_and_DisplayData();
                regularRBtn.Checked = false;
                employeeDiscRdBtn.Checked = false;
                seniorCtznRdBtn.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying senior citizen discount: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void POS1_CLASS_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.DeepSkyBlue;
            // codes for disabling the textboxes
            itemnametxtbox.Enabled = false;
            pricetxtbox.Enabled = false;
            discounted_txtbox.Enabled = false;
            qty_totalbox.Enabled = false;
            discount_totalbox.Enabled = false;
            changetxtbox.Enabled = false;
            // picture
            pictureBox6.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\484931094_122151546992516195_4118876699337207221_n.jpg");
            pictureBox12.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\485133915_122151547010516195_5326755366258208306_n.jpg");
            pictureBox15.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\485413770_122151546728516195_4551135498844738431_n.jpg");
            pictureBox20.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\473590083_122135407970516195_5828374020713932697_n.jpg");
            pictureBox21.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\469176751_122126904716516195_9036355017887515595_n.jpg");

            //name
            name1lbl.Text = "Bulgogi Stir Fry";
            name2lbl.Text = "Cheesy Ramen";
            name3lbl.Text = "Shin Ramen";
            name4lbl.Text = "Buldak";
            name5lbl.Text = "Spicy Buldak";
            name6lbl.Text = "Chicken Rice Bowl";
            name7lbl.Text = "Shanghai Rice Bowl";
            name8lbl.Text = "Pastil Rice Bowl";
            name9lbl.Text = "Salmon RIce Bowl";
            name10lbl.Text = "Tapa Rice Bowl";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // Code for clearing all textboxes
            itemnametxtbox.Clear();
            pricetxtbox.Clear();
            quantitytxtbox.Clear();
            discount_txtbox.Clear();
            discounted_txtbox.Clear();
            cash_renderedtxtbox.Clear();
            changetxtbox.Clear();
            qty_totalbox.Clear();
            discount_totalbox.Clear();
            discounted_totalbox.Clear();

            // Re-enable and clear discount selection
            seniorCtznRdBtn.Enabled = true;
            regularRBtn.Enabled = true;
            employeeDiscRdBtn.Enabled = true;
            noDiscRdBtn.Enabled = true;

            seniorCtznRdBtn.Checked = false;
            regularRBtn.Checked = false;
            employeeDiscRdBtn.Checked = false;
            noDiscRdBtn.Checked = false;
        }
    }
}

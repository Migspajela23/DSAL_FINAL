using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class POS1_FUNCTION : Form
    {
        private int qty;
        private double price, discount_amt, discounted_amt;

        public POS1_FUNCTION()
        {
            InitializeComponent();
        }

        private void LESSON2MOD_Load(object sender, EventArgs e)
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

        private void quantityTxtbox()
        {
            quantitytxtbox.Clear();
            quantitytxtbox.Focus();
        }

        private void quantity_price_Convert()
        {
            int qty = Convert.ToInt32(quantitytxtbox.Text);
            double price = Convert.ToDouble(pricetxtbox.Text);

        }

        private void computation_Formula_and_DisplayData()
        {
            discounted_amt = (qty * price) - discount_amt;
            discount_txtbox.Text = discount_amt.ToString("n");
            discounted_txtbox.Text = discounted_amt.ToString("n");

        }

        private void price_item_TextValue(string itemname, string price)
        {
            itemnametxtbox.Text = itemname;
            pricetxtbox.Text = price;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Bulgogi Stir Fry", "150");
            quantityTxtbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Cheesy Ramen", "120");
            quantityTxtbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Shin Ramen", "100");
            quantityTxtbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Buldak", "130");
            quantityTxtbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Spicy Buldak", "140");
            quantityTxtbox();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Chicken Rice Bowl", "150");
            quantityTxtbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Shanghai Rice Bowl", "160");
            quantityTxtbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Pastil Rice Bowl", "170");
            quantityTxtbox();

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Salmon Rice Bowl", "180");
            quantityTxtbox();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Tapa Rice Bowl", "190");
            quantityTxtbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_TextValue("milkis", "90");
            quantityTxtbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_TextValue("welch", "90");
            quantityTxtbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_TextValue("icetalk", "90");
            quantityTxtbox();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_TextValue("icetalks", "90");
            quantityTxtbox();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_TextValue("pocari", "90");
            quantityTxtbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Bulgogi Stir Fry", "150");
            quantityTxtbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Cheesy Ramen", "120");
            quantityTxtbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Shin Ramen", "100");
            quantityTxtbox();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Buldak", "130");
            quantityTxtbox();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Spicy Buldak", "140");
            quantityTxtbox();
        }

        private void seniorCtznRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int qty = Convert.ToInt32(quantitytxtbox.Text);
                double price = Convert.ToDouble(pricetxtbox.Text);

                double discount_amt = (qty * price) * 0.20; // 20% discount
                double discounted_amt = (qty * price) - discount_amt;

                discount_txtbox.Text = discount_amt.ToString("n");
                discounted_txtbox.Text = discounted_amt.ToString("n");

                // Disable other radio buttons
                withDiscCardRdBtn.Enabled = false;
                employeeDiscRdBtn.Enabled = false;
                noDiscRdBtn.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers for quantity and price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quantityTxtbox();
            }
        }

        private void withDiscCardRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int qty = Convert.ToInt32(quantitytxtbox.Text);
                double price = Convert.ToDouble(pricetxtbox.Text);

                double discount_amt = (qty * price) * 0.10; // 10% discount
                double discounted_amt = (qty * price) - discount_amt;

                discount_txtbox.Text = discount_amt.ToString("n");
                discounted_txtbox.Text = discounted_amt.ToString("n");

                // Disable other radio buttons
                seniorCtznRdBtn.Enabled = false;
                employeeDiscRdBtn.Enabled = false;
                noDiscRdBtn.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers for quantity and price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quantityTxtbox();
            }
        }

        private void employeeDiscRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int qty = Convert.ToInt32(quantitytxtbox.Text);
                double price = Convert.ToDouble(pricetxtbox.Text);

                double discount_amt = (qty * price) * 0.15; // 15% discount
                double discounted_amt = (qty * price) - discount_amt;

                discount_txtbox.Text = discount_amt.ToString("n");
                discounted_txtbox.Text = discounted_amt.ToString("n");

                // Disable other radio buttons
                seniorCtznRdBtn.Enabled = false;
                withDiscCardRdBtn.Enabled = false;
                noDiscRdBtn.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers for quantity and price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quantityTxtbox();
            }
        }

        private void noDiscRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int qty = Convert.ToInt32(quantitytxtbox.Text);
                double price = Convert.ToDouble(pricetxtbox.Text);

                double discount_amt = 0.0; // No discount
                double discounted_amt = (qty * price);

                discount_txtbox.Text = discount_amt.ToString("n");
                discounted_txtbox.Text = discounted_amt.ToString("n");

                // Disable other radio buttons
                seniorCtznRdBtn.Enabled = false;
                withDiscCardRdBtn.Enabled = false;
                employeeDiscRdBtn.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers for quantity and price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quantityTxtbox();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // Declaration of variables
            int qty;
            double price, discount_amt, discounted_amt, cash_rendered, change;

            // Convert string data to numeric data
            qty = Convert.ToInt32(quantitytxtbox.Text);
            discount_amt = Convert.ToDouble(discount_txtbox.Text);
            discounted_amt = Convert.ToDouble(discounted_txtbox.Text);
            double v = Convert.ToDouble(cash_renderedtxtbox.Text);
            cash_rendered = v;

            int qty_total = 0;
            double discount_totalgiven = 0, discounted_total = 0;


            // Codes to accumulate the value of the quantity, discount given, and discounted amount from one transaction to another
            qty_total += qty;
            discount_totalgiven += discount_amt;
            discounted_total += discounted_amt;
            change = cash_rendered - discounted_amt;

            // Convert string data to numeric data and place it  as value of the variable
            qty_totalbox.Text = qty_total.ToString();
            discount_totalbox.Text = discount_totalgiven.ToString("n");
            discounted_totalbox.Text = discounted_total.ToString("n");
            changetxtbox.Text = change.ToString("n");
            cash_renderedtxtbox.Text = cash_rendered.ToString("n");
        }
    }

}

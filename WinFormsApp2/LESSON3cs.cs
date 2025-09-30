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
    public partial class LESSON3cs : Form
    {
        public LESSON3cs()
        {
            InitializeComponent();
        }

        private void LESSON3cs_Load(object sender, EventArgs e)
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

        private void seniorCtznRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;

            // Validate input
            if (!int.TryParse(quantitytxtbox.Text, out qty) || !double.TryParse(pricetxtbox.Text, out price))
            {
                MessageBox.Show("Please enter valid numbers for Quantity and Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate
            discount_amt = (qty * price) * 0.30;
            discounted_amt = (qty * price) - discount_amt;

            discount_txtbox.Text = discount_amt.ToString("n");
            discounted_txtbox.Text = discounted_amt.ToString("n");

            withDiscCardRdBtn.Enabled = false;
            employeeDiscRdBtn.Enabled = false;
            noDiscRdBtn.Enabled = false;
        }

        private void withDiscCardRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            // Declaration of variables
            int qty;
            double price, discount_amt, discounted_amt;

            // Convert string data to numeric data
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetxtbox.Text);

            // Calculate
            discount_amt = (qty * price) * 0.10;
            discounted_amt = (qty * price) - discount_amt;

            // Convert numeric data to string data and display in textboxes
            discount_txtbox.Text = discount_amt.ToString("n");
            discounted_txtbox.Text = discounted_amt.ToString("n");

            // Codes for disabling other radio buttons when one is selected
            seniorCtznRdBtn.Enabled = false;
            employeeDiscRdBtn.Enabled = false;
            noDiscRdBtn.Enabled = false;
        }

        private void employeeDiscRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            // Declaration of variables
            int qty;
            double price, discount_amt, discounted_amt;

            // Convert string data to numeric data
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetxtbox.Text);

            // Calculate
            discount_amt = (qty * price) * 0.15;
            discounted_amt = (qty * price) - discount_amt;

            // Convert numeric data to string data and display in textboxes
            discount_txtbox.Text = discount_amt.ToString("n");
            discounted_txtbox.Text = discounted_amt.ToString("n");

            // Codes for disabling other radio buttons when one is selected
            seniorCtznRdBtn.Enabled = false;
            withDiscCardRdBtn.Enabled = false;
            noDiscRdBtn.Enabled = false;
        }

        private void noDiscRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            // Declaration of variables
            int qty;
            double price, discount_amt, discounted_amt;

            // Convert string data to numeric data
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetxtbox.Text);

            // Calculation
            discount_amt = (qty * price) * 0;
            discounted_amt = (qty * price) - discount_amt;

            // Convert numeric data to string data and display in textboxes
            discount_txtbox.Text = discount_amt.ToString("n");
            discounted_txtbox.Text = discounted_amt.ToString("n");

            // Codes for disabling other radio buttons when one is selected
            seniorCtznRdBtn.Enabled = false;
            withDiscCardRdBtn.Enabled = false;
            employeeDiscRdBtn.Enabled = false;
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
            cash_rendered = Convert.ToDouble(cash_renderedtxtbox.Text);

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
            withDiscCardRdBtn.Enabled = true;
            employeeDiscRdBtn.Enabled = true;
            noDiscRdBtn.Enabled = true;

            seniorCtznRdBtn.Checked = false;
            withDiscCardRdBtn.Checked = false;
            employeeDiscRdBtn.Checked = false;
            noDiscRdBtn.Checked = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            name1lbl.Text = "Korean Bulgogi Noodles";
            itemnametxtbox.Text = "Bulgogi Stir Fry";
            pricetxtbox.Text = "95.30";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            name1lbl.Text = "Korean Cheesy Ramen Noodles";
            itemnametxtbox.Text = "Cheesy Ramen";
            pricetxtbox.Text = "95.30";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            name1lbl.Text = "Korean Shin Ramen Noodles";
            itemnametxtbox.Text = "Shin Ramen";
            pricetxtbox.Text = "95.30";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            name1lbl.Text = "Korean Buldak Noodles";
            itemnametxtbox.Text = "Carbonara Buldak Stir Fry";
            pricetxtbox.Text = "95.30";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            name1lbl.Text = "Korean Buldak Noodles";
            itemnametxtbox.Text = "Spicy Buldak Stir Fry";
            pricetxtbox.Text = "95.30";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            name1lbl.Text = "Rice Bowls";
            itemnametxtbox.Text = "Chicken Rice Bowl";
            pricetxtbox.Text = "100";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            name1lbl.Text = "Rice Bowls";
            itemnametxtbox.Text = "Shanghai Rice Bowl";
            pricetxtbox.Text = "100.00";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            name1lbl.Text = "Rice Bowls";
            itemnametxtbox.Text = "Pastil Rice Bowl";
            pricetxtbox.Text = "100.00";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

            name1lbl.Text = "Rice Bowls";
            itemnametxtbox.Text = "Salmon Rice Bowl";
            pricetxtbox.Text = "100.00";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            name1lbl.Text = "Rice Bowls";
            itemnametxtbox.Text = "Tapa Rice Bowl";
            pricetxtbox.Text = "100.00 ";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            name1lbl.Text = "Drinks";
            itemnametxtbox.Text = "Strawberry Milkis";
            pricetxtbox.Text = "55.55";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            name1lbl.Text = "Drinks";
            itemnametxtbox.Text = "Welchs";
            pricetxtbox.Text = "55.55";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

            name1lbl.Text = "Drinks";
            itemnametxtbox.Text = "Blue Ice Talk";
            pricetxtbox.Text = "55.55";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            name1lbl.Text = "Drinks";
            itemnametxtbox.Text = "Assorted Ice Talk";
            pricetxtbox.Text = "55.55";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            name1lbl.Text = "Drinks";
            itemnametxtbox.Text = "Pocari";
            pricetxtbox.Text = "55.55";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            name1lbl.Text = "Real Noodles";
            itemnametxtbox.Text = "Cheesy Carboanra";
            pricetxtbox.Text = "120.50";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

            name1lbl.Text = "Real Noodles";
            itemnametxtbox.Text = "Spicy Ramen";
            pricetxtbox.Text = "120.50";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            name1lbl.Text = "Real Noodles";
            itemnametxtbox.Text = "Veggie Ramen";
            pricetxtbox.Text = "120.50";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            name1lbl.Text = "Real Noodles";
            itemnametxtbox.Text = "Shin Ramen";
            pricetxtbox.Text = "120.50";
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            name1lbl.Text = "Real Noodles";
            itemnametxtbox.Text = "OverLoad Ramen";
            pricetxtbox.Text = "120.50";
        }
    }
}


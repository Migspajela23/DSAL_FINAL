using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class POS1_CLASS : Form
    {
        Price_Item_Value price_item_Value = new Price_Item_Value();
        variables1 variable = new variables1();
        private object price_item_value;

        private int qty;
        private double price;

        public POS1_CLASS()
        {
            InitializeComponent();
        }

        

        private void Computation_Formula_And_DisplayData()

        {
           variables1.discounted_amt =(variables1.quantity * variables1.price) - variables1.discount_amt;
            discount_txtbox.Text = variables1.discount_amt.ToString("n");
            discounted_txtbox.Text = variables1.discounted_amt.ToString("n");

        }
        public void GetPriceItem_Value() 
        {
            itemnametxtbox.Text = price_item_Value.GetItemName();
            pricetxtbox.Text = price_item_Value.GetPrice();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
                {
                variables1.price = Convert.ToInt32.Parse(pricetxtbox.Text);
                variables1.quantity = Convert.ToDouble(qtytxtbox.Text);
                variables1.discount_amt = Convert. ToDouble(discount_txtbox.Text);
                variables1.discounted_amt= Convert.ToDouble(discounted_txtbox.Text);
                variables1.cash_given = Convert.ToDouble(cash_rendered_txtbox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numbers for price, quantity, and discount amount.");
            }
        }
    }
}

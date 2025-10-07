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
    public partial class DisplayTxtBox : Form
    {
        public DisplayTxtBox()
        {
            InitializeComponent();
        }

        private void DisplayTxtBox_Load(string itename, string price)
        {
            itemnameTxtbox.Text = itename;
            PriceTxtbox.Text = price;
        }

        private void quantityTxtbox()
        {
            qtyTextBox.Clear();
            qtyTextBox.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DisplayTxtBox_Load("Bulgogi Stir Fry", "121.30");
            quantityTxtbox();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DisplayTxtBox_Load("Cheesy Ramen", "121.30");
            quantityTxtbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
               DisplayTxtBox_Load("Shin Ramen", "121.30");
                quantityTxtbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DisplayTxtBox_Load("Creamy Buldak", "121.30");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DisplayTxtBox_Load("Spicy Buldak", "121.30");   
            quantityTxtbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DisplayTxtBox_Load("Chicken Rice Bowl", "99");  
            quantityTxtbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DisplayTxtBox_Load("Shanghai Rice Bowl", "99");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
              DisplayTxtBox_Load( "Pastil Rice Bowl",  "99"); 
                quantityTxtbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
           DisplayTxtBox_Load( "Salmon Rice Bowl",  "99");
            quantityTxtbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            DisplayTxtBox_Load("Tapa Rice Bowl", "99"); 
            quantityTxtbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            DisplayTxtBox_Load("Milkis", "65");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
           DisplayTxtBox_Load("Welches", "65");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            DisplayTxtBox_Load("Ice Talk Blue", "65"); 
            quantityTxtbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            DisplayTxtBox_Load( "Assorted Ice Talk",  "65"); 
            quantityTxtbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {DisplayTxtBox_Load("Pocari", "65");
            quantityTxtbox();

        }
    }
}

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
    public partial class LESSON2 : Form
    {
        public LESSON2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // code bg change 
            this.BackColor = Color.LightGoldenrodYellow;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


            this.BackColor = Color.LightGoldenrodYellow;
            //not bundle b
            foodBrdbtn.Checked = false;
            //checkboxes
            A_CokecheckBox.Checked = true;
            A_ChickencheckBox.Checked = true;
            A_FriescheckBox.Checked = true;
            A_SidedishescheckBox.Checked = true;
            A_SpecialPizzacheckBox.Checked = true;
            //uncheck boxes
            B_CarbonaracheckBox.Checked = false;
            B_ChickencheckBox.Checked = false;
            B_FriescheckBox.Checked = false;
            B_halohalocheckBox.Checked = false;
            B_MediumPizzacheckBox.Checked = false;
            // DIPLAY TEXT BOXES
            priceTxtbox.Text = "P1,000.00";
            discountTxtbox.Text = "(20% OF THE PRICE) P200.00";



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            foodArdtn.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\bundle a.jpg");
            A_CokecheckBox.Checked = true;
            A_ChickencheckBox.Checked = true;
            A_FriescheckBox.Checked = true;
            A_SidedishescheckBox.Checked = true;
            A_SpecialPizzacheckBox.Checked = true;
            B_CarbonaracheckBox.Checked = false;
            B_ChickencheckBox.Checked = false;
            B_FriescheckBox.Checked = false;
            B_halohalocheckBox.Checked = false;
            B_MediumPizzacheckBox.Checked = false;
            priceTxtbox.Text = "P1,299.00";
            discountTxtbox.Text = "(15% of the price) P194.5";



        }

       
        
            


        

        private void button3_Click(object sender, EventArgs e)
        {
            //clear
            foodArdtn.Checked = false;
            foodBrdbtn.Checked = false;
            //Clear picture box
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\bundle b.jpg");
            A_CokecheckBox.Checked = true;
            A_ChickencheckBox.Checked = true;
            A_FriescheckBox.Checked = true;
            A_SidedishescheckBox.Checked = true;
            A_SpecialPizzacheckBox.Checked = true;
            B_CarbonaracheckBox.Checked = false;
            B_ChickencheckBox.Checked = false;
            B_FriescheckBox.Checked = false;
            B_halohalocheckBox.Checked = false;
            B_MediumPizzacheckBox.Checked = false;
            //code for clear text boxes
           
            discountTxtbox.Text = "";
            priceTxtbox.Text = "";
        
            this.Close();
        }
    }
}

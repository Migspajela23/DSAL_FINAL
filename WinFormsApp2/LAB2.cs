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
    public partial class LAB2 : Form
    {
        // Change the type of totalUnits from object to int
        private int totalUnits;

        public LAB2()
        {
            InitializeComponent();
        }

        private void LAB2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Bachelor Of Science In Computer Engineering");
            comboBox1.Items.Add("Bachelor Of Science In Industrial Engineering");
            comboBox1.Items.Add("Bachelor Of Science In Electrical Engineering");
            comboBox1.Items.Add("Bachelor Of Science In Electronics Engineering");

            totalNumUnitsTxtBox.Enabled = false;
            totalNumUnits3TxtBox.Enabled = false;
            totalTuitionFeeTxtBox.Enabled = false;
            totalTuitionFee2TxtBox.Enabled = false;
            creditUnitsTxtBox.Enabled = false;
            totalMiscFeeTxtBox.Enabled = false;
            totalMiscFee2TxtBox.Enabled = false;
            totalTuitionAndFeeTxtBox.Enabled = false;
            totalTuitionandFees2TxtBox.Enabled = false;
            comLabFeeTxtBox.Enabled = false;
            ciscoLabfee2TxtBox.Enabled = false;
            examBookletfee2TxtBox.Enabled = false;
            totalOtherschoolfeesTxtBox.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an image file";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image selectedImage = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = selectedImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Fit image to box.
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Accumulate the total number of units.
            int unitLec, unitLab, creditUnit;
            unitLec = Convert.ToInt32(unitLecTxtBox.Text);
            unitLab = Convert.ToInt32(unitLabTxtBox.Text);
            creditUnit = unitLec + unitLab;
            totalUnits += creditUnit;
            totalNumUnits2TxtBox.Text = totalUnits.ToString();
            totalNumUnitsTxtBox.Text = totalUnits.ToString();
            creditUnitsTxtBox.Text = creditUnit.ToString();

            // Read values from the input TextBoxes.
            string courseNumber = courseNumberTxtBox.Text;
            string courseCode = courseCodeTxtBox.Text;
            string courseDescription = courseDescTxtBox.Text;
            string unitLecture = unitLecTxtBox.Text;
            string unitLaboratory = unitLabTxtBox.Text;
            string creditUnits = creditUnitsTxtBox.Text;
            string time = timeTxtBox.Text;
            string day = dayTxtBox.Text;



            // Add the entered values to the corresponding ListBoxes.
            numListBox.Items.Add(courseNumber);
            courseCodeListBox.Items.Add(courseCode);
            CourseDescListBox.Items.Add(courseDescription);
            unitLecListBox.Items.Add(unitLecture);
            unitLabListBox.Items.Add(unitLaboratory);
            creditUnitsListBox.Items.Add(creditUnits);
            TimeListBox.Items.Add(time);
            DayListBox.Items.Add(day);

            // Mirror totals/fees to the summary TextBoxes.
            totalTuitionFee2TxtBox.Text = totalTuitionFeeTxtBox.Text;
            totalMiscFee2TxtBox.Text = totalMiscFeeTxtBox.Text;
            ciscoLabfee2TxtBox.Text = ciscoLabfeeTxtBox.Text;
            examBookletfee2TxtBox.Text = examBookletfeeTxtBox.Text;
            totalNumUnits2TxtBox.Text = totalNumUnitsTxtBox.Text;
            totalTuitionFee2TxtBox.Text = totalTuitionFeeTxtBox.Text; // Duplicate copy (ok).
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Clear input text boxes controls on the form.
            courseNumberTxtBox.Clear();
            courseCodeTxtBox.Clear();
            courseDescTxtBox.Clear();
            unitLecTxtBox.Clear();
            unitLabTxtBox.Clear();
            timeTxtBox.Clear();
            dayTxtBox.Clear();
            comLabFeeTxtBox.Clear();
            ciscoLabfeeTxtBox.Clear();
            examBookletfeeTxtBox.Clear();
            creditUnitsTxtBox.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double totalTuitionFee, totalMiscFee, totalTuitionAndFee, ciscoLabFee, examBookletFee, comLabFee;

            ciscoLabFee = Convert.ToDouble(examBookletfeeTxtBox.Text);
            examBookletFee = Convert.ToDouble(examBookletfeeTxtBox.Text);
            comLabFee = Convert.ToDouble(comLabFeeTxtBox.Text);

            totalTuitionFee = totalUnits * 1700;
            totalMiscFee = examBookletFee + ciscoLabFee + comLabFee;
            totalTuitionAndFee = totalTuitionFee + totalMiscFee;

            totalTuitionFeeTxtBox.Text = totalTuitionFee.ToString("n");
            totalMiscFeeTxtBox.Text = totalMiscFee.ToString("n");
            totalTuitionAndFeeTxtBox.Text = totalTuitionAndFee.ToString("n");
            totalTuitionandFees2TxtBox.Text = totalTuitionAndFeeTxtBox.Text;
            totalTuitionFee2TxtBox.Text = totalTuitionFeeTxtBox.Text;
            totalMiscFee2TxtBox.Text = totalMiscFeeTxtBox.Text;
            comLabFeeTxtBox.Text = comLabFeeTxtBox.Text;
            ciscoLabfee2TxtBox.Text = ciscoLabfeeTxtBox.Text;
            examBookletfee2TxtBox.Text = examBookletfeeTxtBox.Text;
        }
    }
}

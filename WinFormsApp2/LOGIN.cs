using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp2
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTxtBox.Text == "admin" && PasswordTxtBox.Text == "admin123")
            {
                if (UsernameTxtBox.Text == "admin" && PasswordTxtBox.Text == "admin123")
                {
                    MessageBox.Show("Welcome Admin!");
                    MAINFORM MainForm = new MAINFORM();
                    MainForm.Show();
                    UsernameTxtBox.Clear();
                    PasswordTxtBox.Clear();
                }
                else if (UsernameTxtBox.Text == "Cashier 1" && PasswordTxtBox.Text == "cash1")
                {
                    MessageBox.Show("Welcome Cashier 1!");
                    LESSON_1 lesson1 = new LESSON_1();
                    lesson1.Show();
                    UsernameTxtBox.Clear();
                    PasswordTxtBox.Clear();
                }
                else if (UsernameTxtBox.Text == "Cashier 2" && PasswordTxtBox.Text == "cash2")
                {
                    MessageBox.Show("Welcome Cashier 2!");
                    LESSON2 lesson2 = new LESSON2();
                    lesson2.Show();
                    UsernameTxtBox.Clear();
                    PasswordTxtBox.Clear();
                }
                else if (UsernameTxtBox.Text == "Payroll" && PasswordTxtBox.Text == "payroll123")
                {
                    MessageBox.Show("Welcome Payroll!");
                    PAYROLL payroll = new PAYROLL();
                    payroll.Show();
                    UsernameTxtBox.Clear();
                    PasswordTxtBox.Clear();
                }
                else if (UsernameTxtBox.Text == "Cashier 3" && PasswordTxtBox.Text == "cash3")
                {
                    MessageBox.Show("Welcome Cashier 3!");
                    LESSON3cs lesson3 = new LESSON3cs();
                    lesson3.Show();
                    UsernameTxtBox.Clear();
                    PasswordTxtBox.Clear();
                }
                else if (UsernameTxtBox.Text == "Enrollment" && PasswordTxtBox.Text == "enroll123")
                {
                    MessageBox.Show("Welcome Enrollment!");
                    LAB2 lab2 = new LAB2();
                    lab2.Show();
                    UsernameTxtBox.Clear();
                    PasswordTxtBox.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                    UsernameTxtBox.Clear();
                   PasswordTxtBox.Clear();
                }
            }
        }
    }
}

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
    public partial class STUDENTINFO_CLASS : Form
    {
        string picpath;
        db_connection db_connect = new db_connection();
        

        public STUDENTINFO_CLASS()
        {
            db_connect.connString();
            InitializeComponent();
        }
        private void cleartextboxes()
        {
            studentNumTxtBox.Clear();
            studentNameTxtBox.Clear();
            departmentTxtBox.Clear();
            picpathTxtBox.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.ShowDialog();
            picpath = openFileDialog.FileName;
            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            picpathTxtBox.Text = picpath;


        }

        private void STUDENTINFO_CLASS_Load(object sender, EventArgs e)
        {
            picpathTxtBox.Hide();
            db_connect.sql = "SELECT * FROM studentTb1";
            db_connect.cmd();
            db_connect.sqladapterSelect();
            db_connect.sqldatasetSELECT();
            griddisplay.DataSource = db_connect.sql_dataset.Tables[0];
            ConnectionState.Closed.ToString(); 

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            db_connect.sql = "INSERT INTO studentTb1 (student_id, student_name, department,picpath)" +
                "VALUES('" + studentNumTxtBox.Text + "', '" + studentNameTxtBox.Text + " '  ,' " + departmentTxtBox.Text + " ' ,' "
                 + picpathTxtBox.Text + "')";
            db_connect.cmd();
            db_connect.sqladapterInsert();
            db_connect.sql = "SELECT * FROM studentTb1";
            db_connect.cmd();
            db_connect.sqladapterSelect();
            db_connect.sqldatasetSELECT();
            griddisplay.DataSource = db_connect.sql_dataset.Tables[0];
            cleartextboxes();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            db_connect.sql = "SELECT * FROM studentTb1 WHERE student_id = '" + studentNumTxtBox.Text + "' ";
            db_connect.cmd();
            db_connect.sqladapterSelect();
            db_connect.sqldatasetSELECT();
            griddisplay.DataSource = db_connect.sql_dataset.Tables[0];

            studentNameTxtBox.Text = db_connect.sql_dataset.Tables[0].Rows[0][1].ToString();
            departmentTxtBox.Text = db_connect.sql_dataset.Tables[0].Rows[0][2].ToString();
            picpathTxtBox.Text = db_connect.sql_dataset.Tables[0].Rows[0][3].ToString();
            pictureBox1.Image = Image.FromFile(picpathTxtBox.Text);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            db_connect.sql = "DELETE FROM studentTb1 WHERE student_id = '" + studentNumTxtBox.Text + "' ";
            db_connect.cmd();
            db_connect.sqladapterDelete();
            db_connect.sql = "SELECT * FROM studentTb1";
            db_connect.cmd();
            db_connect.sqladapterSelect();
            db_connect.sqldatasetSELECT();
            griddisplay.DataSource = db_connect.sql_dataset.Tables[0];
            cleartextboxes();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            db_connect.sql = "UPDATE studentTb1 SET student_name = '" + studentNameTxtBox.Text + " ' , department = ' " + departmentTxtBox.Text + " ' , picpath = ' "
                 + picpathTxtBox.Text + " ' WHERE student_id = '" + studentNumTxtBox.Text + "' ";
            db_connect.cmd();
            db_connect.sqladapterUpdate();
            db_connect.sql = "SELECT * FROM studentTb1";
            db_connect.cmd();
            db_connect.sqladapterSelect();
            db_connect.sqldatasetSELECT();
            griddisplay.DataSource = db_connect.sql_dataset.Tables[0];
            cleartextboxes();

        }
    }
}

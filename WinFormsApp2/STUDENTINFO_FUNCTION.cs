using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class STUDENTINFO_FUNCTION : Form
    {
        string picpath;
        string? connectionstring = null;
        SqlConnection sql_connection;
        SqlCommand sql_command;
        DataSet dset;
        SqlDataAdapter sql_dataadapter;
        string sql = null;
    
     
            
        
        public STUDENTINFO_FUNCTION()
        {
            connectionstring = "Data Source = LAPTOP-RF7MTOVT\\SQLEXPRESS; Initial Catalog = SampleDataBaseDb; Trusted_connection = True ";
            sql_connection = new SqlConnection(connectionstring);

            InitializeComponent();
        }
        private void cleartextboxes()
        {
            studentNumTxtBox.Clear();
            studentNameTxtBox.Clear();
            departmentTxtBox.Clear();
            picpathTxtBox.Clear();
        }
        private void cmd()
        {
            sql_command = new SqlCommand(sql, sql_connection);
            sql_command.CommandType = CommandType.Text;
        }
        private void sqlSelect()
        {
            sql = "SELECT * FROM studentTb1";
        }
        private void sqladapterSelect()
        {
            sql_dataadapter = new SqlDataAdapter();
            sql_dataadapter.SelectCommand = sql_command;
            sql_command.ExecuteNonQuery();

        }
        private void sqladapterDelete()
        {
            sql_dataadapter = new SqlDataAdapter();
            sql_dataadapter.DeleteCommand = sql_command;
            sql_command.ExecuteNonQuery();
        }
        private void sqladapterInsert()
        {
            sql_dataadapter = new SqlDataAdapter();
            sql_dataadapter.InsertCommand = sql_command;
            sql_command.ExecuteNonQuery();
        }
        private void sqladapterUpdate()
        {
            sql_dataadapter = new SqlDataAdapter();
            sql_dataadapter.UpdateCommand = sql_command;
            sql_command.ExecuteNonQuery();
        }
        private void sqldataset()
        {
            dset = new DataSet();
            sql_dataadapter.Fill(dset, "studentTb1");
            griddisplay.DataSource = dset.Tables[0];
        }

        private void pictureBox1_Click(object sender, EventArgs e, OpenFileDialog openFileDialog)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathTxtBox.Text = picpath;
        }

        private void STUDENTINFO_FUNCTION_Load(object sender, EventArgs e)
        {
            picpathTxtBox.Hide();
            sql_connection.Open();
            sqlSelect();
            cmd();
            sqladapterSelect();
            sql_connection.Close();

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            sql_connection.Open();
            sql = "INSERT INTO studentTb1 (student_id, student_name, department,picpath)" +
                "VALUES('" + studentNumTxtBox.Text + "', '" + studentNameTxtBox.Text + " '  ,' " + departmentTxtBox.Text + " ' ,' "
                 + picpathTxtBox.Text + "')";
            cmd();
            sqladapterInsert();
            sqlSelect();
            cmd();
            sqladapterSelect();
            sqldataset();
            sql_connection.Close();
            cleartextboxes();
            pictureBox1.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\pfp.jpg");

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            sql_connection.Open();
            sql = "SELECT * FROM studentTb1 WHERE student_id = '" + studentNumTxtBox.Text + "'";
            cmd();
            sqladapterSelect();
            sqldataset();
            studentNameTxtBox.Text = dset.Tables[0].Rows[0][1].ToString();
            departmentTxtBox.Text = dset.Tables[0].Rows[0][2].ToString();
            picpathTxtBox.Text = dset.Tables[0].Rows[0][3].ToString();
            pictureBox1.Image = Image.FromFile(picpathTxtBox.Text);
            sql_connection.Close();

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            sql_connection.Open();
            sql = "DELETE FROM studentTb1 WHERE student_id = '" + studentNumTxtBox.Text + "' ";
            cmd();
            sqladapterDelete();
            sqlSelect();
            cmd();
            sqladapterSelect();
            sqldataset();
            sql_connection.Close();
            cleartextboxes();
            pictureBox1.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\pfp.jpg");
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
             sql_connection.Open();
            sql = "UPDATE studentTb1 SET student_name = '" + studentNameTxtBox.Text + " ' , department = ' " + departmentTxtBox.Text + " ' , picpath = ' "
                + picpathTxtBox.Text + "' WHERE student_id = '" + studentNumTxtBox.Text + "' ";
            cmd();
            sqladapterUpdate();
            sqlSelect();
            cmd();
            sqladapterSelect();
            sqldataset();
            sql_connection.Close();
        }
    }
}

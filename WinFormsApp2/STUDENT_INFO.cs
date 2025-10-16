using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp2
{
    public partial class STUDENT_INFO : Form
    {
        String picpath;
        String connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter adaptersql;
        string sql = null;



        public STUDENT_INFO()
        {
            connectionString = "Data Source = LAPTOP-RF7MTOVT\\SQLEXPRESS; Initial Catalog = SampleDataBaseDb; Trusted_connection = True ";
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();


            sql = "INSERT INTO studentTb1 (student_id, student_name, department,picpath)" +
                "VALUES('" + studentNumTxtBox.Text + "', '" + studentNameTxtBox.Text + " '  ,' " + departmentTxtBox.Text + " ' ,' "
                 + picpathTxtBox.Text + "')";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * FROM studentTb1";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studentTb1");

            griddisplay.DataSource = dset.Tables[0];
            pictureBox1.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\pfp.jpg");
            studentNumTxtBox.Clear();
            studentNameTxtBox.Clear();
            departmentTxtBox.Clear();
            picpathTxtBox.Clear();

            if (connection.State != ConnectionState.Closed)
                connection.Close();

            connection.Close();






        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            sql = "SELECT * FROM studentTb1 WHERE student_id = '" + studentNumTxtBox.Text + "' ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studentTb1");

            griddisplay.DataSource = dset.Tables[0];

            studentNameTxtBox.Text = dset.Tables[0].Rows[0][1].ToString();
            departmentTxtBox.Text = dset.Tables[0].Rows[0][2].ToString();
            picpathTxtBox.Text = dset.Tables[0].Rows[0][3].ToString();
           


            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog
            {

                Title = "Browse Image Files",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
                Multiselect = false




            }; if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image selectedImage = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = selectedImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            sql = "DELETE FROM studentTb1 WHERE student_id = '" + studentNumTxtBox.Text + "' ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.DeleteCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * FROM studentTb1";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studentTb1");

            griddisplay.DataSource = dset.Tables[0];
            pictureBox1.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\pfp.jpg");

            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            sql = "UPDATE studentTb1 SET student_name = '" + studentNameTxtBox.Text + " ' , department = ' " + departmentTxtBox.Text + " ' , picpath = ' "
                 + picpathTxtBox.Text + " ' WHERE student_id = '" + studentNumTxtBox.Text + "' ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.UpdateCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * FROM studentTb1";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            dset = new DataSet();
            adaptersql.Fill(dset, "studentTb1");

            griddisplay.DataSource = dset.Tables[0];
            pictureBox1.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\pfp.jpg");
            studentNumTxtBox.Clear();
            studentNameTxtBox.Clear();
            departmentTxtBox.Clear();
            picpathTxtBox.Clear();

            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\pfp.jpg");
            studentNumTxtBox.Clear();
            studentNameTxtBox.Clear();
            departmentTxtBox.Clear();
            picpathTxtBox.Clear();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\pfp.jpg");
            studentNumTxtBox.Clear();
            studentNameTxtBox.Clear();
            departmentTxtBox.Clear();
            picpathTxtBox.Clear();

        }
    }
}

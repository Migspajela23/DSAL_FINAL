using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class POS_ADMIN : Form
    {
        pos_dbconection pos_dbconection = new pos_dbconection();
        private string picpath;
        private Image pic;
        private object pos_id_comboBoxTxt;

        public POS_ADMIN()
        {
            pos_dbconection.pos_connString();
            InitializeComponent();
        }
        private void cleartextboxes()
        {
            try
            {
                pic = Image.FromFile("C:\\Users\\Miguel Pajela\\Downloads\\pfp.jpg");
                picpathTxtbox1.Clear();
                picpathTxtbox2.Clear();
                pictureBox1.Image = pic;
                pictureBox2.Image = pic;
                nameTxtbox1.Clear();
                nameTxtbox2.Clear();
                priceTxtbox1.Clear();
                priceTxtbox2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clearing textboxes: " + ex.Message);




            }

        }


        private void open_file_image()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.ShowDialog();

        }

        private void POS_ADMIN_Load(object sender, EventArgs e)
        {
            try
            {
                picpathTxtbox1.Hide();
                picpathTxtbox2.Hide();

                pos_dbconection.pos_Select();
                pos_dbconection.pos_cmd();
                pos_dbconection.pos_sqladapterSelect();
                pos_dbconection.pos_sqldatasetSELECT();
                dataGridView1.DataSource = pos_dbconection.pos_sql_dataset.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading data on form load.");

            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                pos_dbconection.pos_sql = "INSERT INTO pos_nameTb1(pos_id, name1, name2) VALUES('" + pos_id_comboBoxTxt + "','" + nameTxtbox1.Text + "','" + nameTxtbox2.Text + "')";
                pos_dbconection.pos_cmd();
                pos_dbconection.pos_sqladapterInsert();

                pos_dbconection.pos_sql = "INSERT INTO pos_priceTb1(pos_id, price1, price2) VALUES('" + priceTxtbox1.Text + "','" + priceTxtbox2.Text + "')";
                pos_dbconection.pos_cmd();
                pos_dbconection.pos_sqladapterInsert();

                pos_dbconection.pos_sql = "INSERT INTO pos_picTb1(pos_id, pic1, pic2) VALUES('" + pos_id_comboBoxTxt + "','" + picpathTxtbox1.Text + "','" + picpathTxtbox2.Text + "')";
                pos_dbconection.pos_cmd();
                pos_dbconection.pos_sqladapterInsert();
                pos_dbconection.pos_Select();
                pos_dbconection.pos_cmd();
                pos_dbconection.pos_sqladapterSelect();
                pos_dbconection.pos_sqldatasetSELECT();
                dataGridView1.DataSource = pos_dbconection.pos_sql_dataset.Tables[0];
                cleartextboxes();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try

            {
                pos_dbconection.pos_sql = "SELECT * FROM pos_nameTb1 INNER JOIN pos_picTb1 ON pos_nameTb1.pos_id = pos_picTb1.pos_id INNER JOIN pos_priceTb1 ON pos_picTb1.pos_id = pos_priceTb1.pos_id WHERE pos_nameTb1.pos_id = '" + pos_id_comboBoxTxt + "'";
                pos_dbconection.pos_cmd();
                pos_dbconection.pos_sqladapterSelect();
                pos_dbconection.pos_sqldatasetSELECT();

                nameTxtbox1.Text = pos_dbconection.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                nameTxtbox2.Text = pos_dbconection.pos_sql_dataset.Tables[0].Rows[0][3].ToString();

                priceTxtbox1.Text = pos_dbconection.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
                priceTxtbox2.Text = pos_dbconection.pos_sql_dataset.Tables[0].Rows[0][47].ToString();

                picpathTxtbox1.Text = pos_dbconection.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
                picpathTxtbox2.Text = pos_dbconection.pos_sql_dataset.Tables[0].Rows[0][25].ToString();

            }


            catch (Exception ex)
            {
                MessageBox.Show("Error searching data: " + ex.Message);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                pos_dbconection.pos_sql = "UPDATE pos_nameTb1 SET name1 = '" + nameTxtbox1.Text + "', name2 = '" + nameTxtbox2.Text + "' WHERE pos_id = '" + pos_id_comboBoxTxt + "'";
                pos_dbconection.pos_cmd();
                pos_dbconection.pos_sqladapterUpdate();

                pos_dbconection.pos_sql = "UPDATE pos_priceTb1 SET price1 = '" + priceTxtbox1.Text + "', price2 = '" + priceTxtbox2.Text + "' WHERE pos_id = '" + pos_id_comboBoxTxt + "'";
                pos_dbconection.pos_cmd();
                pos_dbconection.pos_sqladapterUpdate();

                pos_dbconection.pos_sql = "UPDATE pos_picTb1 SET pic1 = '" + picpathTxtbox1.Text + "', pic2 = '" + picpathTxtbox2.Text + "' WHERE pos_id = '" + pos_id_comboBoxTxt + "'";
                pos_dbconection.pos_cmd();
                pos_dbconection.pos_sqladapterUpdate();
                pos_dbconection.pos_Select();
                pos_dbconection.pos_cmd();
                pos_dbconection.pos_sqladapterSelect();
                pos_dbconection.pos_sqldatasetSELECT();
                dataGridView1.DataSource = pos_dbconection.pos_sql_dataset.Tables[0];
                cleartextboxes();

            }
            catch (Exception)
            {
                MessageBox.Show("Error updating data.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                pos_dbconection.pos_sql = "DELETE FROM pos_nameTb1 WHERE pos_id = '" + pos_id_comboBoxTxt + "'";
                pos_dbconection.pos_cmd();
                pos_dbconection.pos_sqladapterDelete();
                pos_dbconection.pos_sql = "DELETE FROM pos_priceTb1 WHERE pos_id = '" + pos_id_comboBoxTxt + "'";
                pos_dbconection.pos_cmd();
                pos_dbconection.pos_sqladapterDelete();

                pos_dbconection.pos_sql = "DELETE FROM pos_picTb1 WHERE pos_id = '" + pos_id_comboBoxTxt + "'";
                pos_dbconection.pos_cmd();
                pos_dbconection.pos_sqladapterDelete();
                pos_dbconection.pos_Select();
                pos_dbconection.pos_cmd();
                pos_dbconection.pos_sqladapterSelect();
                pos_dbconection.pos_sqldatasetSELECT();
                dataGridView1.DataSource = pos_dbconection.pos_sql_dataset.Tables[0];
                cleartextboxes();
                {
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error deleting data.");


            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            cleartextboxes();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                open_file_image();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.ShowDialog();
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                picpath = openFileDialog.FileName;
                picpathTxtbox1.Text = picpath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {

            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            open_file_image();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathTxtbox2.Text = picpath;
                {
                }
                    }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

    }
}

        
            
        



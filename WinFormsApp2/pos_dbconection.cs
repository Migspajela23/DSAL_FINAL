using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class pos_dbconection
    {
        public string pos_connectionString = null;
        public System.Data.SqlClient.SqlConnection pos_sql_connection;
        public System.Data.SqlClient.SqlCommand pos_sql_command;
        public System.Data.DataSet pos_sql_dataset;
        public System.Data.SqlClient.SqlDataAdapter pos_sql_dataadapter;
        public string pos_sql = null;
        public void pos_connString()
        {
            pos_sql_connection = new System.Data.SqlClient.SqlConnection();
            pos_connectionString = "Data Source = LAPTOP-RF7MTOVT\\SQLEXPRESS; Initial Catalog = POSDB; Trusted_connection = True ";
            pos_sql_connection = new System.Data.SqlClient.SqlConnection(pos_connectionString); 
            pos_sql_connection.ConnectionString = pos_connectionString;
            pos_sql_connection.Open();

        }
        public void pos_cmd()
        {
            pos_sql_command = new System.Data.SqlClient.SqlCommand(pos_sql, pos_sql_connection);
          
            pos_sql_command.CommandType = System.Data.CommandType.Text;
        }
        public void pos_sqladapterSelect()
        {
           
            pos_sql_dataadapter = new System.Data.SqlClient.SqlDataAdapter();
            pos_sql_dataadapter.SelectCommand = pos_sql_command;
             pos_sql_command.ExecuteNonQuery();
        } 
        public void pos_sqladapterInsert()
        {
          
            pos_sql_dataadapter = new System.Data.SqlClient.SqlDataAdapter();
            pos_sql_dataadapter.InsertCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();

        }
        public void pos_sqladapterUpdate()
        {
           
            pos_sql_dataadapter = new System.Data.SqlClient.SqlDataAdapter();
            pos_sql_dataadapter.UpdateCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }
        public void pos_sqladapterDelete()
        {

            pos_sql_dataadapter = new System.Data.SqlClient.SqlDataAdapter();
            pos_sql_dataadapter.DeleteCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }
        public void pos_sqldatasetSELECT()
        {
            
            pos_sql_dataset = new System.Data.DataSet();

            pos_sql_dataadapter.Fill(pos_sql_dataset, "pos_nameTb1");
        }
       
        public void pos_sqldatasetSELECTSALES()
        {
         
            pos_sql_dataset = new System.Data.DataSet();
            pos_sql_dataadapter.Fill(pos_sql_dataset, "SALE_Table");
        }
        public void pos_select()
        {
            pos_sql =
                 "SELECT * FROM pos_nameTbl " +
                 "INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id " +
                 "INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id";


        }
        public void pos_select_cashier()
        {
            pos_sql =
                "SELECT * FROM pos_nameTbl " +
                "INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id " +
                "INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id " +
                "WHERE pos_nameTbl.pos_id = 1";
        }
        public void pos_select_cashier1()
        {
            pos_sql =
                 "SELECT * FROM pos_nameTbl " +
                 "INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id " +
                 "INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id " +
                 "WHERE pos_nameTbl.pos_id = 2";
        }
        public void pos_select_cashier_display()
        {
            pos_sql =
                "SELECT pos_empRegTbl.emp_id, emp_fname, emp_surname, pos_terminal_no, account_type " +
                "FROM pos_empRegTbl " +
                "INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id " +
                "WHERE account_type = 'Administrator'";
        }
        public void pos_select_cashier_SELECTdisplay()
        {
          
            pos_sql_dataset = new System.Data.DataSet();
            pos_sql_dataadapter.Fill(pos_sql_dataset, "pos_empRegTb1");
        }

       
    }
}

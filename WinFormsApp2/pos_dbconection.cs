using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class pos_dbconection
    {
        public string? pos_connectionString = null;
        public SqlConnection? pos_sql_connection;
        public SqlCommand? pos_sql_command;
        public DataSet? pos_sql_dataset;
        public SqlDataAdapter? pos_sql_dataadapter;
        public string? pos_sql = null;
        public void pos_connString()
        {
            pos_connectionString = "Data Source = LAPTOP-RF7MTOVT\\SQLEXPRESS; Initial Catalog = POS_DB; Trusted_connection = True ";
            pos_sql_connection = new SqlConnection(pos_connectionString);
            pos_sql_connection.ConnectionString = pos_connectionString;
            pos_sql_connection.Open();
        }
        public void pos_cmd()
        {
            pos_sql_command = new SqlCommand(pos_sql, pos_sql_connection);
            pos_sql_command.CommandType = CommandType.Text;
        }
        public void pos_sqladapterSelect()
        {
            pos_sql_dataadapter = new SqlDataAdapter();
         pos_sql_dataadapter.SelectCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        public void pos_sqladapterInsert()
        {
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.InsertCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();

        }
        public void pos_sqladapterUpdate()
        {
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.UpdateCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }
        public void pos_sqladapterDelete()
        {
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.DeleteCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }
        public void pos_sqldatasetSELECT()
        {
           pos_sql_dataset = new DataSet();
            
           pos_sql_dataadapter.Fill(pos_sql_dataset, "pos_nameTb1");
        }
       
        public void pos_sqldatasetSELECTSALES()
        {
            pos_sql_dataset = new DataSet();
            pos_sql_dataadapter.Fill(pos_sql_dataset, "SALE_Table");
        }
        public void pos_select()
        {
           pos_sql = "SELECT * FROM  pos_nameTb1 INNER JOIN pos_picTb1 ON pos_nameTb1.pos_id = pos_picTb1.pos_id INNER JOIN pos_priceTb1 ON pos_picTb1.pos_id = pospriceTb1.pos_id";


        }
        public void pos_select_cashier()
        {
            pos_sql = "SELECT *  FROM POS_Table INNER JOIN pos_picTb1 ON pos_nameTb1.pos_id = pos_picTb1.pos_id INNER JOIN pos_priceTb1 ON pos_picTb1.pos_id = pospriceTb1.pos_id WHERE pos_nameTb1.pos_id =1";
        }
        public void pos_select_cashier1()
        {
           pos_sql = "SELECT *  FROM POS_Table INNER JOIN pos_picTb1 ON pos_nameTb1.pos_id = pos_picTb1.pos_id INNER JOIN pos_priceTb1 ON pos_picTb1.pos_id = pospriceTb1.pos_id WHERE pos_nameTb1.pos_id = 2";
        }
        public void pos_select_cashier_display()
        {
            pos_sql = "SELECT pos_empRegTb1. emp_id, emp_name, emp_position, emp_fname, emp_surname,pos_terminal_no, account_type FROM pos_empRegTb1 INNER JOIN useraccountTb1" +
                "ON pos_RegTb1.emp_id = usernameTb1.emp_id WHERE account_type = 'Administrator'";
        }
        public void pos_select_cashier_SELECTdisplay()
        {
            pos_sql_dataset = new DataSet();
            pos_sql_dataadapter.Fill(pos_sql_dataset, "pos_empRegTb1");
        }

        internal void pos_Select()
        {
            throw new NotImplementedException();
        }
    }
}

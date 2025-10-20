using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp2
{
    internal class db_connection
    {
        public string connectionString = null;
        public SqlConnection sql_connection;
        public SqlCommand sql_command;
        public DataSet sql_dataset;
        public SqlDataAdapter sql_dataadapter;
        public string sql = null;

        public void connString()
        {
            connectionString = "Data Source = LAPTOP-RF7MTOVT\\SQLEXPRESS; Initial Catalog = SampleDataBaseDb; Trusted_connection = True ";
            sql_connection = new SqlConnection(connectionString);
            sql_connection.ConnectionString = connectionString;
            sql_connection.Open();
        }
        public void cmd()
        {
            sql_command = new SqlCommand(sql, sql_connection);
            sql_command.CommandType = CommandType.Text;
        }
        public void sqladapterInsert()
        {
            sql_dataadapter = new SqlDataAdapter();
            sql_dataadapter.InsertCommand = sql_command;
            sql_command.ExecuteNonQuery();
        }
        public void sqladapterDelete()
        {
            sql_dataadapter = new SqlDataAdapter();
            sql_dataadapter.DeleteCommand = sql_command;
            sql_command.ExecuteNonQuery();
        }
        public void sqladapterUpdate()
        {
            sql_dataadapter = new SqlDataAdapter();
            sql_dataadapter.UpdateCommand = sql_command;
            sql_command.ExecuteNonQuery();
        }
        public void sqldatasetSELECT()
        {
            sql_dataadapter = new SqlDataAdapter();
            sql_dataadapter.Fill(sql_dataset, "studentTb1");
        }
        public void sqladapterSelect()
        {
            sql_dataadapter = new SqlDataAdapter();
            sql_dataadapter.SelectCommand = sql_command;
            sql_command.ExecuteNonQuery();
        }
    }
}




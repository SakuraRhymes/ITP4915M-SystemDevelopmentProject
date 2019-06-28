using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace SLMCS_ERP
{
    class DBConnection
    {
        private string dbHost;//host address
        private string dbPort;//host port
        private string dbUser;//database login id
        private string dbPassword;//database login password
        private string dbName;//database name
        private MySqlConnection connection;//mysql object

        // Testing config
        public DBConnection() : this("billjjjj.myds.me", "3307", "test", "2121", "DB07062019") { }
        //public DBConnection() : this("localhost", "3306", "root", "", "DB07062019") { }
  
        public DBConnection(string dbHost, string dbPort, string dbUser, string dbPassword, string dbName)
        {
            this.dbHost = dbHost;
            this.dbPort = dbPort;
            this.dbUser = dbUser;
            this.dbPassword = dbPassword;
            this.dbName = dbName;

            string connString = "server=" + dbHost + ";port=" + dbPort + ";uid=" + dbUser + ";pwd=" + dbPassword + ";database=" + dbName;
            connection = new MySqlConnection(connString);
        }
        //open database connection
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //close database connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //get data from table
        public DataTable GetDataTable(string selectQuery)
        {
            DataTable dataTable = new DataTable();
            //open connection
            if (OpenConnection())
            {
                MySqlDataAdapter da = new MySqlDataAdapter(selectQuery, connection);
                DataSet ds = new DataSet();
                ds.Clear();
                da.Fill(ds);
                dataTable = ds.Tables[0];
                CloseConnection();
                return dataTable;
            }
            return dataTable;
        }
        //insert new data to database by short sql statement
        public void Insert(string table, string values)
        {
            try
            {
                OpenConnection();
                string selectQuery = "INSERT INTO " + table + " VALUES (" + values + ")";
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        //insert new data to database by full sql statement
        public void Insert(string insertQuery)
        {
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        //update data from database by short sql statement
        public void Update(string table, string field, string condition)
        {
            try
            {
                OpenConnection();
                string updateQuery = "UPDATE " + table + " SET " + field + " " + condition;
                MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        //update data from database by full sql statement
        public void Update(string updateQuery)
        {
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        //delete data from database by short sql statement
        public void Delete(string table, string condition)
        {
            try
            {
                OpenConnection();
                string deleteQuery = "DELETE FROM " + table + " " + condition;
                MySqlCommand cmd = new MySqlCommand(deleteQuery, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        //delete data from database by full sql statement
        public void Delete(string deleteQuery)
        {
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(deleteQuery, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
    }
}

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

        public DBConnection() : this("billjjjj.myds.me", "3307", "test", "2121", "sql_demo") { }
  
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
        public bool openConnection()
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
        public bool closeConnection()
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
        public DataTable getDataTable(string selectQuery)
        {
            DataTable dataTable = new DataTable();
            //open connection
            if (openConnection())
            {
                MySqlDataAdapter da = new MySqlDataAdapter(selectQuery, connection);
                DataSet ds = new DataSet();
                ds.Clear();
                da.Fill(ds);
                dataTable = ds.Tables[0];
                closeConnection();
                return dataTable;
            }
            return dataTable;
        }
        //insert new data to database by short sql statement
        public void insert(string table, string values)
        {
            try
            {
                openConnection();
                string selectQuery = "INSERT INTO " + table + " VALUES (" + values + ")";
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                cmd.ExecuteNonQuery();
                closeConnection();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        //insert new data to database by full sql statement
        public void insert(string insertQuery)
        {
            try
            {
                openConnection();
                MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                cmd.ExecuteNonQuery();
                closeConnection();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        //update data from database by short sql statement
        public void update(string table, string field, string condition)
        {
            try
            {
                openConnection();
                string updateQuery = "UPDATE " + table + " SET " + field + " " + condition;
                MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                cmd.ExecuteNonQuery();
                closeConnection();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        //update data from database by full sql statement
        public void update(string updateQuery)
        {
            try
            {
                openConnection();
                MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                cmd.ExecuteNonQuery();
                closeConnection();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        //delete data from database by short sql statement
        public void delete(string table, string condition)
        {
            try
            {
                openConnection();
                string deleteQuery = "DELETE FROM " + table + " " + condition;
                MySqlCommand cmd = new MySqlCommand(deleteQuery, connection);
                cmd.ExecuteNonQuery();
                closeConnection();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        //delete data from database by full sql statement
        public void delete(string deleteQuery)
        {
            try
            {
                openConnection();
                MySqlCommand cmd = new MySqlCommand(deleteQuery, connection);
                cmd.ExecuteNonQuery();
                closeConnection();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
    }
}

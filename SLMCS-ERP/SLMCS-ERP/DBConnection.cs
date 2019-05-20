using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SLMCS_ERP
{
    class DBConnection
    {
        private string dbHost = "";//host address
        private string dbPort = "";//host port
        private string dbUser = "";//database login id
        private string dbPassword = "";//database login password
        private string dbName = "";//database name
        private MySqlConnection connection;

        public DBConnection()
        {
            string connString = "server=" + dbHost + ";port=" + dbPort + ";uid=" + dbUser + ";pwd=" + dbPassword + ";database=" + dbName;
            connection = new MySqlConnection(connString);
        }

        public bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

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
    }
}

using SLMCS_ERP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLMCS_Class
{
    public class Report
    {
        private DBConnection dbConnection;
        private DataTable reportTable;

        public Report()
        {
            dbConnection = new DBConnection();
        }

        public DataTable GetTopTenDealerTable()
        {
            string query = "SELECT * FROM TopTenDealer LIMIT 10";
            return dbConnection.GetDataTable(query);
        }

        public DataTable GetTopTenDealerTableYear()
        {
            string query = "SELECT year FROM TopTenDealer GROUP BY year LIMIT 10";
            return dbConnection.GetDataTable(query);
        }
    }
}

using SLMCS_ERP;
using System.Data;

namespace SLMCS_Class
{
    public class Dealer
    {
        private DBConnection dbConnection;

        public Dealer()
        {
            dbConnection = new DBConnection();
        }

        public DataTable SearchForDealer(string dealerID)
        {
            string query = "SELECT * FROM Dealer WHERE DealerID = '" + dealerID + "'";
            return dbConnection.getDataTable(query);
        }
    }
}
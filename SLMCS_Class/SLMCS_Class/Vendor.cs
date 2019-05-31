using SLMCS_ERP;
using System.Data;

namespace SLMCS_Class
{
    public class Vendor
    {
        private string vendorID;
        private string vendorName;
        private string vendorAddress;
        private string vendorPhoneNo;

        private DBConnection dbConnection;
        public Vendor()
        {
            dbConnection = new DBConnection();
        }

        public Vendor(string vendorID)
        {
            dbConnection = new DBConnection();
        }

        public DataTable GetVendorTable()
        {
            string query = "SELECT VendorID,VendorName FROM Vendor";
            return dbConnection.GetDataTable(query);
        }

    }
}
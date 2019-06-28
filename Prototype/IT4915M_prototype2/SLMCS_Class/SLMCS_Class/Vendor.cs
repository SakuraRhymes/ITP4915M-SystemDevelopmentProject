using System;
using SLMCS_ERP;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Linq;

namespace SLMCS_Class
{
    public class Vendor
    {
        private DBConnection dbConnection;
        private DataTable vendorTable;
        private string vendorID;
        private string vendorName;
        private string vendorAddress;
        private string vendorPhoneNo;
        private string vendorStatus;

        public string VendorID { get => vendorID; set => vendorID = value; }
        public string VendorName { get => vendorName; set => vendorName = value; }
        public string VendorAddress { get => vendorAddress; set => vendorAddress = value; }
        public string VendorPhoneNo { get => vendorPhoneNo; set => vendorPhoneNo = value; }
        public string VendorStatus { get => vendorStatus; set => vendorStatus = value; }

        public Vendor()
        {
            dbConnection = new DBConnection();
        }
        public Vendor(string vendorID)
        {
            dbConnection = new DBConnection();
            string query = "SELECT * FROM Vendor WHERE VendorID ='" + vendorID + "'";

            vendorTable = dbConnection.GetDataTable(query);
            DataRow[] rows = vendorTable.Select();

            this.vendorID = (string)rows[0]["VendorID"];
            this.vendorName = (string)rows[0]["VendorName"];
            this.vendorAddress = (string)rows[0]["VendorAddress"];
            this.vendorPhoneNo = (string)rows[0]["VendorPhoneNo"];
            this.vendorStatus = (string)rows[0]["VendorStatus"];
        }
        public DataTable GetVendorTable()
        {
            string query = "SELECT VendorID,VendorName FROM Vendor";
            return dbConnection.GetDataTable(query);
        }

        public DataTable SearchForVendor(string vendorID)
        {
            string query = "SELECT * FROM Vendor WHERE VendorID = '" + vendorID + "'";
            return dbConnection.GetDataTable(query);
        }

        public void UpdateVendorDetail(string vendorID, string vendorName, string vendorAddress, string vendorPhoneNo, string vendorStatus)
        {
            string queryString = "UPDATE Vendor SET VendorName='{0}',  VendorPhoneNo='{1}',VendorAddress='{2}', VendorStatus='{3}' WHERE VendorID='{4}'";

            string query = string.Format(queryString, vendorName, vendorPhoneNo, vendorAddress, vendorStatus, vendorID);
            dbConnection.Update(query);
        }

        public DataTable Management_GetVendorTable(string condition)
        {
            string query = "SELECT VendorID, VendorName, VendorPhoneNo, VendorStatus FROM Vendor ";
            if (condition != "")
            {
                query += "WHERE " + condition;
            }
            return dbConnection.GetDataTable(query);
        }


        public void CreateNewVendor(string vendorID, string vendorName, string vendorPhoneNo, string vendorAddress, string vendorStatus)
        {
            
            string queryString = "INSERT INTO Vendor VALUES ('{0}','{1}','{2}','{3}','{4}')";
            string query = string.Format(queryString, vendorID, vendorName, vendorPhoneNo, vendorAddress, vendorStatus);
            try
            {
                dbConnection.Insert(query);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public void updataVendorStatus(string vendorID, string vendorStatus)
        {
            string query = "UPDATE Vendor SET VendorStatus = \'" + vendorStatus + "\' WHERE VendorID = \'" + vendorID + "\'";
            try
            {
                dbConnection.Insert(query);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public string GetNextVendorID()
        {
            string query = "SELECT MAX(VendorID) FROM Vendor";
            vendorTable = dbConnection.GetDataTable(query);

            DataRow[] rows = vendorTable.Select();
            string vendorIDFull = (string)rows[0]["MAX(VendorID)"];
            if (vendorIDFull == "")
            {
                return "V00001";
            }
            else
            {
                string vendorIDNum = vendorIDFull.Substring(1);
                string fillZore = "";
                string nextVendorID = (Convert.ToInt32(vendorIDNum) + 1).ToString();
                for (int i = nextVendorID.Length; i < 7; i++)
                {
                    fillZore += "0";
                }
                return "V" + fillZore + nextVendorID;
            }
        }
    }
}
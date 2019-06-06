using System;
using SLMCS_ERP;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Linq;

namespace SLMCS_Class
{
    public class Dealer
    {
        private DBConnection dbConnection;
        private DataTable dealerTable;
        private string dealerID;
        private string dealerName;
        private string dealerInvoiceAddress;
        private string dealerShippingAddress;
        private string dealerPhoneNo;
        private string dealerStatus;

        public string DealerID { get => dealerID; set => dealerID = value; }
        public string DealerName { get => dealerName; set => dealerName = value; }
        public string DealerInvoiceAddress { get => dealerInvoiceAddress; set => dealerInvoiceAddress = value; }
        public string DealerShippingAddress { get => dealerShippingAddress; set => dealerShippingAddress = value; }
        public string DealerPhoneNo { get => dealerPhoneNo; set => dealerPhoneNo = value; }
        public string DealerStatus { get => dealerStatus; set => dealerStatus = value; }

        public Dealer()
        {
            dbConnection = new DBConnection();
        }
        public Dealer(string dealerID)
        {
            dbConnection = new DBConnection();
            string query = "SELECT * FROM Dealer WHERE DealerID ='" + dealerID + "'";

            dealerTable = dbConnection.GetDataTable(query);
            DataRow[] rows = dealerTable.Select();

            this.dealerID = (string)rows[0]["DealerID"];
            this.dealerName = (string)rows[0]["DealerName"];
            this.dealerInvoiceAddress = (string)rows[0]["DealerInvoiceAddress"];
            this.dealerShippingAddress = (string)rows[0]["DealerShippingAddress"];
            this.dealerPhoneNo = (string)rows[0]["DealerPhoneNo"];
            this.dealerStatus = (string)rows[0]["DealerStatus"];
        }

        public DataTable SearchForDealer(string dealerID)
        {
            string query = "SELECT * FROM Dealer WHERE DealerID = '" + dealerID + "'";
            return dbConnection.GetDataTable(query);
        }

        public void UpdateDealerDetail(string dealerID, string dealerName, string dealerInvoiceAddress, string dealerShippingAddress, string dealerPhoneNo, string dealerStatus)
        {
            string queryString = "UPDATE Dealer SET DealerName='{0}', DealerInvoiceAddress='{1}', DealerShippingAddress='{2}' ,DealerPhoneNo='{3}', DealerStatus='{4}' WHERE DealerID='{5}'";
            
            string query = string.Format(queryString, dealerName, dealerInvoiceAddress, dealerShippingAddress, dealerPhoneNo, dealerStatus, dealerID);
            MessageBox.Show(query);
            dbConnection.Update(query);
        }

        public DataTable GetDealerTable(string condition)
        {
            string query = "SELECT DealerID, DealerName, DealerPhoneNo, DealerStatus FROM Dealer ";
            if (condition != "")
            {
                query += condition;
            }

            return dbConnection.GetDataTable(query);
        }


        public void CreateNewDealer(string dealerName, string dealerInvoiceAddress, string dealerShippingAddres, string dealerPhoneNo, string dealerStatus)
        {
            string dealerID = GetNextDealerID();
            string queryString = "INSERT INTO Dealer VALUES ('{0}','{1}','{2}','{3}','{4}',{5})";
            string query = string.Format(queryString, dealerID, dealerName, dealerInvoiceAddress, dealerShippingAddres, dealerPhoneNo, dealerStatus);

            try
            {
                dbConnection.Insert(query);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public void updataDealerStatus(string dealerID, string dealerStatus)
        {
            string query = "UPDATE Dealer SET DealerStatus = \'"+ dealerStatus +"\' WHERE DealerID = \'"+dealerID+"\'";
            try
            {
                dbConnection.Insert(query);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public string GetNextDealerID()
        {
            string query = "SELECT MAX(dealerID) FROM Dealer";
            dealerTable = dbConnection.GetDataTable(query);

            DataRow[] rows = dealerTable.Select();
            string dealerIDFull = (string)rows[0]["MAX(dealerID)"];
            if (dealerIDFull == "")
            {
                return "D00001";
            }
            else
            {
                string dealerIDNum = dealerIDFull.Substring(1);
                string fillZore = "";
                string nextDealerID = (Convert.ToInt32(dealerIDNum) + 1).ToString();
                for (int i = nextDealerID.Length; i < 7; i++)
                {
                    fillZore += "0";
                }
                return "D" + fillZore + nextDealerID;
            }
        }
    }
}
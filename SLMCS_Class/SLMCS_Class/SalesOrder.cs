using SLMCS_ERP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SLMCS_Class
{
    public class SalesOrder
    {
        private List<SalesOrderLine> _salesOrderLine;

        private string salesOrderID;
        private string staffID;
        private string dealerID;
        private string salesOrderDate;
        private string salesOrderEditDate;
        private string salesDispatchDate;
        private string salesDeliveryDate;
        private string salesOrderStatus;

        private DBConnection dbConnection;
        private DataTable salesOrderTable;

        public SalesOrder()
        {
            _salesOrderLine = new List<SalesOrderLine>();
            dbConnection = new DBConnection();
        }

        public string GetNextSalesOrderID()
        {
            string query = "SELECT COUNT(SalesOrderID) FROM SalesOrder WHERE SalesOrderDate = " + DateTime.Now.ToString("yy/mm/dd");
            salesOrderTable = dbConnection.getDataTable(query);

            string count = "";
            foreach (DataRow row in salesOrderTable.Rows)
            {
                count = row["COUNT(SalesOrderID)"].ToString();
            }

            MessageBox.Show(count);
            return "";
        }

        public void updateStatus(string status)
        {
            salesOrderStatus = status;
        }

        public List<SalesOrder> _SalesOrderLine {
            get;
            set;
        }

        public double getTotalPrice()
        {
            double total = 0;
            foreach (var salesOrderLine in _salesOrderLine)
            {
                total += salesOrderLine.getSubtotalPrice();
            }
            return total;
        }
    }
}
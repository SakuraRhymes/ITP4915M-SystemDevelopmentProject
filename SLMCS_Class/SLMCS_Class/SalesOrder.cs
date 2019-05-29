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

        public string SalesOrderID { get => "SO190529000005"; }
        public string StaffID { get => "S19002708"; }
        public string SalesOrderDate { get => "190529"; }
        public string DealerName { get => "fuck YOU Tony"; }
        public string DealerAddress { get => "trash bin"; }
        public string DealerID { get => "D0000001"; }


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

        public List<SalesOrderLine> _SalesOrderLine {
            get => _salesOrderLine;          
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

        public void addProduct(Product product, int quantity)
        {
            SalesOrderLine salesOrderLine = new SalesOrderLine(this, product, quantity, product.ProductPrice);
            _salesOrderLine.Add(salesOrderLine);
        }

        public void placeOrder()
        {
            string query = "INSERT INTO SalesOrder VALUES ('" + SalesOrderID + "','" + StaffID + "','" + DealerID +
                           "','" + SalesOrderDate + "','" + SalesOrderDate + "','" + SalesOrderDate + "','" + SalesOrderDate + "','TEST')";
            dbConnection.insert(query);

            foreach(var salesOrderLine in _salesOrderLine)
            {
                salesOrderLine.placeSalesOrderLine();
            }
        }
    }
}
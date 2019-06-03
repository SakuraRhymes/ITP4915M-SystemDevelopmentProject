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

        public string SalesOrderID { get => salesOrderID; }
        public string StaffID { get => "S19002708"; }
        public string SalesOrderDate { get => salesOrderDate; }
        public string DealerID {
            get => dealerID;
            set { dealerID = value; }
        }
        public List<SalesOrderLine> _SalesOrderLine
        {
            get => _salesOrderLine;
        }

        public SalesOrder()
        {
            _salesOrderLine = new List<SalesOrderLine>();
            dbConnection = new DBConnection();

            salesOrderID = getNextSalesOrderID();
            salesOrderDate = DateTime.Now.ToString("yy-MM-dd");
        }

        public string getNextSalesOrderID()
        {
            string query = "SELECT COUNT(SalesOrderID) FROM SalesOrder WHERE SalesOrderDate = \"" + DateTime.Now.ToString("yyMMdd")+"\"";
            salesOrderTable = dbConnection.GetDataTable(query);

            string count = "";
            foreach (DataRow row in salesOrderTable.Rows)
            {
                count = row["COUNT(SalesOrderID)"].ToString();
            }
            count = (Int32.Parse(count) + 1).ToString();
            string nextOrderID = "SO" + DateTime.Now.ToString("yyMMdd") + count.PadLeft(6, '0');
            return nextOrderID;
        }

        public DataTable getSalesOrderTableBySalesOrderStatus(string SalesOrderStatus)
        {
            string query = "SELECT SalesOrderID, StaffID, DealerID, SalesOrderDate, SalesOrderStatus FROM SalesOrder WHERE  SalesOrderStatus = \""+SalesOrderStatus+"\"";
            return dbConnection.GetDataTable(query);
        }


        public DataTable Dispatching_getSalesOrderByOrderID(string OrderID)
        {
            string query = "SELECT SalesOrderID, StaffID, DealerID, SalesOrderDate, SalesOrderStatus FROM SalesOrder WHERE OrderID = \"" + OrderID + "\" AND SalesOrderStatus = \"Dispatching\"";
            return dbConnection.GetDataTable(query);
        }

        public DataTable Dispatching_getSalesOrderByStaffID(string StaffID)
        {
            string query = "SELECT SalesOrderID, StaffID, DealerID, SalesOrderDate, SalesOrderStatus FROM SalesOrder WHERE StaffID = \"" + StaffID + "\" AND SalesOrderStatus = \"Dispatching\"";
            return dbConnection.GetDataTable(query);
        }

        public DataTable Dispatching_getSalesOrderByDealerID(string DealerID)
        {
            string query = "SELECT SalesOrderID, StaffID, DealerID, SalesOrderDate, SalesOrderStatus FROM SalesOrder WHERE DealerID = \"" + DealerID + "\" AND SalesOrderStatus = \"Dispatching\"";
            return dbConnection.GetDataTable(query);
        }

        public DataTable getSalesTableByWhereQuery(string condition)
        {
            string query = "SELECT SalesOrderID, StaffID, DealerID, SalesOrderDate, SalesOrderStatus FROM SalesOrder WHERE " + condition;
            return dbConnection.GetDataTable(query);
        }
        public DataTable getSalesOrderLineBySalesOrderID(string salesOrderID)
        {
            dbConnection = new DBConnection();
            string query = "SELECT * FROM SalesOrderLine WHERE SalesOrderID = \"" + salesOrderID + "\"";
            return dbConnection.GetDataTable(query);
        }
        public void updataSalesOrderStatusInDB(string salesOrderID, string status)
        {
            string query = "UPDATE SalesOrder SET SalesOrderStatus = \"" + status + "\" , SalesDispatchDate = \""+ DateTime.Now.ToString("yy-MM-dd") +"\" WHERE SalesOrder.SalesOrderID = \"" + salesOrderID + "\"";
            dbConnection.Update(query);
        }

        public String[] updataDealerInfo(String dealerID)
        {
            String[] result = null;
            Dealer dealer = new Dealer();
               DataTable dt = dealer.SearchForDealer(dealerID);

            if (dt.Rows.Count == 1)
            {
                result = new string[2];
                DataRow[] rows = dt.Select();
                result[0] = (string)rows[0]["DealerName"];
                result[1] = (string)rows[0]["DealerShippingAddress"];
                this.dealerID = dealerID;
            }
            return result;
        }

        public String[] updataProductInfo(String productID)
        {
            String[] result = null;
            Product product = new Product();
            DataTable dt = product.SearchForProduct(productID);

            if (dt.Rows.Count == 1)
            {
                result = new string[2];
                DataRow[] rows = dt.Select();
                result[0] = (string)rows[0]["ProductName"];
                result[1] = product.getSaleableQuantity(productID).ToString();
            }
            return result;
        }

        public void updateStatus(string status)
        {
            salesOrderStatus = status;
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
                           "','" + SalesOrderDate + "',null,null,null,'Dispatching')";
            MessageBox.Show(query);

            dbConnection.Insert(query);

            foreach(var salesOrderLine in _salesOrderLine)
            {
                salesOrderLine.placeSalesOrderLine();
            }
        }
    }
}
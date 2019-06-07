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
        private string salesOrderCompletedDate;
        private string salesDispatchDate;
        private string salesOrderStatus;

        private DBConnection dbConnection;
        private DataTable salesOrderTable;

        public string SalesOrderID { get => salesOrderID; }
        public string StaffID { get => staffID; set { staffID = value; } }
        public string DealerID
        {
            get => dealerID;
            set { dealerID = value; }
        }
        public string SalesOrderDate { get => salesOrderDate; }
        public string SalesOrderEditDate { get => salesOrderEditDate; }
        public string SalesDispatchDate { get => salesDispatchDate; }
        public string SalesOrderCompletedDate { get => salesOrderCompletedDate; }
        public string SalesOrderStatus { get => salesOrderStatus; }
        public List<SalesOrderLine> _SalesOrderLine
        {
            get => _salesOrderLine;
        }
        public string SalesOrderStatus1 { get => salesOrderStatus; set => salesOrderStatus = value; }

        public SalesOrder()
        {
            _salesOrderLine = new List<SalesOrderLine>();
            dbConnection = new DBConnection();
            salesOrderID = getNextSalesOrderID();
            salesOrderDate = DateTime.Now.ToString("yy-MM-dd");
        }

        public SalesOrder(string orderID)
        {
            _salesOrderLine = new List<SalesOrderLine>();
            dbConnection = new DBConnection();

            string query = "WHERE SalesOrderID = '" + orderID + "'";
            DataTable dt = searchSalesOrder(query);
            //MessageBox.Show(query);
            DataRow[] rows = dt.Select();

            salesOrderID = (string)rows[0]["SalesOrderID"];
            staffID = (string)rows[0]["StaffID"];
            dealerID = (string)rows[0]["DealerID"];
            salesOrderDate = ((DateTime)rows[0]["SalesOrderDate"]).ToString("yy-MM-dd");
            salesOrderEditDate = ((DateTime)rows[0]["SalesOrderEditDate"]).ToString("yy-MM-dd");
            //MessageBox.Show(rows[0]["SalesDispatchDate"].ToString());
            if (rows[0]["SalesDispatchDate"].ToString() != "")
            {
                salesDispatchDate = ((DateTime)rows[0]["SalesDispatchDate"]).ToString("yy-MM-dd");
            }
            if (rows[0]["SalesOrderCompletedDate"].ToString() != "")
            {
                salesDispatchDate = ((DateTime)rows[0]["SalesOrderCompletedDate"]).ToString("yy-MM-dd");
            }
            salesOrderStatus = (string)rows[0]["SalesOrderStatus"];
        }

        public string getNextSalesOrderID()
        {
            string query = "SELECT COUNT(SalesOrderID) FROM SalesOrder WHERE SalesOrderDate = \"" + DateTime.Now.ToString("yyMMdd") + "\"";
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
            string query = "SELECT SalesOrderID, ProductID, Quantity FROM SalesOrderLine WHERE SalesOrderID = \"" + salesOrderID + "\"";
            return dbConnection.GetDataTable(query);
        }
        public void updataSalesOrderStatusInDB(string salesOrderID, string status)
        {
            string query = "UPDATE SalesOrder SET SalesOrderStatus = \"" + status + "\" , SalesDispatchDate = \""+ DateTime.Now.ToString("yy-MM-dd") +"\" WHERE SalesOrder.SalesOrderID = \"" + salesOrderID + "\"";
            //MessageBox.Show(query);
            dbConnection.Update(query);
        }

        public void updateSalesOrderEditDate()
        {
            string query = "UPDATE SalesOrder SET SalesOrderEditDate = \"" + DateTime.Now.ToString("yy-MM-dd") + "\" WHERE SalesOrderID = \"" + salesOrderID + "\"";
            //MessageBox.Show(query);
            dbConnection.Update(query);
        }

        public void updateSalesOrderCompletedDate()
        {
            string query = "UPDATE SalesOrder SET SalesOrderCompletedDate = \"" + DateTime.Now.ToString("yy-MM-dd") + "\" WHERE SalesOrderID = \"" + salesOrderID + "\"";
            //MessageBox.Show(query);
            dbConnection.Update(query);

            updateSalesOrderEditDate();
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

            string query = "UPDATE SalesOrder SET SalesOrderStatus = '" + status + "' WHERE SalesOrderID = '" + SalesOrderID + "'";
            dbConnection.Update(query);

            updateSalesOrderEditDate();
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

        public string getTotalPriceFromDB()
        {
            string query = "SELECT * FROM SalesOrderTotalAmount WHERE SalesOrderID = '" + SalesOrderID + "'";
            DataTable dt = dbConnection.GetDataTable(query);
            DataRow[] rows = dt.Select();
            return rows[0]["SUM(Quantity * ProductPrice)"].ToString();
        }

        public void addProduct(Product product, int quantity)
        {
            SalesOrderLine salesOrderLine = new SalesOrderLine(this, product, quantity, product.ProductPrice);
            _salesOrderLine.Add(salesOrderLine);
        }

        public void placeOrder(String status)
        {
            salesOrderEditDate = DateTime.Now.ToString("yy-MM-dd");
            string query = "INSERT INTO SalesOrder VALUES ('" + SalesOrderID + "','" + StaffID + "','" + DealerID +
                           "','" + SalesOrderDate + "','" + salesOrderEditDate + "',null,null,'" + status + "')";
            //MessageBox.Show(query);
            dbConnection.Insert(query);

            foreach (var salesOrderLine in _salesOrderLine)
            {
                salesOrderLine.placeSalesOrderLine();
            }
        }

        public DataTable searchSalesOrder(string condition)
        {
            string query = "SELECT * FROM SalesOrder ";
            if (condition != "")
            {
                query += condition;
            }
            //MessageBox.Show(query);
            return dbConnection.GetDataTable(query);
        }

        public DataTable searchOrderLine()
        {
            string query = "SELECT SalesOrderLine.ProductID, Product.ProductName, Product.ProductType, Product.ProductUnit, SalesOrderLine.Quantity, SalesOrderLine.ProductPrice, SalesOrderLine.Quantity * SalesOrderLine.ProductPrice AS Subtotal FROM SalesOrderLine, Product WHERE SalesOrderLine.ProductID = Product.ProductID AND SalesOrderID = '" + SalesOrderID + "'";
            return dbConnection.GetDataTable(query);
        }
        public void cancelOrder()
        {
            string productID;
            int quantity;
            string query = "SELECT * FROM SalesOrderLine WHERE SalesOrderID = '" + SalesOrderID + "'";
            DataTable dt = dbConnection.GetDataTable(query);
            DataRow[] rows = dt.Select();

            foreach (DataRow row in rows)
            {
                productID = row["ProductID"].ToString();
                quantity = (int)row["Quantity"];
                //MessageBox.Show(productID +" "+ quantity);

                Product product = new Product(productID);
                product.updateReserveQuantity(-quantity);
            }
        }
    }
}
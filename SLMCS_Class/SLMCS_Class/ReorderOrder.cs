using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SLMCS_ERP;
using System.Data;
using System.Windows.Forms;

namespace SLMCS_Class
{
    public class ReorderOrder
    {
        private string reorderOrderID;
        private string staffID;
        private string reorderOrderDate;
        private string reorderOrderEditDate;
        private string reorderOrderReceivedDate;
        private string reorderOrderCompletedDate;
        private string reorderOrderStatus;

        private List<ReorderOrderLine> _reorderOrderLine; 
        private Staff _staff;

        private DBConnection dbConnection;
        private DataTable reorderOrderTable;

        public ReorderOrder()
        {
            dbConnection = new DBConnection();
            _reorderOrderLine = new List<ReorderOrderLine>();
            ReorderOrderID = GetNextReorderOrderID();
        }

        public ReorderOrder(string reorderOrderID)
        {
            _reorderOrderLine = new List<ReorderOrderLine>();
            //ReorderOrderID = GetNextReorderOrderID();

            dbConnection = new DBConnection();
            string query = "SELECT * FROM ReorderOrder WHERE ReorderOrderID ='" + reorderOrderID + "'";

            reorderOrderTable = dbConnection.GetDataTable(query);
            DataRow[] rows = reorderOrderTable.Select();

            ReorderOrderID = (string)rows[0]["ReorderOrderID"];
            StaffID = (string)rows[0]["StaffID"];
            if (rows[0]["ReorderOrderDate"].ToString() != "") {
                ReorderOrderDate = ((DateTime)rows[0]["ReorderOrderDate"]).ToString("dd/MM/yyyy");
            }
            if (rows[0]["ReorderOrderEditDate"].ToString() != "")
            {
                ReorderOrderEditDate = ((DateTime)rows[0]["ReorderOrderEditDate"]).ToString("dd/MM/yyyy");
            }
            if (rows[0]["ReorderOrderReceivedDate"].ToString() != "")
            {
                ReorderOrderReceivedDate = ((DateTime)rows[0]["ReorderOrderReceivedDate"]).ToString("dd/MM/yyyy");
            }
            if (rows[0]["ReorderOrderCompletedDate"].ToString() != "")
            {
                ReorderOrderCompletedDate = ((DateTime)rows[0]["ReorderOrderCompletedDate"]).ToString("dd/MM/yyyy");
            }   
            ReorderOrderStatus = (string)rows[0]["ReorderOrderStatus"];
        }

        public void PlaceReorderOrder(Staff staff, string reorderOrderDate)
        {
            _staff = staff;
            string query = "INSERT INTO ReorderOrder VALUES ('" + ReorderOrderID + "','" + _staff.StaffID + 
                           "','" + reorderOrderDate + "','" + reorderOrderDate + "',null,null,'Processing')";
            //MessageBox.Show(query);

            dbConnection.Insert(query);

            foreach (var reorderOrderLine in _reorderOrderLine)
            {
                reorderOrderLine.PlaceReorderOrderLine();
            }
        }

        public void AddReorderProductLine(Product product, int quantity)
        {
            ReorderOrderLine reorderOrderLine = new ReorderOrderLine(this, product, quantity);
            _reorderOrderLine.Add(reorderOrderLine);
        }

        public void RemoveReorderProductLine(ReorderOrderLine reorderOrderLine)
        {
            _reorderOrderLine.Remove(reorderOrderLine);
        }

        public List<ReorderOrderLine> GetReorderProductLine()
        {
            return _reorderOrderLine;
        }

        public string GetNextReorderOrderID()
        {
            string query = "SELECT COUNT(ReorderOrderID) FROM ReorderOrder WHERE ReorderOrderDate = \"" + DateTime.Now.ToString("yyMMdd") + "\"";
            reorderOrderTable = dbConnection.GetDataTable(query);
            string count = "";
            foreach (DataRow row in reorderOrderTable.Rows)
            {
                count = row["COUNT(ReorderOrderID)"].ToString();
            }
            count = (Int32.Parse(count) + 1).ToString();
            string nextReorderOrderID = "RO" + DateTime.Now.ToString("yyMMdd") + count.PadLeft(6, '0');
            return nextReorderOrderID;
        }

        //public DataTable GetReorderOrderTable(string condition)
        //{
        //    string query = "SELECT ReorderOrderID,StaffID,ReorderOrderDate,ReorderOrderEditDate,ReorderOrderReceivedDate,ReorderOrderCompletedDate,ReorderOrderStatus FROM ReorderOrder ";
        //    if (condition != "")
        //    {
                
        //        query += condition;
        //    }
        //    reorderOrderTable = dbConnection.GetDataTable(query);
        //    return reorderOrderTable;
        //}

        

        public DataTable GetInwardGoodsRecordTable(string condition)
        {
            //string query = "SELECT ReorderOrderID,StaffID,ReorderOrderDate,ReorderOrderCompletedDate FROM ReorderOrder WHERE ReorderOrderStatus = 'Completed' ";
            string query = "SELECT ReorderOrderID AS 'Order ID',StaffID,ReorderOrderDate AS 'OrderDate',ReorderOrderCompletedDate AS 'CompletedDate' FROM ReorderOrder WHERE ReorderOrderStatus = 'Completed'";
            if (condition != "")
            {
                query += " AND " + condition;
            }
            //MessageBox.Show(query);
            reorderOrderTable = dbConnection.GetDataTable(query);
            return reorderOrderTable;
        }

        public DataTable GetReceivedReorderOrderTable()
        {
            string query = "SELECT ReorderOrderID,StaffID,ReorderOrderDate,ReorderOrderReceivedDate FROM ReorderOrder WHERE ReorderOrderStatus = 'Received' ";
           
            reorderOrderTable = dbConnection.GetDataTable(query);
            return reorderOrderTable;
        }

        public DataTable GetReorderOrderLineTable(string reorderOrderID)
        {
            //string query = "SELECT * FROM ReorderOrderLine WHERE ReorderOrderID = '" + reorderOrderID + "'";
            string query = "SELECT Product.ProductID,Product.ProductName,Product.ProductType,Product.ProductUnit,ReorderOrderLine.Quantity FROM Product,ReorderOrderLine WHERE Product.ProductID = ReorderOrderLine.ProductID AND ReorderOrderID = '" + reorderOrderID + "'";
            reorderOrderTable = dbConnection.GetDataTable(query);
            return reorderOrderTable;
        }

        public void ConfirmReorderOrder()
        {
            string productID;
            int quantity;
            string query = "SELECT * FROM ReorderOrderLine WHERE ReorderOrderID = '" + ReorderOrderID + "'";
            DataTable dt = dbConnection.GetDataTable(query);
            DataRow[] rows = dt.Select();

            foreach (DataRow row in rows)
            {
                productID = row["ProductID"].ToString();
                quantity = (int)row["Quantity"];

                Product product = new Product(productID);
                product.updateActualQuantity(quantity);
            }
        }

        public void UpdateStatus(string status)
        {
            ReorderOrderStatus = status;
            string query = "UPDATE ReorderOrder SET ReorderOrderStatus = '" + status + "' WHERE ReorderOrderID = '" + ReorderOrderID + "'";
            dbConnection.Update(query);
        }

        public void UpdateCompletedDate(string date)
        {
            reorderOrderCompletedDate = date;
            string query = "UPDATE ReorderOrder SET ReorderOrderCompletedDate = '" + date + "' WHERE ReorderOrderID = '" + ReorderOrderID + "'";
            dbConnection.Update(query);
        }

        public string ReorderOrderID
        {
            get => reorderOrderID;
            set => reorderOrderID = value;
        }

        public string StaffID
        {
            get => staffID;
            set => staffID = value;
        }

        public string ReorderOrderDate
        {
            get => reorderOrderDate;
            set => reorderOrderDate = value;
        }

        public string ReorderOrderEditDate
        {
            get => reorderOrderEditDate;
            set => reorderOrderEditDate = value;
        }

        public string ReorderOrderReceivedDate
        {
            get => reorderOrderReceivedDate;
            set => reorderOrderReceivedDate = value;
        }

        public string ReorderOrderCompletedDate
        {
            get => reorderOrderCompletedDate;
            set => reorderOrderCompletedDate = value;
        }

        public string ReorderOrderStatus
        {
            get => reorderOrderStatus;
            set => reorderOrderStatus = value;
        }

        public override string ToString()
        {
            return ReorderOrderID;
        }

        public DataTable getReorderOrderTableByReorderOrderStatus(string ReorderOrderStatus)
        {
            string query = "SELECT ReorderOrderID, StaffID," +
                "ReorderOrderDate,ReorderOrderEditDate, ReorderOrderCompletedDate, ReorderOrderStatus " +
                "FROM ReorderOrder WHERE  ReorderOrderStatus = \"" + ReorderOrderStatus + "\"";
            return dbConnection.GetDataTable(query);
        }

        public DataTable GoodsReceived_getReorderOrderByOrderID(string OrderID)
        {
            string query = "SELECT ReorderOrderID, StaffID," +
                "ReorderOrderDate,ReorderOrderEditDate, ReorderOrderCompletedDate, ReorderOrderStatus " +
                "FROM ReorderOrder WHERE ReorderOrderID = \"" + OrderID + "\" AND ReorderOrderStatus = \"Processing\"";
            return dbConnection.GetDataTable(query);
        }

        public DataTable GoodsReceived_getReorderOrderByStaffID(string StaffID)
        {
            string query = "SELECT ReorderOrderID, StaffID," +
                "ReorderOrderDate,ReorderOrderEditDate, ReorderOrderCompletedDate, ReorderOrderStatus " +
                "FROM ReorderOrder WHERE StaffID = \"" + StaffID + "\" AND ReorderOrderStatus = \"Processing\"";
            return dbConnection.GetDataTable(query);
        }

        public DataTable GoodsReceived_getReorderTableByWhereQuery(string condition)
        {
            string query = "SELECT ReorderOrderID, StaffID," +
                "ReorderOrderDate,ReorderOrderEditDate, ReorderOrderCompletedDate, ReorderOrderStatus " +
                "FROM ReorderOrder WHERE " + condition;
            return dbConnection.GetDataTable(query);
        }

        public void GoodsReceived_updataReorderOrderByRedoreOrderStatus(string reorderOrderID, string RedoreOrderStatus)
        {
            string query = "UPDATE ReorderOrder SET ReorderOrderStatus = \"" + RedoreOrderStatus + "\", ReorderOrderReceivedDate = \"" + DateTime.Now.ToString("yy-MM-dd") 
                + "\" WHERE ReorderOrder.ReorderOrderID = \"" + reorderOrderID + "\"";
            dbConnection.Update(query);
        }

        public void GoodsReceived_updataReorderOrderByQuery(string condition)
        {
            dbConnection.Update(condition);
        }
    }
}

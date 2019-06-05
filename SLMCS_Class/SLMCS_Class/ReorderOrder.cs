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
            ReorderOrderID = GetNextReorderOrderID();

            dbConnection = new DBConnection();
            string query = "SELECT * FROM ReorderOrder WHERE ReorderOrderID ='" + reorderOrderID + "'";

            reorderOrderTable = dbConnection.GetDataTable(query);
            DataRow[] rows = reorderOrderTable.Select();

            ReorderOrderID = (string)rows[0]["ReorderOrderID"];
            StaffID = (string)rows[0]["StaffID"];
            ReorderOrderDate = (string)rows[0]["ReorderOrderDate"];
            ReorderOrderEditDate = (string)rows[0]["ReorderOrderEditDate"];
            ReorderOrderReceivedDate = (string)rows[0]["ReorderOrderReceivedDate"];
            ReorderOrderCompletedDate = (string)rows[0]["ReorderOrderCompletedDate"];
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

        public DataTable GetReorderOrderTable(string condition)
        {
            string query = "SELECT ReorderOrderID,StaffID,ReorderOrderDate,ReorderOrderEditDate,ReorderOrderReceivedDate,ReorderOrderCompletedDate,ReorderOrderStatus FROM ReorderOrder ";
            if (condition != "")
            {
                
                query += condition;
            }
            reorderOrderTable = dbConnection.GetDataTable(query);
            return reorderOrderTable;
        }

        public DataTable GetInwardGoodsRecordTable(string condition)
        {
            string query = "SELECT ReorderOrderID,StaffID,ReorderOrderDate,ReorderOrderCompletedDate FROM ReorderOrder WHERE ReorderOrderStatus = 'Completed' ";
            if (condition != "")
            {
                query += condition;
            }
            MessageBox.Show(query);
            reorderOrderTable = dbConnection.GetDataTable(query);
            return reorderOrderTable;
        }
        public DataTable GetReorderOrderLineTable(string reorderOrderID)
        {
            string query = "SELECT * FROM ReorderOrderLine WHERE ReorderOrderID = '" + reorderOrderID + "'";
            reorderOrderTable = dbConnection.GetDataTable(query);
            return reorderOrderTable;
        }

        public string GetMultiChoiceQuery(string queryString)
        {
            var queryArray = queryString.Split('/'); // when have '/' in the string, split into array 
            queryArray = queryArray.Take(queryArray.Count() - 1).ToArray(); //drop the last element of array
            string restOfqueryArray = string.Join(" AND ", queryArray); //use 'AND' to recombine the array
            string finalQuery = " AND " + restOfqueryArray;// add 'WHERE' to become a complete sql query condition
            if (restOfqueryArray == "")
            {
                finalQuery = "";
            }

            return finalQuery;
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
    }
}

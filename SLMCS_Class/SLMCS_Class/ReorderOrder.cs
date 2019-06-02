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

        public void PlaceReorderOrder(Staff staff, string reorderOrderDate)
        {
            _staff = staff;
            string query = "INSERT INTO ReorderOrder VALUES ('" + ReorderOrderID + "','" + _staff.StaffID + 
                           "','" + reorderOrderDate + "',null,null,'Processing')";
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

        public string ReorderOrderID
        {
            get => reorderOrderID;
            set => reorderOrderID = value;
        }

        public override string ToString()
        {
            return ReorderOrderID;
        }
    }
}

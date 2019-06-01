using SLMCS_ERP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace SLMCS_Class
{
    public class ProcurementOrder
    {
        private DBConnection dbConnection;
        private DataTable procurementOrderTable;

        public ProcurementOrder()
        {
            dbConnection = new DBConnection();
        }

        public DataTable getProcurementOrderTableByProcurementOrderStatus(string ProcurementOrderStatus)
        {
            string query = "SELECT ProcurementOrderID, StaffID, VendorID, " +
                "ProcurementOrderDate,ProcurementOrderEditDate, ProcurementGoodReceiveDate, ProcurementOrderStatus " +
                "FROM ProcurementOrder WHERE  ProcurementOrderStatus = \"" + ProcurementOrderStatus + "\"";
            return dbConnection.GetDataTable(query);
        }

        public DataTable GoodsReceived_getProcurementOrderByOrderID(string OrderID)
        {
            string query = "SELECT ProcurementOrderID, StaffID, VendorID, " +
                "ProcurementOrderDate, ProcurementOrderEditDate, ProcurementGoodReceiveDate, ProcurementOrderStatus " +
                "FROM ProcurementOrder WHERE OrderID = \"" + OrderID + "\" AND ProcurementOrderStatus = \"Processing\"";
            return dbConnection.GetDataTable(query);
        }

        public DataTable GoodsReceived_getProcurementOrderByStaffID(string StaffID)
        {
            string query = "SELECT ProcurementOrderID, StaffID, VendorID, " +
                "ProcurementOrderDate, ProcurementOrderEditDate, ProcurementGoodReceiveDate, ProcurementOrderStatus " +
                "FROM ProcurementOrder WHERE StaffID = \"" + StaffID + "\" AND ProcurementOrderStatus = \"Processing\"";
            return dbConnection.GetDataTable(query);
        }

        public DataTable GoodsReceived_getProcurementOrderByVendorID(string VendorID)
        {
            string query = "SELECT ProcurementOrderID, StaffID, VendorID, " +
                "ProcurementOrderDate, ProcurementOrderEditDate, ProcurementGoodReceiveDate, ProcurementOrderStatus " +
                "FROM ProcurementOrder WHERE VendorID = \"" + VendorID + "\" AND ProcurementOrderStatus = \"Processing\"";
            return dbConnection.GetDataTable(query);
        }

        public DataTable getProcurementTableByWhereQuery(string condition)
        {
            string query = "SELECT ProcurementOrderID, StaffID, VendorID, " +
                "ProcurementOrderDate, ProcurementOrderEditDate, ProcurementGoodReceiveDate, ProcurementOrderStatus " +
                "FROM ProcurementOrder WHERE " + condition;
            return dbConnection.GetDataTable(query);
        }

    }
}
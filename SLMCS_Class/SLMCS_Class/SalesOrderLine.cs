using SLMCS_ERP;
using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SLMCS_Class
{
    public class SalesOrderLine
    {
        private string productID;
        private string salesOrderID;
        private SalesOrder _salesOrder;
        private Product product;
        private DataTable salesOrderLineTable;
        private int quantity;
        private double productPrice;

        private DBConnection dbConnection;

        public SalesOrderLine()
        {
            dbConnection = new DBConnection();
        }

        public SalesOrderLine(SalesOrder saleOrder, Product product, int quantity, double productPrice)
        {
            _salesOrder = saleOrder;
            this.product = product;
            this.quantity = quantity;
            this.productPrice = productPrice;
        }

        public SalesOrderLine(string orderID)
        {
            dbConnection = new DBConnection();
            string query = "SELECT SalesOrderID, ProductID, Quantity FROM SalesOrderLine WHERE SalesOrderID ='" + orderID + "'";
            salesOrderLineTable = dbConnection.GetDataTable(query);
            DataRow[] rows = salesOrderLineTable.Select();

            salesOrderID = (string)rows[0]["SalesOrderID"];
            productID = (string)rows[0]["ProductID"];
            Quantity = (int)rows[0]["Quantity"];
        }

        public double getSubtotalPrice()
        {
            return productPrice * quantity;
        }

        public string ProductID {
            get => productID;
            set => productID = value;
         }

        public string SalesOrderID
        {
            get => salesOrderID;
            set => salesOrderID = value;
        }
       

        public void placeSalesOrderLine()
        {
            dbConnection = new DBConnection();

            string query = "INSERT INTO SalesOrderLine VALUES ('" + _salesOrder.SalesOrderID + "','" + product.ProductID + "','" + quantity +
               "','" + productPrice + "')";
            //MessageBox.Show(query);
            dbConnection.Insert(query);
            product.updateReserveQuantity(quantity);
        }

        public string ProductName { get => product.ProductName; }

        public int Quantity {
            get => quantity;
            set => quantity = value;
        }

        public double ProductPrice { get => productPrice; }

        public double Subtotal { get => getSubtotalPrice(); }

    }
}
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
        private string productName;
        private string productUnit;
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
            this.productName = product.ProductName;
            this.productUnit = product.ProductUnit;
            this.productID = product.ProductID;
            this.salesOrderID = saleOrder.SalesOrderID;
            this.product = product;
            this.quantity = quantity;
            this.productPrice = productPrice;
        }

        //public SalesOrderLine(string orderID)
        //{
        //    dbConnection = new DBConnection();
        //    string query = "SELECT SalesOrderID, SalesOrderLine.ProductID, Quantity, ProductName, ProductUnit FROM SalesOrderLine, Product WHERE SalesOrderID ='" + orderID + "'";
        //    salesOrderLineTable = dbConnection.GetDataTable(query);
        //    DataRow[] rows = salesOrderLineTable.Select();

        //    salesOrderID = (string)rows[0]["SalesOrderID"];
        //    productID = (string)rows[0]["ProductID"];
        //    Quantity = (int)rows[0]["Quantity"];
        //    ProductName = (string)rows[0]["ProductName"];
        //    ProductUnit = (string)rows[0]["ProductUnit"];

        //}

        public SalesOrderLine(string orderID, string productID)
        {
            dbConnection = new DBConnection();
            string query = "SELECT SalesOrderLine.SalesOrderID, SalesOrderLine.ProductID, Product.ProductName, Product.ProductUnit, SalesOrderLine.Quantity FROM SalesOrderLine, Product WHERE SalesOrderLine.ProductID = Product.ProductID" +
                " AND SalesOrderLine.SalesOrderID ='" + orderID + "' AND SalesOrderLine.ProductID = '" + productID + "'";
            //MessageBox.Show(query);
            salesOrderLineTable = dbConnection.GetDataTable(query);
            DataRow[] rows = salesOrderLineTable.Select();

            SalesOrderID = (string)rows[0]["SalesOrderID"];
            ProductID = (string)rows[0]["ProductID"];
            Quantity = (int)rows[0]["Quantity"];
            ProductName = (string)rows[0]["ProductName"];
            ProductUnit = (string)rows[0]["ProductUnit"];
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

        public string ProductName
        {
            get => productName;
            set => productName = value;
        }

        public string ProductUnit
        {
            get => productUnit;
            set => productUnit = value;
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

        public int Quantity {
            get => quantity;
            set => quantity = value;
        }

        public double ProductPrice { get => productPrice; }

        public double Subtotal { get => getSubtotalPrice(); }

    }
}
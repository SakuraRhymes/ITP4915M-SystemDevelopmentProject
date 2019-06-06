using SLMCS_ERP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SLMCS_Class
{
    public class SalesOrderLine
    {
        private SalesOrder _salesOrder;
        private Product product;

        private int quantity;
        private double productPrice;

        private DBConnection dbConnection;

        public SalesOrderLine(SalesOrder saleOrder, Product product, int quantity, double productPrice)
        {
            _salesOrder = saleOrder;
            this.product = product;
            this.quantity = quantity;
            this.productPrice = productPrice;
        }

        public double getSubtotalPrice()
        {
            return productPrice * quantity;
        }

        public string ProductID {
            get => product.ProductID;
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

        public int Quantity { get => quantity; }

        public double ProductPrice { get => productPrice; }

        public double Subtotal { get => getSubtotalPrice(); }

    }
}
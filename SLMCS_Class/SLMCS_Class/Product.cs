using System;
using SLMCS_ERP;
using System.Data;
using System.Windows.Forms;

namespace SLMCS_Class
{
    public class Product
    {
        private string productID;
        private string productName;
        private string productDescription;
        private string productUnit;
        private int productPrice;
        private int productProcurementPrice;
        private string vendorID;
        private int actualQuantity;
        private int reserveQuantity;

        private DBConnection dbConnection;
        private DataTable saleableQuantityTable;

        public Product()
        {
            dbConnection = new DBConnection();
        }

        public Product(string productID)
        {
            dbConnection = new DBConnection();
            string query = "SELECT * FROM Product WHERE ProductID ='" + productID + "'";
            saleableQuantityTable = dbConnection.getDataTable(query);
            DataRow[] rows = saleableQuantityTable.Select();

            ProductID = (string)rows[0]["ProductID"];
            ProductName = (string)rows[0]["ProductName"];
            ProductDescription = (string)rows[0]["ProductDescription"];
            ProductUnit = (string)rows[0]["ProductUnit"];
            ProductPrice = (int)rows[0]["ProductPrice"];
            ProductProcurementPrice = (int)rows[0]["ProductProcurementPrice"];
            VendorID = (string)rows[0]["VendorID"];
            ActualQuantity = (int)rows[0]["ActualQuantity"];
            ReserveQuantity = (int)rows[0]["ReserveQuantity"];
        }

        public void CreateProduct(string productName, string productType, string productDescription, string productUnit,
            int productPrice, int productProcurementPrice, string vendorID)
        {
            string productID = GetNextProductID(productType);
            string query = "INSERT INTO Product VALUES (''" + productID + "','" + productName + "','" + productUnit +
                           "," + productPrice + "," + productProcurementPrice + ",'" + vendorID + "',0,0)";

            ProductName = productName;
            ProductDescription = productDescription;
            ProductUnit = productUnit;
            ProductPrice = productPrice;
            ProductProcurementPrice = productProcurementPrice;
            VendorID = vendorID;
        }

        //not testing
        public string GetNextProductID(string productType)
        {
            string query = "SELECT MAX(productID) FROM Product WHERE productID LIKE '" + productType + "%'";
            saleableQuantityTable = dbConnection.getDataTable(query);

            DataRow[] rows = saleableQuantityTable.Select();
            string productIDFull = (string)rows[0]["MAX(productID)"];
            string productIDNum = productIDFull.Substring(1);
            string nextProductID = productType + (Convert.ToInt32(productIDNum) + 1);
            return nextProductID;
        }

        public DataTable GetProdcutTable(string condition)
        {
            string query = "SELECT ProductID,ProductType,ProductName,ProductUnit FROM Product ";
            if (condition != "")
            {
                query += condition;
            }

            return dbConnection.getDataTable(query);
        }

        public DataTable SearchForProduct(string productID)
        {
            string query = "SELECT * FROM Product WHERE productID = '" + productID + "'";
            return dbConnection.getDataTable(query);
        }

        public void updateReserveQuantity(int reserveQuantity)
        {
            string query = "UPDATE Product SET ReserveQuantity = ReserveQuantity + " + reserveQuantity + " WHERE ProductID = " + productID;
            dbConnection.update(query);
        }

        public int getSaleableQuantity(string productID)
        {
            string query = "SELECT * FROM ProductSaleableQuantity WHERE productID = '" + productID + "'";
            MessageBox.Show(query);
            saleableQuantityTable = dbConnection.getDataTable(query);
            DataRow[] rows = saleableQuantityTable.Select();

            return Convert.ToInt32(rows[0]["ProductSaleableQuantity"]);
        }

        //get set method
        public string ProductID
        {
            get => productID;
            set => productID = value;
        }

        public string ProductName
        {
            get => productName;
            set => productName = value;
        }

        public string ProductDescription
        {
            get => productDescription;
            set => productDescription = value;
        }

        public string ProductUnit
        {
            get => productUnit;
            set => productUnit = value;
        }

        public int ProductPrice
        {
            get => productPrice;
            set => productPrice = value;
        }

        public int ProductProcurementPrice
        {
            get => productProcurementPrice;
            set => productProcurementPrice = value;
        }

        public string VendorID
        {
            get => vendorID;
            set => vendorID = value;
        }

        public int ActualQuantity
        {
            get => actualQuantity;
            set => actualQuantity = value;
        }

        public int ReserveQuantity
        {
            get => reserveQuantity;
            set => reserveQuantity = value;
        }
    }
}
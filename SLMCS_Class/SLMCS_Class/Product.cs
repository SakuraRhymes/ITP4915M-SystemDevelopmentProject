using System;
using SLMCS_ERP;
using System.Data;

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
        private DataTable productTable;

        public Product()
        {
            dbConnection = new DBConnection();
        }
        public Product(string productID)
        {
            string query = "SELECT * FROM Product WHERE ProductID ='" + productID + "'";
            productTable = dbConnection.getDataTable(query);
            DataRow[] rows = productTable.Select();

            this.productID = (string)rows[0]["ProductID"];
            this.productName = (string)rows[0]["ProductName"];
            this.productDescription = (string)rows[0]["ProductDescription"];
            this.productUnit = (string)rows[0]["ProductUnit"];
            this.productPrice = (int)rows[0]["ProductPrice"];
            this.productProcurementPrice = (int)rows[0]["ProductProcurementPrice"];
            this.vendorID = (string)rows[0]["VendorID"];
            this.actualQuantity = (int)rows[0]["ActualQuantity"];
            this.reserveQuantity = (int)rows[0]["ReserveQuantity"];
        }

        public void CreateProduct(string productName, string productType, string productDescription, string productUnit, int productPrice, int productProcurementPrice, string vendorID)
        {
            string productID = GetNextProductID(productType);
            string query = "INSERT INTO Product VALUES (''" + productID + "','" + productName + "','" + productUnit + "," + productPrice + "," + productProcurementPrice + ",'" + vendorID + "',0,0)";
            
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
            string query = "SELECT MAX(productID) FROM Product WHERE productID LIKE '" + productType +"%'";
            productTable = dbConnection.getDataTable(query);
            
            DataRow[] rows = productTable.Select();
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

        //get set method
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductUnit { get; set; }
        public int ProductPrice { get; set; }
        public int ProductProcurementPrice { get; set; }
        public string VendorID { get; set; }
        public int ActualVolume { get; set; }
    }
}
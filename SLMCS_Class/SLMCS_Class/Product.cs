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
        private int actualVolume;
        
        private DBConnection dbConnection;
        private DataTable productTable;

        public Product()
        {
            dbConnection = new DBConnection();
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
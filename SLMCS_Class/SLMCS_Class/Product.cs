using System;
using SLMCS_ERP;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SLMCS_Class
{
    public class Product
    {
        private string productID;
        private string productName;
        private string productType;
        private string productDescription;
        private string productUnit;
        private int productPrice;
        private int productProcurementPrice;
        private string vendorID;
        private int actualQuantity;
        private int reserveQuantity;
        private int reorderLevel;
        private int dangerLevel;

        private DBConnection dbConnection;
        private DataTable productTable;

        public Product()
        {
            dbConnection = new DBConnection();
        }

        public Product(string productID)
        {
            dbConnection = new DBConnection();
            string query = "SELECT * FROM Product WHERE ProductID ='" + productID + "'";

            productTable = dbConnection.GetDataTable(query);
            DataRow[] rows = productTable.Select();

            ProductID = (string) rows[0]["ProductID"];
            ProductName = (string) rows[0]["ProductName"];
            ProductType = (string) rows[0]["ProductType"];
            ProductDescription = (string) rows[0]["ProductDescription"];
            ProductUnit = (string) rows[0]["ProductUnit"];
            ProductPrice = (int) rows[0]["ProductPrice"];
            //ProductProcurementPrice = (int) rows[0]["ProductProcurementPrice"];
            VendorID = (string) rows[0]["VendorID"];
            ActualQuantity = (int) rows[0]["ActualQuantity"];
            ReserveQuantity = (int) rows[0]["ReserveQuantity"];
            ReorderLevel = (int)rows[0]["ReorderLevel"];
            DangerLevel = (int)rows[0]["DangerLevel"];
        }

        public void CreateNewProduct(string productName, string productType, string productDescription, string productUnit,
            string productPrice, string vendorID)
        {
            string productID = GetNextProductID(productType);
            string query = "INSERT INTO Product VALUES ('" + productID + "','" + productName + "','" + productType +"','" + productDescription 
                            + "','" + productUnit + "'," + productPrice + "," + "NULL" + ",'" + vendorID + "',0,0,0)";
            try
            {
                dbConnection.Insert(query);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public string GetNextProductID(string productType)
        {
            string productTypeChar = "";
            switch(productType)
            {
                case "Sheet Metal":
                    productTypeChar = "A";
                    break;
                case "Major Assemblies":
                    productTypeChar = "B";
                    break;
                case "Light Components":
                    productTypeChar = "C";
                    break;
                case "Accessories":
                    productTypeChar = "D";
                    break;
            }
            string query = "SELECT MAX(productID) FROM Product WHERE productID LIKE '" + productTypeChar + "%'";
            productTable = dbConnection.GetDataTable(query);

            DataRow[] rows = productTable.Select();
            string productIDFull = (string) rows[0]["MAX(productID)"];
     
            string productIDNum = productIDFull.Substring(1);
            string fillZore = "";
            string nextProductID = (Convert.ToInt32(productIDNum) + 1).ToString();
            for (int i=nextProductID.Length; i<5; i++)
            {
                fillZore += "0";
            }
            return productTypeChar + fillZore + nextProductID;
        }

        public DataTable GetProdcutTable(string condition)
        {
            string query = "SELECT ProductID,ProductType,ProductName,ProductUnit,ProductPrice,ActualQuantity,ReorderLevel,DangerLevel FROM Product ";
            if (condition != "")
            {
                query += condition;
            }

            return dbConnection.GetDataTable(query);
        }

        public DataTable SearchForProduct(string productID)
        {
            string query = "SELECT * FROM Product WHERE productID = '" + productID + "'";
            return dbConnection.GetDataTable(query);
        }

        public void updateReserveQuantity(int reserveQuantity)
        {
            string query = "UPDATE Product SET ReserveQuantity = ReserveQuantity + " + reserveQuantity + " WHERE ProductID = " + productID;
            dbConnection.Update(query);
        }

        public int getSaleableQuantity(string productID)
        {
            string query = "SELECT * FROM ProductSaleableQuantity WHERE productID = '" + productID + "'";
            MessageBox.Show(query);
            productTable = dbConnection.GetDataTable(query);
            DataRow[] rows = productTable.Select();

            return Convert.ToInt32(rows[0]["ProductSaleableQuantity"]);
        }

        public void UpdateProductDetail(string productID, string productType, string productName, string productDesc, string productUnit, string productPrice, string actualQuantity, string reorderLevel, string dangerLevel)
        {
            string queryString = "UPDATE Product SET ProductType='{0}', ProductName='{1}', ProductDescription='{2}' ,ProductUnit='{3}', ProductPrice={4}, ActualQuantity={5}, ReorderLevel={6}, DangerLevel={7} WHERE ProductID='{8}'";

            string query = string.Format(queryString, productType, productName, productDesc, productUnit, productPrice, actualQuantity, reorderLevel, dangerLevel, productID);
            //MessageBox.Show(q);
            dbConnection.Update(query);
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

        public string ProductType
        {
            get => productType;
            set => productType = value;
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

        public int ReorderLevel
        {
            get => reorderLevel;
            set => reorderLevel = value;
        }

        public int DangerLevel
        {
            get => dangerLevel;
            set => dangerLevel = value;
        }
    }
}
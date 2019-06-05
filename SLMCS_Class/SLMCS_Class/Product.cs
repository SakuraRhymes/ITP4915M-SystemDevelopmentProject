using System;
using SLMCS_ERP;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Linq;

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
        private string productStatus;

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
            ProductStatus = (string)rows[0]["ProductStatus"];
        }

        public void CreateNewProduct(string productName, string productType, string productDescription, string productUnit,
            string productPrice, string vendorID)
        {
            string productID = GetNextProductID(productType);
            string queryString = "INSERT INTO Product VALUES ('{0}','{1}','{2}','{3}','{4}',{5},NULL,'{6}',0,0,0,0)";
            string query = string.Format(queryString, productID, productName, productType, productDescription, productUnit, productPrice, vendorID);
            //string query = "INSERT INTO Product VALUES ('" + productID + "','" + productName + "','" + productType +"','" + productDescription 
            //                + "','" + productUnit + "'," + productPrice + "," + "NULL" + ",'" + vendorID + "',0,0,0,0)";
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
            string query = "SELECT * FROM Product";
            if (condition != "")
            {
                query += condition;
            }

            return dbConnection.GetDataTable(query);
        }

        public DataTable GetProdcutRecordTable(string condition)
        {
            string query = "SELECT ProductID,ProductName,ProductType,ProductUnit,ActualQuantity,VendorID FROM Product";
            if (condition != "")
            {
                query += " WHERE " + condition;
            }

            return dbConnection.GetDataTable(query);
        }

        public DataTable GetProdcutReorderLevelTable()
        {
            string query = "SELECT ProductID,ProductName,ProductType,ProductUnit,VendorID,ActualQuantity FROM ReorderLevelProduct";
            DataTable dataTable = dbConnection.GetDataTable(query);
            return dataTable;
        }

        public DataTable GetProdcutDangerLevelTable()
        {
            string query = "SELECT ProductID,ProductName,ProductType,ProductUnit,VendorID,ActualQuantity,DangerLevel FROM DangerLevelProduct";
            DataTable dataTable = dbConnection.GetDataTable(query);
            return dataTable;
        }

        public DataTable SearchForProduct(string productID)
        {
            string query = "SELECT * FROM Product WHERE productID = '" + productID + "'";
            return dbConnection.GetDataTable(query);
        }

        public void updateReserveQuantity(int reserveQuantity)
        {
            string query = "UPDATE Product SET ReserveQuantity = ReserveQuantity + " + reserveQuantity + " WHERE ProductID = '" + productID+"'";
            //MessageBox.Show(query);
            dbConnection.Update(query);
        }

        public void updateActualQuantity(int actualQuantity)
        {
            string query = "UPDATE Product SET ActualQuantity = ActualQuantity + " + actualQuantity + " WHERE ProductID = '" + productID + "'";
            //MessageBox.Show(query);
            dbConnection.Update(query);
        }

        public void UpdateReorderLevelQuantity(string reorderLevelQty)
        {
            string query = "UPDATE Product SET ReorderLevel = " + reorderLevelQty + " WHERE ProductID = '" + productID +"'";
            dbConnection.Update(query);
        }

        public void UpdateDangerLevelQuantity(string dangerLevelQty)
        {
            string query = "UPDATE Product SET DangerLevel = " + dangerLevelQty + " WHERE ProductID = '" + productID + "'";
            dbConnection.Update(query);
        }

        public int getSaleableQuantity(string productID)
        {
            string query = "SELECT * FROM ProductSaleableQuantity WHERE productID = '" + productID + "'";
            //MessageBox.Show(query);
            productTable = dbConnection.GetDataTable(query);
            DataRow[] rows = productTable.Select();

            return Convert.ToInt32(rows[0]["SaleableQuantity"]);
        }

        public void UpdateProductDetail(string productID, string productType, string productName, string productDesc, string productUnit, string productPrice, string actualQuantity, string reorderLevel, string dangerLevel)
        {
            string queryString = "UPDATE Product SET ProductType='{0}', ProductName='{1}', ProductDescription='{2}' ,ProductUnit='{3}', ProductPrice={4}, ActualQuantity={5}, ReorderLevel={6}, DangerLevel={7} WHERE ProductID='{8}'";

            string query = string.Format(queryString, productType, productName, productDesc, productUnit, productPrice, actualQuantity, reorderLevel, dangerLevel, productID);
            //MessageBox.Show(q);
            dbConnection.Update(query);
        }

        public void DeleteProduct(string productID)
        {
            string query = string.Format("DELETE FROM Product WHERE ProductID = '{0}';", productID);
            dbConnection.Delete(query);
        }

        //public string GetMultiChoiceQuery(string queryString)
        //{
        //    var queryArray = queryString.Split('/'); // when have '/' in the string, split into array 
        //    queryArray = queryArray.Take(queryArray.Count() - 1).ToArray(); //drop the last element of array
        //    string restOfqueryArray = string.Join(" AND ", queryArray); //use 'AND' to recombine the array
        //    string finalQuery = "WHERE " + restOfqueryArray;// add 'WHERE' to become a complete sql query condition
        //    if (restOfqueryArray == "")
        //    {
        //        finalQuery = "";
        //    }

        //    return finalQuery;
        //}

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

        public string ProductStatus
        {
            get => productStatus;
            set => productStatus = value;
        }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
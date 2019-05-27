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
            
        }

        public void CreateProduct(string productName, string productDescription, string productUnit, int productPrice, int productProcurementPrice, string vendorID)
        {
            dbConnection = new DBConnection();
            

            string query = "INSERT INTO Product VALUE ";
            
            ProductName = productName;
            ProductDescription = productDescription;
            ProductUnit = productUnit;
            ProductPrice = productPrice;
            ProductProcurementPrice = productProcurementPrice;
            VendorID = vendorID;
        }
        
        public string GetNextProductID()
        {
            return "";
        }
        
        
        
        //get set method
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

        public int ActualVolume
        {
            get => actualVolume;
            set => actualVolume = value;
        }
    }
}
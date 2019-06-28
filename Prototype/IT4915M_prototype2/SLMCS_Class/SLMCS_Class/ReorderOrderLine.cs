using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SLMCS_ERP;
using System.Windows.Forms;

namespace SLMCS_Class
{
    public class ReorderOrderLine
    {
        private ReorderOrder reorderOrder;
        private Product product;
        private int quantity;

        private DBConnection dbConnection;
        

        public ReorderOrderLine(ReorderOrder reorderOrder, Product product, int quantity)
        {
            this.reorderOrder = reorderOrder;
            this.product = product;
            Quantity = quantity;
        }

        public void PlaceReorderOrderLine()
        {
            dbConnection = new DBConnection();
            string query = "INSERT INTO ReorderOrderLine VALUES ('" + reorderOrder.ReorderOrderID + "','" + product.ProductID + "'," + Quantity + ")";
            //MessageBox.Show(query);
            dbConnection.Insert(query);
        }

        public string ProductID
        {
            get => product.ProductID;
        } 

        public string ProductName
        {
            get => product.ProductName;
        }

        public string ProductType
        {
            get => product.ProductType;
        }

        public string ProductUnit
        {
            get => product.ProductUnit;
        }

        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }


        //public ReorderOrder ReorderOrder
        //{
        //    get => reorderOrder;
        //    set => reorderOrder = value;
        //}

        //public Product Product
        //{
        //    get => product;
        //    set => product = value;
        //}
    }
}

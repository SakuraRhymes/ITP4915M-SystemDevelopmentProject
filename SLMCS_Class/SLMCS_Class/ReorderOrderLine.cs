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
            ReorderOrder = reorderOrder;
            Product = product;
            Quantity = quantity;
        }

        public void PlaceReorderOrderLine()
        {
            dbConnection = new DBConnection();
            string query = "INSERT INTO ReorderOrderLine VALUES ('" + ReorderOrder.ReorderOrderID + "','" + Product.ProductID + "'," + Quantity + ")";
            //MessageBox.Show(query);
            dbConnection.Insert(query);
        }
        

//        public void CreateReorderOrderLine(ReorderOrder reorderOrder, Product product, int quantity)
//        {
//            ReorderOrderLine orderDetail = new ReorderOrderLine(reorderOrder, product, quantity);
//
//        }

        public ReorderOrder ReorderOrder
        {
            get => reorderOrder;
            set => reorderOrder = value;
        }

        public Product Product
        {
            get => product;
            set => product = value;
        }

        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }
    }
}

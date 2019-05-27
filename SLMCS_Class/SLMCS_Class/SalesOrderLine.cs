namespace SLMCS_Class
{
    public class SalesOrderLine
    {
        private SalesOrder _salesOrder;

        private string productID;
        private int quantity;
        private double productPrice;

        public string ProductID { get; set; }

        public int Quantity { get; set; }

        public double ProductPrice { get; set; }


        public double getSubtotalPrice()
        {
            return productPrice * quantity;
        }
    }
}
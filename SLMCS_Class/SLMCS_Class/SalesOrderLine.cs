namespace SLMCS_Class
{
    public class SalesOrderLine
    {
        private SalesOrder _salesOrder;

        private string productID;
        private int quantity;
        private double productPrice;

        public string ProductID { get; set; }

        public double getSubtotalPrice()
        {
            return productPrice * quantity;
        }
    }
}
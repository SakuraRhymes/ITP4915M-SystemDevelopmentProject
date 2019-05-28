namespace SLMCS_Class
{
    public class SalesOrderLine
    {
        private SalesOrder _salesOrder;
        private Product product;

        private int quantity;
        private double productPrice;

        public int Quantity { get; set; }

        public double ProductPrice { get; set; }

        public SalesOrderLine(SalesOrder saleOrder, Product product, int quantity, double productPrice)
        {
            _salesOrder = saleOrder;
            this.product = product;
            this.quantity = quantity;
            this.productPrice = productPrice;
        }

        public double getSubtotalPrice()
        {
            return productPrice * quantity;
        }
    }
}
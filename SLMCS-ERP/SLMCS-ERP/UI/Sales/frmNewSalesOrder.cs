using SLMCS_Class;
using System;
using System.Data;
using System.Windows.Forms;

namespace SLMCS_ERP.UI.Sales
{
    public partial class frmNewSalesOrder : Form
    {
        private SalesOrder salesOrder;

        public frmNewSalesOrder()
        {
            InitializeComponent();
            salesOrder = new SalesOrder();
            dgvOrderItem.DataSource = salesOrder._SalesOrderLine;
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            string productID = txtSearchForProduct.Text;
            int quantity = Convert.ToInt32(txtOrderQunatity.Text);
            Product product = new Product(productID);

            salesOrder.addProduct(product, quantity);
            
            dgvOrderItem.DataSource = null;
            dgvOrderItem.DataSource = salesOrder._SalesOrderLine;

            //salesOrder.GetNextSalesOrderID();
            //dgvOrderItem.DataSource = product.SearchForProduct(productID);

        }
    }
}

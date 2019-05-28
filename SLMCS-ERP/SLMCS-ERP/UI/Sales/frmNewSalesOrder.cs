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
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            string productID = txtSearchForProduct.Text;
            Product product = new Product();

            DataTable productTable = product.SearchForProduct(productID);


            //salesOrder.GetNextSalesOrderID();
            //dgvOrderItem.DataSource = product.SearchForProduct(productID);


        }
    }
}

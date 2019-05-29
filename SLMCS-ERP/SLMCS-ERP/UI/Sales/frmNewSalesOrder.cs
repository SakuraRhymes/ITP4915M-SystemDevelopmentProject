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

            lblOrderID.Text = salesOrder.SalesOrderID;
            lblOrderDate.Text = salesOrder.SalesOrderDate;
            lblStaffID.Text = salesOrder.StaffID;

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

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            salesOrder.placeOrder();
        }

        private void TxtDealerID_TextChanged(object sender, EventArgs e)
        {
            if (txtDealerID.Text.Length == 8)
            {
                lblDealerName.Text = salesOrder.DealerName;
                lblDealerAddress.Text = salesOrder.DealerAddress;
            }
            else
            {
                lblDealerName.Text = "Not available";
                lblDealerAddress.Text = "Not available";
            }
                
        }

        private void TxtSearchForProduct_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchForProduct.Text.Length == 6)
            {
                lblProductName.Text = "Car Light 001";
                lblProductAvailability.Text = "998";
            }
            else
            {
                lblProductName.Text = "Not available";
                lblProductAvailability.Text = "Not available";
            }
        }
    }
}

using SLMCS_Class;
using System;
using System.Data;
using System.Windows.Forms;

namespace SLMCS_ERP.UI.Sales
{
    public partial class frmNewSalesOrder : Form
    {
        private SalesOrder salesOrder;

        private string notAvailableMessage;

        public frmNewSalesOrder()
        {
            InitializeComponent();
            startUp();
        }

        private void startUp()
        {
            salesOrder = new SalesOrder();
            notAvailableMessage = "Not available";

            txtDealerID.Focus();

            lblOrderID.Text = salesOrder.SalesOrderID;
            lblOrderDate.Text = salesOrder.SalesOrderDate;
            lblStaffID.Text = salesOrder.StaffID;

            txtDealerID.Text = "";
            txtOrderQunatity.Text = "";
            txtSearchForProduct.Text = "";

            dgvOrderItem.DataSource = null;
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

            txtSearchForProduct.Text = "";
            txtOrderQunatity.Text = "";
        }

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            salesOrder.placeOrder();
            startUp();
        }

        private void TxtDealerID_TextChanged(object sender, EventArgs e)
        {
            if (txtDealerID.Text.Length == 8)
            {
                String[] reslut = salesOrder.updataDealerInfo(txtDealerID.Text);
                if(reslut != null)
                {
                    lblDealerName.Text = reslut[0];
                    lblDealerAddress.Text = reslut[1];
                }
             
            }
            else
            {
                lblDealerName.Text = lblDealerAddress.Text = notAvailableMessage;
            }
                
        }

        private void TxtSearchForProduct_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchForProduct.Text.Length == 6)
            {
                String[] reslut = salesOrder.updataProductInfo(txtSearchForProduct.Text);
                if (reslut != null)
                {
                    lblProductName.Text = reslut[0];
                    lblProductAvailability.Text = reslut[1];
                }
            }
            else
            {
                lblProductName.Text = lblProductAvailability.Text = notAvailableMessage;
            }
        }

        private void BtnCancelPlaceOrder_Click(object sender, EventArgs e)
        {
            startUp();
        }
    }
}

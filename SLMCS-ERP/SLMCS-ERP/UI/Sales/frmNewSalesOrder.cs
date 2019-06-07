using SLMCS_Class;
using System;
using System.Data;
using System.Windows.Forms;

namespace SLMCS_ERP.UI.Sales
{
    public partial class frmNewSalesOrder : Form
    {
        private SalesOrder salesOrder;
        public frmBrowseProduct browseProductPage;
        private string notAvailableMessage;

        public frmNewSalesOrder()
        {
            InitializeComponent();
            startUp();
        }

        private void startUp()
        {
            salesOrder = new SalesOrder();
            salesOrder.StaffID = frmMain.CurrentStaff.StaffID;
            notAvailableMessage = "Not available";

            txtDealerID.Focus();

            lblOrderID.Text = salesOrder.SalesOrderID;
            lblOrderDate.Text = salesOrder.SalesOrderDate;
            lblStaffID.Text = salesOrder.StaffID;

            txtDealerID.Text = "";
            lblTotalAmount.Text = "0";
            btnAddItem.Enabled = false;
            btnPlaceOrder.Enabled = false;
            btnReserveOrder.Enabled = false;
            dgvOrderItem.Enabled = false;

            dgvOrderItem.AllowUserToAddRows = false;
            dgvOrderItem.RowHeadersVisible = false;
            dgvOrderItem.ReadOnly = true;
            dgvOrderItem.AllowUserToResizeRows = false;
            dgvOrderItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            updateDGV();
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            browseProductPage = new frmBrowseProduct(this, salesOrder);
            browseProductPage.Show();
        }

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (txtDealerID.Text == "")
            {
                MessageBox.Show("Please Enter Dealer ID!");
            }
            else
            {
                if (MessageBox.Show("Confirm Order?", "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    salesOrder.placeOrder("Processing");
                    startUp();
                    MessageBox.Show("Place Order Successfully");
                }
            }
        }

        private void BtnReserveOrder_Click(object sender, EventArgs e)
        {
            if (txtDealerID.Text == "")
            {
                MessageBox.Show("Please Enter Dealer ID!");
            }
            else
            {
                if (MessageBox.Show("Confirm Reserve Order?", "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    salesOrder.placeOrder("Reserved");
                    startUp();
                    MessageBox.Show("Place Reserve Order Successfully");
                }
            }
        }

        private void TxtDealerID_TextChanged(object sender, EventArgs e)
        {
            if (txtDealerID.Text.Length == 8)
            {
                String[] reslut = salesOrder.updataDealerInfo((txtDealerID.Text).ToUpper());
                if (reslut != null)
                {
                    lblDealerName.Text = reslut[0];
                    lblDealerAddress.Text = reslut[1];
                    btnAddItem.Enabled = true;
                }
                if (dgvOrderItem.Rows.Count > 0)
                {
                    btnPlaceOrder.Enabled = true;
                }
            }
            else
            {
                lblDealerName.Text = lblDealerAddress.Text = notAvailableMessage;
                btnAddItem.Enabled = false;
                btnPlaceOrder.Enabled = false;
            }
        }

        private void BtnCancelPlaceOrder_Click(object sender, EventArgs e)
        {
            startUp();
        }

        private void updateDGV()
        {
            dgvOrderItem.DataSource = null;
            dgvOrderItem.DataSource = salesOrder._SalesOrderLine;

            dgvOrderItem.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvOrderItem.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvOrderItem.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvOrderItem.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvOrderItem.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void updateAddedOrderLine()
        {
            updateDGV();

            lblTotalAmount.Text = salesOrder.getTotalPrice().ToString();

            btnPlaceOrder.Enabled = true;
            btnReserveOrder.Enabled = true;
        }
    }
}

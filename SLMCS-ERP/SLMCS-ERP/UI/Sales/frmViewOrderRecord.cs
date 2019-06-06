using SLMCS_Class;
using SLMCS_ERP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLMCS_ERP.UI.Sales
{
    public partial class frmViewOrderRecord : Form
    {
        private SalesOrder salesOrder;
        public frmViewOrderRecord(string selectedSalesOrderID)
        {
            InitializeComponent();
            salesOrder = new SalesOrder(selectedSalesOrderID);
            startup();
        }

        private void startup()
        {
            lblDealerID.Text = salesOrder.DealerID;

            Dealer dealer = new Dealer();
            DataTable dt = dealer.SearchForDealer(salesOrder.DealerID);

            DataRow[] rows = dt.Select();
            lblDealerName.Text = (string)rows[0]["DealerName"];
            lblDealerAddress.Text = (string)rows[0]["DealerShippingAddress"];

            lblStaffID.Text = salesOrder.StaffID;

            lblOrderID.Text = salesOrder.SalesOrderID;
            lblOrderStatus.Text = salesOrder.SalesOrderStatus;
            lblTotalAmount.Text = salesOrder.getTotalPriceFromDB();

            lblOrderDate.Text = salesOrder.SalesOrderDate;
            lblOrderEditDate.Text = salesOrder.SalesOrderEditDate;
            lblOrderDispatchDate.Text = salesOrder.SalesDispatchDate;
            lblOrderCompletedDate.Text = salesOrder.SalesOrderCompletedDate;

            dgvOrderItem.AllowUserToResizeRows = false;

            if (lblOrderDispatchDate.Text == "")
            {
                lblOrderDispatchDate.Text = "Not available";
            }
            if (lblOrderCompletedDate.Text == "")
            {
                lblOrderCompletedDate.Text = "Not available";
            }

            updateDGV();

            if(salesOrder.SalesOrderStatus == "Reserved")
            {
                btnConfirmPlaceOrder.Enabled = true;
            }
            if(salesOrder.SalesOrderStatus == "Reserved" || salesOrder.SalesOrderStatus == "Processing")
            {
                btnCancelOrder.Enabled = true;
            }
            if(salesOrder.SalesOrderStatus != "Completed" && salesOrder.SalesOrderStatus != "Canceled" && salesOrder.SalesOrderStatus != "Reserved")
            {
                btnCompleteOrder.Enabled = true;
            }
        }

        private void updateDGV()
        {          
            dgvOrderItem.DataSource = null;
            dgvOrderItem.DataSource = salesOrder.searchOrderLine();
            dgvOrderItem.AllowUserToAddRows = false;
            dgvOrderItem.RowHeadersVisible = false;
            dgvOrderItem.ReadOnly = true;

            dgvOrderItem.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvOrderItem.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvOrderItem.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BtnConfirmPlaceOrder_Click(object sender, EventArgs e)
        {
            salesOrder.updateStatus("Processing");
            lblOrderStatus.Text = salesOrder.SalesOrderStatus; 
            btnConfirmPlaceOrder.Enabled = false;
            MessageBox.Show("Successfully Placed Sales Order");
        }

        private void BtnCancelOrder_Click(object sender, EventArgs e)
        {
            salesOrder.updateStatus("Canceled");
            lblOrderStatus.Text = salesOrder.SalesOrderStatus;
            btnCancelOrder.Enabled = false;
            btnCompleteOrder.Enabled = false;
            salesOrder.cancelOrder();
            MessageBox.Show("Successfully Canceled Sales Order");
        }

        private void BtnCompleteOrder_Click(object sender, EventArgs e)
        {
            salesOrder.updateStatus("Completed");
            lblOrderStatus.Text = salesOrder.SalesOrderStatus;
            btnCompleteOrder.Enabled = false;
            btnCancelOrder.Enabled = false;
            MessageBox.Show("Successfully Completed Sales Order");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

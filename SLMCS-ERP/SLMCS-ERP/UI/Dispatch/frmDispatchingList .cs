using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLMCS_Class;
using SLMCS_ERP.UI.Dispatch;
using SLMCS_ERP.UI.Sales;


namespace SLMCS_ERP{
    public partial class frmDispatchingList : Form
    {
        private string selectedOrderID;
        private string selectedOrderLineProductID;

        private string generateForDID;
        private string orderIDForGenerate;
        private SalesOrder salesOrder;

        public frmDispatchingList()
        {
            salesOrder = new SalesOrder();
            selectedOrderID = "";
            selectedOrderLineProductID = "";
            InitializeComponent();
            startUp();
        }

        private void startUp()
        {
            dgvOrderDetail.DataSource = null;
            changeDispatchingDvgContect(salesOrder.getSalesOrderTableBySalesOrderStatus("Processing"));
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string condition = "";
            int andCount = 0;
            if (txtOrderID.Text != "")
            {
                condition += "SalesOrderID LIKE '%"+ txtOrderID.Text+"%'";
                andCount++;
            }
            if (txtStaffID.Text != "")
            {
                if (andCount > 0)
                {
                    condition += " AND ";
                    andCount--;
                }
                condition += "StaffID LIKE '%" + txtStaffID.Text + "%'";
                andCount++;
            }     
            if (txtDealerID.Text != "")
            {
                if (andCount > 0)
                {
                    condition += " AND ";
                    andCount--;
                }
                condition += "DealerID LIKE '%" + txtDealerID.Text + "%'";
                andCount++;
            }
            if (dtpOrderDateFrom.Text != " " && dtpOrderDateTo.Text != " ")
            {
                if (andCount > 0)
                {
                    condition += " AND ";
                    andCount--;
                }
                condition += "SalesOrderDate BETWEEN '" + dtpOrderDateFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpOrderDateTo.Value.ToString("yyyy-MM-dd") + "'";
                andCount++;
            }
            if (andCount > 0)
            {
                condition += " AND ";
                andCount--;
            }
            condition += "SalesOrderStatus = 'Processing'";
            changeDispatchingDvgContect(salesOrder.getSalesTableByWhereQuery(condition));
        }

        private void FrmDispatchingList_Load(object sender, EventArgs e)
        {
            dgvSalesOrderList.AllowUserToAddRows = false;
            dgvSalesOrderList.RowHeadersVisible = false;
            dgvSalesOrderList.ReadOnly = true;
            dgvSalesOrderList.AllowUserToResizeRows = false;
            dgvSalesOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvOrderDetail.AllowUserToAddRows = false;
            dgvOrderDetail.RowHeadersVisible = false;
            dgvOrderDetail.ReadOnly = true;
            dgvOrderDetail.AllowUserToResizeRows = false;
            dgvOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dtpOrderDateFrom.Text = "";
            dtpOrderDateFrom.Format = DateTimePickerFormat.Custom;
            dtpOrderDateFrom.CustomFormat = " ";
            dtpOrderDateTo.Text = "";
            dtpOrderDateTo.Format = DateTimePickerFormat.Custom;
            dtpOrderDateTo.CustomFormat = " ";

            selectedOrderID = "";
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            refreshDvg();
        }

        private void changeDispatchingDvgContect(DataTable table)
        {
            dgvOrderDetail.DataSource = null;
            dgvSalesOrderList.DataSource = null;
            dgvSalesOrderList.DataSource = table;
        }

        private void refreshDvg()
        {
            changeDispatchingDvgContect(salesOrder.getSalesOrderTableBySalesOrderStatus("Processing"));
            dtpOrderDateFrom.Text = "";
            dtpOrderDateFrom.Format = DateTimePickerFormat.Custom;
            dtpOrderDateFrom.CustomFormat = " ";
            dtpOrderDateTo.Text = "";
            dtpOrderDateTo.Format = DateTimePickerFormat.Custom;
            dtpOrderDateTo.CustomFormat = " ";

            selectedOrderID = "";
            selectedOrderLineProductID = "";
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {
            changeDispatchingDvgContect(salesOrder.getSalesOrderTableBySalesOrderStatus("Processing"));
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (dgvSalesOrderList.Rows.Count > 0 && selectedOrderID != "")
            {
                if (MessageBox.Show("Confirm Order ID: " + selectedOrderID + " Order?", "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    salesOrder.updataSalesOrderStatusInDB(selectedOrderID, "Dispatched");

                    salesOrder.dispatchOrder(selectedOrderID);

                    string successfulMessage = "Sales Order :" + selectedOrderID + " has been Dispatched!";
                    MessageBox.Show(successfulMessage);
                    //refreshDvg();
                }
            }
            else
            {
                MessageBox.Show("Please Select an Order!");
            }
        }

        private void BtnGenerateForDID_Click(object sender, EventArgs e)
        {
            if (selectedOrderLineProductID != "")
            {
                frmGenerateDID generateDID = new frmGenerateDID(selectedOrderID, selectedOrderLineProductID);
                generateDID.Show();
            }
            else
            {
                MessageBox.Show("Please Select a Product at Order Line!");
            }
        }

        private void BtnGenerateForDIC_Click(object sender, EventArgs e)
        {
            if ( selectedOrderID != "")
            {
                frmGenerateDIC generateDIC = new frmGenerateDIC(selectedOrderID);
                generateDIC.Show();
            }
            else
            {
                MessageBox.Show("Please Select an Order");
            }
        }
        private void DgvSalesOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedOrderID = dgvSalesOrderList.Rows[e.RowIndex].Cells["SalesOrderID"].Value.ToString();
                dgvOrderDetail.DataSource = null;
                dgvOrderDetail.DataSource = salesOrder.getSalesOrderLineBySalesOrderID(selectedOrderID);
                selectedOrderLineProductID = dgvOrderDetail.Rows[0].Cells["ProductID"].Value.ToString(); //default seleting a product at order line 1
            }
        }

        private void DtpOrderDateFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpOrderDateFrom.CustomFormat = "yyyy-MM-dd";
        }

        private void DtpOrderDateTo_ValueChanged(object sender, EventArgs e)
        {
            dtpOrderDateTo.CustomFormat = "yyyy-MM-dd";
        }

        private void DgvOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedOrderLineProductID = dgvOrderDetail.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
            }
        }
    }
}

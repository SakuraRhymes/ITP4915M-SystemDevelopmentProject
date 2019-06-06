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
        private string generateForDID;
        private string orderIDForGenerate;
        private string selectedOrderDetail;
        private SalesOrder salesOrder;

        public frmDispatchingList()
        {
            salesOrder = new SalesOrder();
            InitializeComponent();
            startUp();
        }

        private void startUp()
        {
            dgvOrderDetail.DataSource = null;
            changeDispatchingDvgContect(salesOrder.getSalesOrderTableBySalesOrderStatus("Processing"));
            selectedOrderID = "";
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
                    string successfulMessage = "Sales Order :" + selectedOrderID + " has been Dispatch!";
                    MessageBox.Show(successfulMessage);
                    refreshDvg();
                }
            }
            else
            {
                MessageBox.Show("Please Select An Order");
            }
        }

        private void BtnGenerateForDID_Click(object sender, EventArgs e)
        {
            OpenGenerateDIDForm(selectedOrderID);
        }

        private void OpenGenerateDIDForm(string selectedOrderID)
        {
            frmGenerateDID generateDID = new frmGenerateDID(selectedOrderID);
            generateDID.Show();
        }

        private void BtnGenerateForDIC_Click(object sender, EventArgs e)
        {
            OpenGenerateDICForm(selectedOrderID);
        }

        private void OpenGenerateDICForm(string selectedOrderID)
        {
            frmGenerateDIC generateDIC = new frmGenerateDIC(selectedOrderID);
            generateDIC.Show();
        }

        private void DgvSalesOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedOrderID = dgvSalesOrderList.Rows[e.RowIndex].Cells["SalesOrderID"].Value.ToString();
                dgvOrderDetail.DataSource = null;
                dgvOrderDetail.DataSource = salesOrder.getSalesOrderLineBySalesOrderID(selectedOrderID);
            }
        }
    }
}

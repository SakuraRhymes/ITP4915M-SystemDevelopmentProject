using System;
using System.Windows.Forms;
using SLMCS_Class;

namespace SLMCS_ERP
{
    public partial class frmGoodsReceiveList : Form
    {
        private string selectedOrderID;
        private ReorderOrder reorderOrder;
        public frmGoodsReceiveList()
        {
            InitializeComponent();
            dgvGoodsRecevieList.AllowUserToAddRows = false;
            dgvGoodsRecevieList.RowHeadersVisible = false;
            dgvGoodsRecevieList.ReadOnly = true;
            dgvGoodsRecevieList.AllowUserToResizeRows = false;
            dgvGoodsRecevieList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txtStaffID.MaxLength = 9;
            txtOrderID.MaxLength = 14;
            reorderOrder = new ReorderOrder();
        }

        private void FrmGoodsReceiveList_Load(object sender, EventArgs e)
        {
            selectedOrderID = "";
            dgvGoodsRecevieList.DataSource = reorderOrder.GetOrderedOrderTable("");

            dtpOrderDateFrom.Text = "";
            dtpOrderDateFrom.Format = DateTimePickerFormat.Custom;
            dtpOrderDateFrom.CustomFormat = " ";
            dtpOrderDateTo.Text = "";
            dtpOrderDateTo.Format = DateTimePickerFormat.Custom;
            dtpOrderDateTo.CustomFormat = " ";

            txtOrderID.Text = "";
            txtStaffID.Text = "";
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (dgvGoodsRecevieList.Rows.Count > 0 && selectedOrderID != "")
            {
                if (MessageBox.Show("Confirm Reorder ID: " + selectedOrderID + " Order?", "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    reorderOrder.GoodsReceived_updataReorderOrderByRedoreOrderStatus(selectedOrderID, "Received");
                    string successfulMessage = "Reorder ID :" + selectedOrderID + " is received!";
                    MessageBox.Show(successfulMessage);
                    FrmGoodsReceiveList_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Please Select an Order");
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            FrmGoodsReceiveList_Load(sender, e);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string query = OrderMultiSearchString();
            dgvGoodsRecevieList.DataSource = reorderOrder.GetOrderedOrderTable(query);
        }

        private void DgvGoodsRecevieList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedOrderID = dgvGoodsRecevieList.Rows[e.RowIndex].Cells["ReorderOrderID"].Value.ToString();
            }
        }

        private string OrderMultiSearchString()
        {
            string queryString = "";
            if (txtOrderID.Text != "")
            {
                queryString += "ReorderOrderID LIKE '%" + txtOrderID.Text + "%'" + " AND ";
            }
            if (txtStaffID.Text != "")
            {
                queryString += "StaffID LIKE '%" + txtStaffID.Text + "%'" + " AND ";
            }
            if (dtpOrderDateFrom.Text != " " && dtpOrderDateTo.Text != " ")
            {
                queryString += "ReorderOrderDate BETWEEN '" + dtpOrderDateFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpOrderDateTo.Value.ToString("yyyy-MM-dd") + "' AND ";
            }
            if (queryString != "")
            {
                queryString = queryString.Remove(queryString.Length - 5);
            }
            //MessageBox.Show(queryString);
            return queryString;
        }

        private void DtpOrderDateFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpOrderDateFrom.CustomFormat = "yyyy-MM-dd";
        }

        private void DtpOrderDateTo_ValueChanged(object sender, EventArgs e)
        {
            dtpOrderDateTo.CustomFormat = "yyyy-MM-dd";
        }
    }
}

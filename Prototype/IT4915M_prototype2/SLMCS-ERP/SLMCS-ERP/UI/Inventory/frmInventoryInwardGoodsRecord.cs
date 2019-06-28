using System;
using System.Windows.Forms;
using SLMCS_Class;

namespace SLMCS_ERP
{
    public partial class frmInventoryInwardGoodsRecord : Form
    {
        private ReorderOrder reorderOrder;
        private string selectReorderOrderID;
        public frmInventoryInwardGoodsRecord()
        {
            InitializeComponent();
            reorderOrder = new ReorderOrder();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string queryString = OrderMultiSearchString();
            dgvInwardGoodsRecord.DataSource = reorderOrder.GetInwardGoodsRecordTable(queryString);
            //MessageBox.Show(dtpOrderDateFrom.Value.ToString("dd/MM/yyyy"));
            DGVInwardGoodsRecordFormatSetting();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FrmInventoryInwardGoodsRecord_Load(sender, e);
        }

        private string OrderMultiSearchString()
        {
            string queryString = "";
            if (txtReorderOrderID.Text != "")
            {
                queryString += "ReorderOrderID LIKE '%" + txtReorderOrderID.Text + "%'" + " AND ";
            }
            if (txtStaffID.Text != "")
            {
                queryString += "StaffID LIKE '%" + txtStaffID.Text + "%'" + " AND ";
            }
            if (dtpOrderDateFrom.Text != " " && dtpOrderDateTo.Text != " ")
            {
                queryString += "ReorderOrderDate BETWEEN '" + dtpOrderDateFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpOrderDateTo.Value.ToString("yyyy-MM-dd") + "' AND ";
            }
            if (dtpCompletedDateFrom.Text != " " && dtpCompletedDateTo.Text != " ")
            {
                queryString += "ReorderOrderCompletedDate BETWEEN '" + dtpCompletedDateFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpCompletedDateTo.Value.ToString("yyyy-MM-dd") + "' AND ";
            }
            if (queryString != "")
            {
                queryString = queryString.Remove(queryString.Length - 5);
            }
            //MessageBox.Show(queryString);
            return queryString;
        }

        private void DgvInwardGoodsRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectReorderOrderID = dgvInwardGoodsRecord.Rows[e.RowIndex].Cells["Order ID"].Value.ToString();
                reorderOrder = new ReorderOrder(selectReorderOrderID);

                lblDReorderOrderIDData.Text = reorderOrder.ReorderOrderID;
                lblDStaffIDData.Text = reorderOrder.StaffID;
                lblDOrderDateData.Text = reorderOrder.ReorderOrderDate;
                lblDReceivedDateData.Text = reorderOrder.ReorderOrderDate;
                lblDEditDateData.Text = reorderOrder.ReorderOrderEditDate;
                lblDReceivedDateData.Text = reorderOrder.ReorderOrderReceivedDate;
                lblDCompletedDateData.Text = reorderOrder.ReorderOrderCompletedDate;

                dgvReorderOrderLine.DataSource = reorderOrder.GetReorderOrderLineTable(selectReorderOrderID);
                DGVInwardGoodsOrderLineFormatSetting();
            }
        }

        private void FrmInventoryInwardGoodsRecord_Load(object sender, EventArgs e)
        {
            dgvInwardGoodsRecord.AllowUserToAddRows = false;
            dgvInwardGoodsRecord.RowHeadersVisible = false;
            dgvInwardGoodsRecord.ReadOnly = true;
            dgvInwardGoodsRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInwardGoodsRecord.AllowUserToResizeRows = false;

            dgvReorderOrderLine.AllowUserToAddRows = false;
            dgvReorderOrderLine.RowHeadersVisible = false;
            dgvReorderOrderLine.ReadOnly = true;
            dgvReorderOrderLine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReorderOrderLine.AllowUserToResizeRows = false;

            lblDReorderOrderIDData.Text = "---";
            lblDStaffIDData.Text = "---";
            lblDOrderDateData.Text = "---";
            lblDReceivedDateData.Text = "---";
            lblDEditDateData.Text = "---";
            lblDReceivedDateData.Text = "---";
            lblDCompletedDateData.Text = "---";

            txtReorderOrderID.Text = "";
            txtStaffID.Text = "";

            dgvInwardGoodsRecord.DataSource = null;
            dgvReorderOrderLine.DataSource = null;

            dtpOrderDateFrom.Text = "";
            dtpOrderDateFrom.Format = DateTimePickerFormat.Custom;
            dtpOrderDateFrom.CustomFormat = " ";
            dtpOrderDateTo.Text = "";
            dtpOrderDateTo.Format = DateTimePickerFormat.Custom;
            dtpOrderDateTo.CustomFormat = " ";

            dtpCompletedDateFrom.Text = "";
            dtpCompletedDateFrom.Format = DateTimePickerFormat.Custom;
            dtpCompletedDateFrom.CustomFormat = " ";
            dtpCompletedDateTo.Text = "";
            dtpCompletedDateTo.Format = DateTimePickerFormat.Custom;
            dtpCompletedDateTo.CustomFormat = " ";

        }

        private void DGVInwardGoodsRecordFormatSetting()
        {
            dgvInwardGoodsRecord.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvInwardGoodsRecord.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvInwardGoodsRecord.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvInwardGoodsRecord.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvReorderOrderLine.DataSource = null;
        }

        private void DGVInwardGoodsOrderLineFormatSetting()
        {
            dgvReorderOrderLine.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReorderOrderLine.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReorderOrderLine.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReorderOrderLine.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReorderOrderLine.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            FrmInventoryInwardGoodsRecord_Load(sender, e);
        }

        private void DtpOrderDateFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpOrderDateFrom.CustomFormat = "yyyy-MM-dd";
        }

        private void DtpOrderDateTo_ValueChanged(object sender, EventArgs e)
        {
            dtpOrderDateTo.CustomFormat = "yyyy-MM-dd";
        }

        private void DtpCompletedDateFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpCompletedDateFrom.CustomFormat = "yyyy-MM-dd";
        }

        private void DtpCompletedDateTo_ValueChanged(object sender, EventArgs e)
        {
            dtpCompletedDateTo.CustomFormat = "yyyy-MM-dd";
        }
    }
}

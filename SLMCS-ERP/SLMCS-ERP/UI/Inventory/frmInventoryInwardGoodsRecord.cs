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
            
            if (queryString != "")
            {
                queryString = queryString.Remove(queryString.Length - 5);
            }
     
            return queryString;
        }

        private void DgvInwardGoodsRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectReorderOrderID = dgvInwardGoodsRecord.Rows[e.RowIndex].Cells["ReOrder ID"].Value.ToString();
                dgvInwardGoodsRecord.Rows[e.RowIndex].Selected = true;
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

            dgvReorderOrderLine.AllowUserToAddRows = false;
            dgvReorderOrderLine.RowHeadersVisible = false;
            dgvReorderOrderLine.ReadOnly = true;

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
            dgvReorderOrderLine.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            FrmInventoryInwardGoodsRecord_Load(sender, e);
        }
    }
}

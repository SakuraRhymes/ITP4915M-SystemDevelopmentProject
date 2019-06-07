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

namespace SLMCS_ERP.UI.Dispatch
{
    public partial class frmGoodsReceivedRecord : Form
    {
        private ReorderOrder reorderOrder;
        private string selectOrderID;
        public frmGoodsReceivedRecord()
        {
            InitializeComponent();
            dgvGoodsReceivedList.AllowUserToAddRows = false;
            dgvGoodsReceivedList.RowHeadersVisible = false;
            dgvGoodsReceivedList.ReadOnly = true;
            dgvGoodsReceivedList.AllowUserToResizeRows = false;
            dgvGoodsReceivedList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvReceivedOrderLine.AllowUserToAddRows = false;
            dgvReceivedOrderLine.RowHeadersVisible = false;
            dgvReceivedOrderLine.ReadOnly = true;
            dgvReceivedOrderLine.AllowUserToResizeRows = false;
            dgvReceivedOrderLine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            txtStaffID.MaxLength = 9;
            txtOrderID.MaxLength = 14;
            reorderOrder = new ReorderOrder();
        }

        private void FrmGoodsReceivedRecord_Load(object sender, EventArgs e)
        {
            selectOrderID = "";

            dtpOrderDateFrom.Text = "";
            dtpOrderDateFrom.Format = DateTimePickerFormat.Custom;
            dtpOrderDateFrom.CustomFormat = " ";
            dtpOrderDateTo.Text = "";
            dtpOrderDateTo.Format = DateTimePickerFormat.Custom;
            dtpOrderDateTo.CustomFormat = " ";

            dtpReceivedDateFrom.Text = "";
            dtpReceivedDateFrom.Format = DateTimePickerFormat.Custom;
            dtpReceivedDateFrom.CustomFormat = " ";
            dtpReceivedDateTo.Text = "";
            dtpReceivedDateTo.Format = DateTimePickerFormat.Custom;
            dtpReceivedDateTo.CustomFormat = " ";

            dgvGoodsReceivedList.DataSource = null;
            dgvReceivedOrderLine.DataSource = null;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string query = OrderMultiSearchString();
            dgvGoodsReceivedList.DataSource = reorderOrder.GetReceivedOrderHistoryTable(query);
            DGVReceivedOrderRecordFormatSetting();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            FrmGoodsReceivedRecord_Load(sender, e);
        }

        private void DgvGoodsReceivedList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectOrderID = dgvGoodsReceivedList.Rows[e.RowIndex].Cells["ReorderOrderID"].Value.ToString();
                reorderOrder = new ReorderOrder(selectOrderID);

                lblDReorderOrderIDData.Text = reorderOrder.ReorderOrderID;
                lblDStaffIDData.Text = reorderOrder.StaffID;
                lblDOrderDateData.Text = reorderOrder.ReorderOrderDate;
                lblDReceivedDateData.Text = reorderOrder.ReorderOrderDate;
                lblDEditDateData.Text = reorderOrder.ReorderOrderEditDate;
                lblDReceivedDateData.Text = reorderOrder.ReorderOrderReceivedDate;
                dgvReceivedOrderLine.DataSource = reorderOrder.GetReorderOrderLineTable(selectOrderID);

                DGVReceivedOrderLineFormatSetting();
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
            if (dtpReceivedDateFrom.Text != " " && dtpReceivedDateTo.Text != " ")
            {
                queryString += "ReorderOrderReceivedDate BETWEEN '" + dtpReceivedDateFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpReceivedDateTo.Value.ToString("yyyy-MM-dd") + "' AND ";
            }
            if (queryString != "")
            {
                queryString = queryString.Remove(queryString.Length - 5);
            }
            MessageBox.Show(queryString);
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

        private void DtpReceivedDateFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpReceivedDateFrom.CustomFormat = "yyyy-MM-dd";
        }

        private void DtpReceivedDateTo_ValueChanged(object sender, EventArgs e)
        {
            dtpReceivedDateTo.CustomFormat = "yyyy-MM-dd";
        }

        private void DGVReceivedOrderRecordFormatSetting()
        {
            dgvGoodsReceivedList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGoodsReceivedList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGoodsReceivedList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGoodsReceivedList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void DGVReceivedOrderLineFormatSetting()
        {
            dgvReceivedOrderLine.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReceivedOrderLine.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReceivedOrderLine.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReceivedOrderLine.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReceivedOrderLine.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        
    }
}

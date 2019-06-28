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

namespace SLMCS_ERP
{
    public partial class frmInventoryInwardGoods : Form
    {
        private ReorderOrder reorderOrder;
        private string selectedReorderOrderID;
        public frmInventoryInwardGoods()
        {
            InitializeComponent();
            reorderOrder = new ReorderOrder();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            dgvReceivedOrderRecord.DataSource = reorderOrder.GetReceivedReorderOrderTable();
            DGVReceivedOrderRecordFormatSetting();
        }

        private void DgvReceivedOrderRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex != -1)
            {
                selectedReorderOrderID = dgvReceivedOrderRecord.Rows[e.RowIndex].Cells["ReorderOrderID"].Value.ToString();
                reorderOrder = new ReorderOrder(selectedReorderOrderID);

                lblDReorderOrderIDData.Text = reorderOrder.ReorderOrderID;
                lblDStaffIDData.Text = reorderOrder.StaffID;
                lblDOrderDateData.Text = reorderOrder.ReorderOrderDate;
                lblDReceivedDateData.Text = reorderOrder.ReorderOrderDate;
                lblDEditDateData.Text = reorderOrder.ReorderOrderEditDate;
                lblDReceivedDateData.Text = reorderOrder.ReorderOrderReceivedDate;
                dgvOrderDetail.DataSource = reorderOrder.GetReorderOrderLineTable(selectedReorderOrderID);
                //dgvOrderDetail.Rows[e.RowIndex].Selected = true;
                DGVReceivedOrderLineFormatSetting();

                btnConfirm.Enabled = true;

            }     
        }

        private void FrmInventoryInwardGoods_Load(object sender, EventArgs e)
        {
            dgvReceivedOrderRecord.ReadOnly = true;
            dgvReceivedOrderRecord.AllowUserToAddRows = false;
            dgvReceivedOrderRecord.RowHeadersVisible = false;
            dgvReceivedOrderRecord.DataSource = null;
            dgvReceivedOrderRecord.AllowUserToResizeRows = false;
            dgvReceivedOrderRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvOrderDetail.ReadOnly = true;
            dgvOrderDetail.AllowUserToAddRows = false;
            dgvOrderDetail.RowHeadersVisible = false;
            dgvOrderDetail.DataSource = null;
            dgvOrderDetail.AllowUserToResizeRows = false;
            dgvOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblDReorderOrderIDData.Text = "---";
            lblDStaffIDData.Text = "---";
            lblDOrderDateData.Text = "---";
            lblDReceivedDateData.Text = "---";
            lblDEditDateData.Text = "---";
            lblDReceivedDateData.Text = "---";

            btnConfirm.Enabled = false;
            BtnRefresh_Click(sender, e);
        }

        private void DGVReceivedOrderRecordFormatSetting()
        {
            dgvReceivedOrderRecord.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReceivedOrderRecord.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReceivedOrderRecord.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReceivedOrderRecord.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void DGVReceivedOrderLineFormatSetting()
        {
            dgvOrderDetail.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvOrderDetail.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvOrderDetail.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvOrderDetail.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvOrderDetail.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Inward Product Order?", "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                reorderOrder.ConfirmReorderOrder();
                reorderOrder.UpdateStatus("Completed");
                reorderOrder.UpdateCompletedDate(DateTime.Today.ToString("yyyy-MM-dd"));
                FrmInventoryInwardGoods_Load(sender, e);
                MessageBox.Show("Order has been complete");
            }
            
            
        }
    }
}

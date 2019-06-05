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
            
            //selectedProductID = dgvStockRecord.Rows[0].Cells["ProductID"].Value.ToString();
            //DGVSearchFormatSetting();
            FrmInventoryInwardGoodsRecord_Load(sender, e);
            
            string queryString = ProductMultiSearchString();
            dgvInwardGoodsRecord.DataSource = reorderOrder.GetInwardGoodsRecordTable(reorderOrder.GetMultiChoiceQuery(queryString));
            DGVInwardGoodsRecordFormatSetting();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FrmInventoryInwardGoodsRecord_Load(sender, e);
        }

        private string ProductMultiSearchString()
        {
            string queryString = "";
            if (txtReorderOrderID.Text != "")
            {
                queryString += "ReorderOrderID LIKE '%" + txtReorderOrderID.Text + "%'" + "/";
            }
            if (txtStaffID.Text != "")
            {
                queryString += "StaffID LIKE '%" + txtStaffID.Text + "%'" + "/";
            }

            return queryString;
        }

        private void DgvInwardGoodsRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectReorderOrderID = dgvInwardGoodsRecord.Rows[e.RowIndex].Cells["ReorderOrderID"].Value.ToString();
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

            lblDReorderOrderIDData.Text = "";
            lblDStaffIDData.Text = "";
            lblDOrderDateData.Text = "";
            lblDReceivedDateData.Text = "";
            lblDEditDateData.Text = "";
            lblDReceivedDateData.Text = "";
            lblDCompletedDateData.Text = "";

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
    }
}

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
            dgvReceivedOrderRecord.DataSource = reorderOrder.GetReorderOrderTable("WHERE ReorderOrderStatus = 'Received'");
        }

        private void DgvReceivedOrderRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex != -1)
            {
                selectedReorderOrderID = dgvReceivedOrderRecord.Rows[e.RowIndex].Cells["ReorderOrderID"].Value.ToString();
                dgvOrderDetail.DataSource = reorderOrder.GetReorderOrderLineTable(selectedReorderOrderID);
                //dgvOrderDetail.Rows[e.RowIndex].Selected = true;
            }
        }

        private void FrmInventoryInwardGoods_Load(object sender, EventArgs e)
        {
            dgvReceivedOrderRecord.ReadOnly = true;
            dgvReceivedOrderRecord.AllowUserToAddRows = false;
            dgvReceivedOrderRecord.RowHeadersVisible = false;

            dgvOrderDetail.ReadOnly = true;
            dgvOrderDetail.AllowUserToAddRows = false;
            dgvOrderDetail.RowHeadersVisible = false;
        }
    }
}

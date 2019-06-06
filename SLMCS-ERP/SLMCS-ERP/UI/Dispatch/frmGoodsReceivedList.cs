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
    public partial class frmGoodsReceivedList : Form
    {
        ReorderOrder reorderOrder;
        private string selectedOrderID;
        public frmGoodsReceivedList()
        {
            InitializeComponent();
            reorderOrder = new ReorderOrder();
            selectedOrderID = "";
        }

        private void changeGoodsReceviedDvgContent(DataTable table)
        {
            dgvGoodsRecevieList.DataSource = null;
            dgvGoodsRecevieList.DataSource = table;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string condition = "";
            int andCount = 0;
            if (txtOrderID.Text != "")
            {
                condition += "ReorderOrderID LIKE '%" + txtOrderID.Text + "%'";
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

            if (andCount > 0)
            {
                condition += " AND ";
                andCount--;
            }

            condition += "ReorderOrderStatus = 'Processing'";

            changeGoodsReceviedDvgContent(reorderOrder.GoodsReceived_getReorderTableByWhereQuery(condition));
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            changeGoodsReceviedDvgContent(reorderOrder.getReorderOrderTableByReorderOrderStatus("Processing"));

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
                    refresh();
                }
            }
            else
            {
                MessageBox.Show("Please Select An Order");
            }
        }

        private void FrmGoodsReceivedList_Load(object sender, EventArgs e)
        {
            dgvGoodsRecevieList.AllowUserToAddRows = false;
            dgvGoodsRecevieList.RowHeadersVisible = false;
            dgvGoodsRecevieList.ReadOnly = true;
            dgvGoodsRecevieList.AllowUserToResizeRows = false;
            dgvGoodsRecevieList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            refresh();
        }

        private void DgvGoodsRecevieList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedOrderID = dgvGoodsRecevieList.Rows[e.RowIndex].Cells["ReorderOrderID"].Value.ToString();
            }
            
        }
    }
}
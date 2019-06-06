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
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvGoodsRecevieList.DataSource = null;
            changeGoodsReceviedDvgContent(reorderOrder.getReorderOrderTableByReorderOrderStatus("Prcossing"));
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
                condition += "ReorderOrderID LIKE \"%" + txtOrderID.Text + "%\"";
                andCount++;
            }

            if (txtStaffID.Text != "")
            {
                if (andCount > 0)
                {
                    condition += " AND ";
                    andCount--;
                }
                condition += "StaffID LIKE \"%" + txtStaffID.Text + "%\"";
                andCount++;
            }

            if (andCount > 0)
            {
                condition += " AND ";
                andCount--;
            }

            condition += "ReorderOrderStatus = \"Processing\"";

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
            selectedOrderID = dgvGoodsRecevieList.Rows[dgvGoodsRecevieList.CurrentCell.RowIndex].Cells["ReorderOrderID"].Value.ToString();
            DialogResult result = MessageBox.Show("Reccive " + selectedOrderID + "?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (dgvGoodsRecevieList.CurrentCell.RowIndex != -1)
                {
                    System.Windows.Forms.MessageBox.Show(selectedOrderID);
                    reorderOrder.GoodsReceived_updataReorderOrderByRedoreOrderStatus(selectedOrderID, "Received");
                    string successfulMessage = "Reorder Order :" + selectedOrderID + " is received!";
                    MessageBox.Show(successfulMessage);
                    refresh();
                }
            }
        }
     }
}
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
        public frmInventoryInwardGoodsRecord()
        {
            InitializeComponent();
            reorderOrder = new ReorderOrder();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string queryString = ProductMultiSearchString();
            dgvInwardGoodsRecord.DataSource = reorderOrder.GetInwardGoodsRecordTable(reorderOrder.GetMultiChoiceQuery(queryString));
            //selectedProductID = dgvStockRecord.Rows[0].Cells["ProductID"].Value.ToString();
            //DGVSearchFormatSetting();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

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
    }
}

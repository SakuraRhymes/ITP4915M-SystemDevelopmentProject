using System;
using System.Windows.Forms;
using SLMCS_Class;

namespace SLMCS_ERP
{
    public partial class frmGoodsReceivedHistory : Form
    {
        private ReorderOrder reorderOrder;
        private string selectOrderID;
        public frmGoodsReceivedHistory()
        {
            InitializeComponent();
            dgvGoodsReceivedList.AllowUserToAddRows = false;
            dgvGoodsReceivedList.RowHeadersVisible = false;
            dgvGoodsReceivedList.ReadOnly = true;
            dgvGoodsReceivedList.AllowUserToResizeRows = false;
            dgvGoodsReceivedList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txtStaffID.MaxLength = 9;
            txtOrderID.MaxLength = 14;
            reorderOrder = new ReorderOrder();
        }

        private void FrmGoodsReceivedHistory_Load(object sender, EventArgs e)
        {
            selectOrderID = "";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            FrmGoodsReceivedHistory_Load(sender, e);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string query = OrderMultiSearchString();
            //dgvGoodsReceivedList.DataSource = reorderOrder.GetReceivedOrderTable(query);
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
    }
}

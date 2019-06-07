using SLMCS_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLMCS_ERP.UI.Sales
{
    public partial class frmSalesOrderRecords : Form
    {
        SalesOrder salesOrder;
        DataTable dt;
        string selectedSalesOrderID;

        public frmSalesOrderRecords()
        {
            InitializeComponent();
            setupCombobox();
            salesOrder = new SalesOrder();
            SearchSalesOrder();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchSalesOrder();
        }

        private void SearchSalesOrder()
        {

            if (txtSearchCondition.Text == "")
            {
                dt = salesOrder.searchSalesOrder("");
            }
            else
            {
                string condition = "WHERE " + cboSearchType.SelectedValue.ToString() + " LIKE '%" + txtSearchCondition.Text + "%'";
                //MessageBox.Show(condition);
                dt = salesOrder.searchSalesOrder(condition);
            }
            updateDGV(dt);
        }

        private void setupCombobox()
        {
            cboSearchType.DisplayMember = "Text";
            cboSearchType.ValueMember = "Value";

            var items = new[] {
                new { Text = "Order ID", Value = "SalesOrderID" },
                new { Text = "Order Date", Value = "SalesOrderDate" },
                new { Text = "Order Status", Value = "SalesOrderStatus" },
                new { Text = "Staff ID", Value = "StaffID" },
                new { Text = "Dealer ID", Value = "DealerID" }
                //new { Text = "Product ID", Value = "ProductID" }
            };

            cboSearchType.DataSource = items;

            dgvSearchResult.AllowUserToAddRows = false;
            dgvSearchResult.RowHeadersVisible = false;
            dgvSearchResult.ReadOnly = true;
            dgvSearchResult.AllowUserToResizeRows = false;
            dgvSearchResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void updateDGV(DataTable dt)
        {
            dgvSearchResult.DataSource = null;
            dgvSearchResult.DataSource = dt;

            dgvSearchResult.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSearchResult.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSearchResult.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSearchResult.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSearchResult.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSearchResult.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSearchResult.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void DgvSearchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedSalesOrderID = dgvSearchResult.Rows[e.RowIndex].Cells["SalesOrderID"].Value.ToString();
            }

        }

        private void DgvSearchResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                frmViewOrderRecord viewOrderRecord = new frmViewOrderRecord(selectedSalesOrderID);
                viewOrderRecord.Show();
            }

        }

        private void TxtSearchCondition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchSalesOrder();
            }
        }
    }
}

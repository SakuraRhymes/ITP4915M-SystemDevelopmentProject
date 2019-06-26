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
            setup();
            salesOrder = new SalesOrder();
            dtpClear();
        }

        private void dtpClear()
        {
            dtpOrderDateFrom.Text = "";
            dtpOrderDateFrom.Format = DateTimePickerFormat.Custom;
            dtpOrderDateFrom.CustomFormat = " ";
            dtpOrderDateTo.Text = "";
            dtpOrderDateTo.Format = DateTimePickerFormat.Custom;
            dtpOrderDateTo.CustomFormat = " ";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchSalesOrder();
        }

        private void SearchSalesOrder()
        {
            String queryString = ProductMultiSearchString();

            //MessageBox.Show(queryString);
            dt = salesOrder.searchSalesOrder(queryString);
            
            updateDGV(dt);
        }

        private string ProductMultiSearchString()
        {
            string queryString = "WHERE SalesOrder.SalesOrderID = SalesOrderLine.SalesOrderID AND ";
            if (txtOrderID.Text != "")
            {
                queryString += "SalesOrder.SalesOrderID LIKE '%" + txtOrderID.Text + "%'" + " AND ";
            }
            if (txtDealerID.Text != "")
            {
                queryString += "DealerID LIKE '%" + txtDealerID.Text + "%' " + " AND ";
            }
            if (txtStaffID.Text != "")
            {
                queryString += "StaffID LIKE '%" + txtStaffID.Text + "%' " + " AND ";
            }
            if (txtProductID.Text != "")
            {
                queryString += "ProductID LIKE '%" + txtProductID.Text + "%' " + " AND ";
            }
            if (cmbOrderStatus.Text != "")
            {
                queryString += "SalesOrderStatus LIKE '%" + cmbOrderStatus.Text + "%'" + " AND ";
            }
            if (dtpOrderDateFrom.Text != " " && dtpOrderDateTo.Text != " ")
            {
                queryString += "SalesOrderDate BETWEEN '" + dtpOrderDateFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpOrderDateTo.Value.ToString("yyyy-MM-dd") + "' AND ";
            }
            if (queryString != "")
            {
                queryString = queryString.Remove(queryString.Length - 5);
            }
            return queryString;
        }

        private void setup()
        {
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
            dgvSearchResult.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchResult.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchResult.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchResult.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchResult.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchResult.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchResult.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

        private void FrmSalesOrderRecords_Load(object sender, EventArgs e)
        {
            dtpClear();
            SearchSalesOrder();
        }

        private void DtpOrderDateFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpOrderDateFrom.CustomFormat = "yyyy-MM-dd";
        }

        private void DtpOrderDateTo_ValueChanged(object sender, EventArgs e)
        {
            dtpOrderDateTo.CustomFormat = "yyyy-MM-dd";
        }
    }
}

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
        public frmSalesOrderRecords()
        {
            InitializeComponent();
            setupCombobox();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SalesOrder salesOrder = new SalesOrder();
            DataTable dt;
            if (txtSearchCondition.Text == "")
            {
                dt = salesOrder.searchSalesOrder(null);
            }
            else
            {
                dt = null;
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
                new { Text = "Dealer ID", Value = "DealerID" },
                new { Text = "Product ID", Value = "ProductID" }
            };

            cboSearchType.DataSource = items;
        }

        private void updateDGV(DataTable dt)
        {
            dgvSearchResult.DataSource = null;
            dgvSearchResult.DataSource = dt;

            dgvSearchResult.AllowUserToAddRows = false;
            dgvSearchResult.RowHeadersVisible = false;
            dgvSearchResult.ReadOnly = true;

            dgvSearchResult.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}

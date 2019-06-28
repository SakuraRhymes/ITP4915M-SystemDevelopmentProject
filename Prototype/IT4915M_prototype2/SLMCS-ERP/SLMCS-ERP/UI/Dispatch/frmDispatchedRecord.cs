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
    public partial class frmDispatchedRecord : Form
    {
        private SalesOrder salesOrder;
        private string selectOrderID;
        public frmDispatchedRecord()
        {
            InitializeComponent();
            dgvDispatchedList.AllowUserToAddRows = false;
            dgvDispatchedList.RowHeadersVisible = false;
            dgvDispatchedList.ReadOnly = true;
            dgvDispatchedList.AllowUserToResizeRows = false;
            dgvDispatchedList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvDispatchedOrderLine.AllowUserToAddRows = false;
            dgvDispatchedOrderLine.RowHeadersVisible = false;
            dgvDispatchedOrderLine.ReadOnly = true;
            dgvDispatchedOrderLine.AllowUserToResizeRows = false;
            dgvDispatchedOrderLine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            txtStaffID.MaxLength = 9;
            txtOrderID.MaxLength = 14;
            txtDealerID.MaxLength = 8;
            salesOrder = new SalesOrder();
        }

        private void FrmDispatchedRecord_Load(object sender, EventArgs e)
        {
            selectOrderID = "";

            dtpOrderDateFrom.Text = "";
            dtpOrderDateFrom.Format = DateTimePickerFormat.Custom;
            dtpOrderDateFrom.CustomFormat = " ";
            dtpOrderDateTo.Text = "";
            dtpOrderDateTo.Format = DateTimePickerFormat.Custom;
            dtpOrderDateTo.CustomFormat = " ";

            dtpDispatchedDateFrom.Text = "";
            dtpDispatchedDateFrom.Format = DateTimePickerFormat.Custom;
            dtpDispatchedDateFrom.CustomFormat = " ";
            dtpDispatchedDateTo.Text = "";
            dtpDispatchedDateTo.Format = DateTimePickerFormat.Custom;
            dtpDispatchedDateTo.CustomFormat = " ";

            dgvDispatchedList.DataSource = null;
            dgvDispatchedOrderLine.DataSource = null;

            lblDSalesOrderIDData.Text = "---";
            lblDStaffIDData.Text = "---";
            lblDOrderDateData.Text = "---";
            lblDEditDateData.Text = "---";
            lblDDispatchedDateData.Text = "---";
            lblDDealerIDData.Text = "---";

            txtOrderID.Text = "";
            txtStaffID.Text = "";
            txtDealerID.Text = "";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string query = OrderMultiSearchString();
            dgvDispatchedList.DataSource = salesOrder.GetDispatchedOrderHistoryTable(query);
            DGVDispatchedRecordFormatSetting();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            FrmDispatchedRecord_Load(sender, e);
        }

        private void DgvDispatchedList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectOrderID = dgvDispatchedList.Rows[e.RowIndex].Cells["SalesOrderID"].Value.ToString();
                salesOrder = new SalesOrder(selectOrderID);

                lblDSalesOrderIDData.Text = salesOrder.SalesOrderID;
                lblDStaffIDData.Text = salesOrder.StaffID;
                lblDDealerIDData.Text = salesOrder.DealerID;
                lblDOrderDateData.Text = salesOrder.SalesOrderDate;
                lblDEditDateData.Text = salesOrder.SalesOrderEditDate;
                lblDDispatchedDateData.Text = salesOrder.SalesDispatchDate;


                dgvDispatchedOrderLine.DataSource = salesOrder.getSalesOrderLineBySalesOrderID(selectOrderID);

                DGVDispatchOrderLineFormatSetting();
            }
        }

        private string OrderMultiSearchString()
        {
            string queryString = "";
            if (txtOrderID.Text != "")
            {
                queryString += "SalesOrderID LIKE '%" + txtOrderID.Text + "%'" + " AND ";
            }
            if (txtStaffID.Text != "")
            {
                queryString += "StaffID LIKE '%" + txtStaffID.Text + "%'" + " AND ";
            }
            if (txtDealerID.Text != "")
            {
                queryString += "DealerID LIKE '%" + txtDealerID.Text + "%'" + " AND ";
            }
            if (dtpOrderDateFrom.Text != " " && dtpOrderDateTo.Text != " ")
            {
                queryString += "SalesOrderDate BETWEEN '" + dtpOrderDateFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpOrderDateTo.Value.ToString("yyyy-MM-dd") + "' AND ";
            }
            if (dtpDispatchedDateFrom.Text != " " && dtpDispatchedDateTo.Text != " ")
            {
                queryString += "SalesDispatchDate BETWEEN '" + dtpDispatchedDateFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpDispatchedDateTo.Value.ToString("yyyy-MM-dd") + "' AND ";
            }
            if (queryString != "")
            {
                queryString = queryString.Remove(queryString.Length - 5);
            }
            //MessageBox.Show(queryString);
            return queryString;
        }

        private void DtpOrderDateFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpOrderDateFrom.CustomFormat = "yyyy-MM-dd";
        }

        private void DtpOrderDateTo_ValueChanged(object sender, EventArgs e)
        {
            dtpOrderDateTo.CustomFormat = "yyyy-MM-dd";
        }

        private void DtpDispatchedDateFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpDispatchedDateFrom.CustomFormat = "yyyy-MM-dd";
        }

        private void DtpDispatchedDateTo_ValueChanged(object sender, EventArgs e)
        {
            dtpDispatchedDateTo.CustomFormat = "yyyy-MM-dd";
        }

        private void DGVDispatchedRecordFormatSetting()
        {
            dgvDispatchedList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDispatchedList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDispatchedList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDispatchedList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void DGVDispatchOrderLineFormatSetting()
        {
            dgvDispatchedOrderLine.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDispatchedOrderLine.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDispatchedOrderLine.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDispatchedOrderLine.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDispatchedOrderLine.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}

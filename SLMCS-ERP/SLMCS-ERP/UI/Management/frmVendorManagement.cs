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

namespace SLMCS_ERP.UI.Management
{

    public partial class frmVendorManagement : Form
    {
        String selectedVendorID;
        Vendor vendor;
        public frmVendorManagement()
        {
            InitializeComponent();
            dgvVendorList.AllowUserToAddRows = false;
            dgvVendorList.RowHeadersVisible = false;
            dgvVendorList.ReadOnly = true;
            selectedVendorID = "";
            vendor = new Vendor();
        }

        private void BtnSearchVendor_Click(object sender, EventArgs e)
        {
            changeDgvVendorList(vendor.Management_GetVendorTable(vendorMultiSearchString()));

        }

        private string vendorMultiSearchString()
        {
            string queryString = "";
            if (txtVendorID.Text != "")
            {
                queryString += "VendorID LIKE '%" + txtVendorID.Text + "%'" + " AND ";
            }
            if (txtVendorName.Text != "")
            {
                queryString += "VendorName LIKE '%" + txtVendorName.Text + "%' " + " AND ";
            }
            if (txtVendorPhoneNo.Text != "")
            {
                queryString += "VendorPhoneNo LIKE '%" + txtVendorPhoneNo.Text + "%' " + " AND ";
            }
            if (queryString != "")
            {
                queryString = queryString.Remove(queryString.Length - 5);
            }

            return queryString;
        }

        private void changeDgvVendorList(DataTable table)
        {
            dgvVendorList.DataSource = null;
            dgvVendorList.DataSource = table;
            dgvVendorList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvVendorList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvVendorList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvVendorList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void DgvVendorList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedVendorID = dgvVendorList.Rows[e.RowIndex].Cells["VendorID"].Value.ToString();
                dgvVendorList.Rows[e.RowIndex].Selected = true;
                vendor = new Vendor(selectedVendorID);

                lblVendorID.Text = vendor.VendorID;
                lblVendorName.Text = vendor.VendorName;
                lblVendorPhoneNo.Text = vendor.VendorName;
                lblVendorAddress.Text = vendor.VendorAddress;
                lblVendorStatus.Text = vendor.VendorStatus;
            }
        }

        private void BtnNewVendor_Click(object sender, EventArgs e)
        {
            frmVendorManagement_NewVendor frmNewVendor = new frmVendorManagement_NewVendor();
            frmNewVendor.Show();
        }

        private void BtnEditVendor_Click(object sender, EventArgs e)
        {
            if (selectedVendorID != "")
            {
                frmVendorManagement_EditVendor frmEditVendor = new frmVendorManagement_EditVendor(selectedVendorID);
                frmEditVendor.Show();
            }
            else
            {
                MessageBox.Show("Please select a vendor");
            }
        }

        private void DgvVendorList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedVendorID = dgvVendorList.Rows[e.RowIndex].Cells["VendorID"].Value.ToString();
                dgvVendorList.Rows[e.RowIndex].Selected = true;
                vendor = new Vendor(selectedVendorID);
                BtnEditVendor_Click(sender, e);
            }
        }

        private void FrmVendorManagement_Load(object sender, EventArgs e)
        {
            dgvVendorList.AllowUserToAddRows = false;
            dgvVendorList.RowHeadersVisible = false;
            dgvVendorList.ReadOnly = true;
            dgvVendorList.AllowUserToResizeRows = false;
            dgvVendorList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}

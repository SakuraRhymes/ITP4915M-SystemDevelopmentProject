using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SLMCS_Class;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLMCS_ERP.UI.Management
{
    public partial class frmProductManagement_VendorRecord : Form
    {
        private Vendor vendor;
        private frmProductManagement_NewProduct productManagement_NewProduct;
        private string selectedVendorID;
        public frmProductManagement_VendorRecord()
        {
            InitializeComponent();
        }

        public frmProductManagement_VendorRecord(frmProductManagement_NewProduct form)
        {
            InitializeComponent();
            vendor = new Vendor();
            dgvVendorRecord.DataSource = vendor.GetVendorTable();
            dgvVendorRecord.ReadOnly = true;
            dgvVendorRecord.AllowUserToAddRows = false;
            dgvVendorRecord.RowHeadersVisible = false;
            productManagement_NewProduct = form;
            selectedVendorID = dgvVendorRecord.Rows[0].Cells["VendorID"].Value.ToString();
            FrmProductManagement_NewProduct_Load();
        }

        private void FrmProductManagement_NewProduct_Load()
        {
            dgvVendorRecord.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvVendorRecord.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            SelectVendorToSendValueBack();
        }

        private void DgvVendorRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedVendorID = dgvVendorRecord.Rows[e.RowIndex].Cells["VendorID"].Value.ToString();
            SelectVendorToSendValueBack();
        }

        private void SelectVendorToSendValueBack()
        {
            productManagement_NewProduct.SetTxtVendorID(selectedVendorID);
            Close();
        }

        private void DgvVendorRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedVendorID = dgvVendorRecord.Rows[e.RowIndex].Cells["VendorID"].Value.ToString();
        }
    }
}

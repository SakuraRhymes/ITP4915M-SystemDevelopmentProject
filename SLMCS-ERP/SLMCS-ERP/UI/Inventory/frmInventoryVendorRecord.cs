using System;
using System.Windows.Forms;
using SLMCS_Class;

namespace SLMCS_ERP
{
    public partial class frmInventoryVendorRecord : Form
    {
        private Vendor vendor;
        private frmInventoryNewProduct inventoryNewProduct;
        private string selectedVendorID;
        public frmInventoryVendorRecord()
        {
            InitializeComponent();
        }

        public frmInventoryVendorRecord(frmInventoryNewProduct form)
        {
            InitializeComponent();
            vendor = new Vendor();
            dgvVendorRecord.DataSource = vendor.GetVendorTable();
            dgvVendorRecord.ReadOnly = true;
            dgvVendorRecord.AllowUserToAddRows = false;
            dgvVendorRecord.RowHeadersVisible = false;
            inventoryNewProduct = form;
            selectedVendorID = dgvVendorRecord.Rows[0].Cells["VendorID"].Value.ToString();
        }

        private void FrmInventoryVendorRecord_Load(object sender, EventArgs e)
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

        private void DgvVendorRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedVendorID = dgvVendorRecord.Rows[e.RowIndex].Cells["VendorID"].Value.ToString();
                dgvVendorRecord.Rows[e.RowIndex].Selected = true;
            }
        }

        private void DgvVendorRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectVendorToSendValueBack();
        }

        private void SelectVendorToSendValueBack()
        {
            //if (selectedVendorID == "")
            //{
            //    MessageBox.Show("Please select a vendor");
            //}
            //else
            //{
                inventoryNewProduct.SetTxtVendorID(selectedVendorID);
                Close();
           // }
        }
    }
}

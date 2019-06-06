using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using SLMCS_Class;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLMCS_ERP.UI.Management
{
    public partial class frmProductManagement_NewProduct : Form
    {
        public frmProductManagement_NewProduct()
        {
            InitializeComponent();
        }

        private bool CheckInputFieldIsValid()
        {

            if (txtVendorID.Text != "" && txtProductName.Text != "" && txtProductPrice.Text != "")
            {
                //int productPrice = Convert.ToInt32(txtProductPrice.Text);
                //if (productPrice >= 0)
                //{
                return true;
                //}
                //MessageBox.Show("Product Price should be more than or equal to 0");
                //return false;
            }
            if (txtVendorID.Text == "")
            {
                MessageBox.Show("Please select a vendor");
                return false;
            }
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Please input product name");
                return false;
            }
            if (rtbProductDescription.Text == "")
            {
                MessageBox.Show("Please input product description");
                return false;
            }
            if (txtProductPrice.Text == "")
            {
                MessageBox.Show("Please input product price");
                return false;
            }
            return false;
        }

        private void FrmInventoryNewProduct_Load(object sender, EventArgs e)
        {
            cboProductType.Text = "Sheet Metal";
            cboProductType.DropDownStyle = ComboBoxStyle.DropDownList;

            cboProductUnit.Text = "piece";
            cboProductUnit.DropDownStyle = ComboBoxStyle.DropDownList;

            txtVendorID.Enabled = false;

        }

        private void BtnSearchVendor_Click(object sender, EventArgs e)
        {
            frmProductManagement_VendorRecord productManagement_VendorRecord = new frmProductManagement_VendorRecord(this);
            productManagement_VendorRecord.Show();
        }

        public void SetTxtVendorID(string vendorID)
        {
            txtVendorID.Text = vendorID;
        }
    }
}


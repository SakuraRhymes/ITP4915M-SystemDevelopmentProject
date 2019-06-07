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

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string vendorID = txtVendorID.Text;
            string productType = cboProductType.Text;
            string productName = txtProductName.Text;
            string productUnit = cboProductUnit.Text;
            string productDescription = rtbProductDescription.Text;
            string productPrice = txtProductPrice.Text;


            Product product = new Product();
            try
            {
                if (CheckInputFieldIsValid())
                {
                    MessageBox.Show(productName+productType+productDescription+productUnit+productPrice+vendorID);
                    product.CreateNewProduct(productName, productType, productDescription, productUnit, productPrice, vendorID);
                    MessageBox.Show("Product has been added");
                    BtnCancel_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtVendorID.Text = "";
            cboProductType.Text = "";
            txtProductName.Text = "";
            cboProductUnit.Text = "";
            rtbProductDescription.Text = "";
            txtProductPrice.Text = "";
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

        private void frmProductManagement_NewProduct_Load(object sender, EventArgs e)
        {
            cboProductType.Text = "Sheet Metal";
            cboProductType.DropDownStyle = ComboBoxStyle.DropDownList;

            cboProductUnit.Text = "piece";
            cboProductUnit.DropDownStyle = ComboBoxStyle.DropDownList;

            txtVendorID.Enabled = false;

        }

        private void TxtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void BtnSearchVendor_Click(object sender, EventArgs e)
        {
            frmProductManagement_VendorRecord managementVendorRecord = new frmProductManagement_VendorRecord(this);
            managementVendorRecord.Show();
        }

        public void SetTxtVendorID(string vendorID)
        {
            txtVendorID.Text = vendorID;
        }
    }
}


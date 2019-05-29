using System;
using System.Windows.Forms;
using SLMCS_Class;

namespace SLMCS_ERP
{
    public partial class frmInventoryNewProduct : Form
    {
        public frmInventoryNewProduct()
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
                    product.CreateNewProduct(productName, productType, productDescription, productUnit, productPrice, vendorID);
                    BtnCancel_Click(sender, e);
                    MessageBox.Show("Product has been added");
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

        private void FrmInventoryNewProduct_Load(object sender, EventArgs e)
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

        private void TxtVendorID_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            frmInventoryVendorRecord inventoryVendorRecord = new frmInventoryVendorRecord();
            inventoryVendorRecord.Show();
        }
    }
}

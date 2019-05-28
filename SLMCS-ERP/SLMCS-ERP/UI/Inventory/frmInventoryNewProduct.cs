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
                product.CreateNewProduct(productName, productType, productDescription, productUnit, productPrice, vendorID);
                BtnCancel_Click(sender, e);
                MessageBox.Show("Product has been added");
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

        private bool CheckFormInputIsValid()
        {

            return false;
        }


        private void FrmInventoryNewProduct_Load(object sender, EventArgs e)
        {
            cboProductType.Text = "Sheet Metal";
            cboProductType.DropDownStyle = ComboBoxStyle.DropDownList;

            cboProductUnit.Text = "piece";
            cboProductUnit.DropDownStyle = ComboBoxStyle.DropDownList;
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
            if (System.Text.RegularExpressions.Regex.IsMatch(txtVendorID.Text, "V[0-9]{7}") && !(e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }
    }
}

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
    public partial class frmProductManagement_EditProduct : Form
    {
        private Product product;
        public frmProductManagement_EditProduct()
        {
            InitializeComponent();
        }

        public frmProductManagement_EditProduct(string productID)
        {
            InitializeComponent();
            product = new Product(productID);
            frmProductManagement_EditProduct_Load();


        }

        private void frmProductManagement_EditProduct_Load()
        {
            lblProductIDData.Text = product.ProductID;
            lblProductTypeData.Text = product.ProductType;
            txtProductName.Text = product.ProductName;
            rtbProductDesc.Text = product.ProductDescription;
            cboProductUnit.Text = product.ProductUnit;
            txtProductPrice.Text = product.ProductPrice.ToString();
            txtActualQty.Text = product.ActualQuantity.ToString();
            txtReorderLevel.Text = product.ReorderLevel.ToString();
            txtDangerLevel.Text = product.DangerLevel.ToString();
            ckbProductStatus.Checked = (product.ProductStatus == "Available");
            //cboProductType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProductUnit.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            product.UpdateProductDetail(lblProductIDData.Text, lblProductTypeData.Text, txtProductName.Text, rtbProductDesc.Text, cboProductUnit.Text, txtProductPrice.Text, txtActualQty.Text, txtReorderLevel.Text, txtDangerLevel.Text, (ckbProductStatus.Checked? "Available": "UnAvailable"));
            string successfulMessage = "Product ID:" + lblProductIDData.Text + " has been updated";
            MessageBox.Show(successfulMessage);
            this.Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            frmProductManagement_EditProduct_Load();
        }

        private void TxtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInputNumberOnly(e);
        }

        private void TxtActualQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInputNumberOnly(e);
        }

        private void TxtReorderLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInputNumberOnly(e);
        }

        private void TxtDangerLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInputNumberOnly(e);
        }

        private void CheckInputNumberOnly(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }
    }
}


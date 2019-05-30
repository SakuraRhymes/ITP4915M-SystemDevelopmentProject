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

namespace SLMCS_ERP
{
    public partial class frmInventoryEditProduct : Form
    {
        private Product product;
        public frmInventoryEditProduct()
        {
            InitializeComponent();
        }

        public frmInventoryEditProduct(string productID)
        {
            InitializeComponent();
            product = new Product(productID);
        }

        private void FrmInventoryEditProduct_Load(object sender, EventArgs e)
        {
            lblProductIDData.Text = product.ProductID;
            cboProductType.Text = product.ProductType;
            txtProductName.Text = product.ProductName;
            rtbProductDesc.Text = product.ProductDescription;
            cboProductUnit.Text = product.ProductUnit;
            txtProductPrice.Text = product.ProductPrice.ToString();
            txtActualQty.Text = product.ActualQuantity.ToString();
            txtReorderLevel.Text = product.ReorderLevel.ToString();
            txtDangerLevel.Text = product.DangerLevel.ToString();

            cboProductType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProductUnit.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void productTypeList(string productTypeInputValue)
        {
            switch (productTypeInputValue)
            {
                case "item":
                    cboProductType.SelectedIndex = 0;
                    break;
                case "piece":
                    cboProductType.SelectedIndex = 1;
                    break;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            product.UpdateProductDetail(lblProductIDData.Text, cboProductType.Text, txtProductName.Text, rtbProductDesc.Text, cboProductUnit.Text, txtProductPrice.Text, txtActualQty.Text, txtReorderLevel.Text, txtDangerLevel.Text);
            string successfulMessage = "Product ID:" + lblProductIDData.Text + " has been updated";
            MessageBox.Show(successfulMessage);
            this.Close();
        }
    }
}

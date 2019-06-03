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
    public partial class frmInventoryAddReorderProduct : Form
    {
        private Product product;
        //private ReorderOrder reorderOrder;
        frmInventoryReorderProduct inventoryReorderProduct;
        public frmInventoryAddReorderProduct()
        {
            InitializeComponent();
            product = new Product();
        }

        public frmInventoryAddReorderProduct(frmInventoryReorderProduct from ,string productID)
        {
            InitializeComponent();
            product = new Product(productID);
            //reorderOrder = new ReorderOrder();
            inventoryReorderProduct = from;
        }

        private void FrmInventoryAddReorderProduct_Load(object sender, EventArgs e)
        {
            txtProductName.Enabled = false;
            rtbProductDesc.Enabled = false;
            cboProductUnit.Enabled = false;
            txtProductPrice.Enabled = false;
            txtActualQty.Enabled = false;

            lblProductIDData.Text = product.ProductID;
            lblProductTypeData.Text = product.ProductType;
            txtProductName.Text = product.ProductName;
            rtbProductDesc.Text = product.ProductDescription;
            cboProductUnit.Text = product.ProductUnit;
            txtProductPrice.Text = product.ProductPrice.ToString();
            txtActualQty.Text = product.ActualQuantity.ToString();
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(txtReorderQuantity.Text);
            inventoryReorderProduct.SetDGVreorderOrder(product, quantity);
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

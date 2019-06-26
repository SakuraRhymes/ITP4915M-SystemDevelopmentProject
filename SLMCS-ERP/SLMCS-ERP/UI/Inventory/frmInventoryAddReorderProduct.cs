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
        private ReorderOrder reorderOrder;
        private Product product;
        private string productID;
        //private ReorderOrder reorderOrder;
        frmInventoryReorderProduct inventoryReorderProduct;
        public frmInventoryAddReorderProduct()
        {
            InitializeComponent();
            product = new Product();
            reorderOrder = new ReorderOrder();
        }

        public frmInventoryAddReorderProduct(frmInventoryReorderProduct from ,string productID)
        {
            InitializeComponent();
            this.productID = productID;
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
            if (txtReorderQuantity.Text != "")
            {
                if (Convert.ToInt32(txtReorderQuantity.Text) > 0)
                {
                    int quantity = Convert.ToInt32(txtReorderQuantity.Text);
                    inventoryReorderProduct.SetDGVreorderOrder(product, quantity);
                    //reorderOrder.checkProductDuplicate(productID);
                    Close(); 
                }
                else
                {
                    MessageBox.Show("Reorder quantity should be more than 0");
                }
            }
            else
            {
                MessageBox.Show("Please input reorder quantity");
            }
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtReorderQuantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtReorderQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAdd_Click(this, new EventArgs());
            }
        }
    }
}

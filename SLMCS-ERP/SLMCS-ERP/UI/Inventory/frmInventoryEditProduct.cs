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
            cboProductType.Text = "";
            txtProductName.Text = product.ProductName;
            rtbProductDesc.Text = product.ProductDescription;
            cboProductUnit.Text = product.ProductUnit;
            txtProductPrice.Text = product.ProductPrice.ToString();
            txtActualQty.Text = "";
        }
    }
}

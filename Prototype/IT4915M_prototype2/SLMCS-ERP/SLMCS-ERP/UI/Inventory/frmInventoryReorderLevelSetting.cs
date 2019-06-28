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
    public partial class frmInventoryReorderLevelSetting : Form
    {
        private Product product;
        public frmInventoryReorderLevelSetting()
        {
            InitializeComponent();
        }

        public frmInventoryReorderLevelSetting(string productID)
        {
            InitializeComponent();
            product = new Product(productID);
            lblProdcutIDData.Text = product.ProductID;
            lblProductNameData.Text = product.ProductName;
            txtReorderLevel.Text = product.ReorderLevel.ToString();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            product.UpdateReorderLevelQuantity(txtReorderLevel.Text);
            string successfulMessage = "Product ID:" + product.ProductID + " has been updated";
            MessageBox.Show(successfulMessage);
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtReorderLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSubmit_Click(this, new EventArgs());
            }
        }
    }
}

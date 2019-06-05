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
    public partial class frmInventoryDangerLevelSetting : Form
    {
        private Product product;
        public frmInventoryDangerLevelSetting()
        {
            InitializeComponent();
        }

        public frmInventoryDangerLevelSetting(string productID)
        {
            InitializeComponent();
            product = new Product(productID);
            lblProdcutIDData.Text = product.ProductID;
            lblProductNameData.Text = product.ProductName;
            txtDangerLevel.Text = product.ReorderLevel.ToString();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            product.UpdateDangerLevelQuantity(txtDangerLevel.Text);
            string successfulMessage = "Product ID:" + product.ProductID + " has been updated";
            MessageBox.Show(successfulMessage);
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

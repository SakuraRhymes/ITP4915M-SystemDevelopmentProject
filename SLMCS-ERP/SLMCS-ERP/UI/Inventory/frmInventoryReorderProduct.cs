using System;
using System.Windows.Forms;
using SLMCS_Class;

namespace SLMCS_ERP
{
    public partial class frmInventoryReorderProduct : Form
    {
        private Product product;
        public frmInventoryReorderProduct()
        {
            InitializeComponent();
            product = new Product();
        }

        private void BtnReorderLevel_Click(object sender, EventArgs e)
        {
            dgvSearchRecord.DataSource = product.GetProdcutReorderLevelTable();
        }

        private void BtnDangerLevel_Click(object sender, EventArgs e)
        {
            dgvSearchRecord.DataSource = product.GetProdcutDangerLevelTable();
        }
    }
}

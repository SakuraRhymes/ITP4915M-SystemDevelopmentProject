using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SLMCS_Class;
using System.Data;

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

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
//            Product product1 = new Product("A00000");
//            Product product2 = new Product("A00002");
//            Product product3 = new Product("A00009");
//            Staff staff = new Staff("S19002708");
//            
//            ReorderOrder reorderOrder = new ReorderOrder();
//            
//            reorderOrder.AddReorderOrderLine(product1,2);
//            reorderOrder.AddReorderOrderLine(product2,5);
//            reorderOrder.AddReorderOrderLine(product3,7);
//            
//            
//            reorderOrder.PlaceReorderOrder(staff,DateTime.Today);
//            staff.AddReorderOrder(reorderOrder);
        }

        private void FrmInventoryReorderProduct_Load(object sender, EventArgs e)
        {

        }
    }
}

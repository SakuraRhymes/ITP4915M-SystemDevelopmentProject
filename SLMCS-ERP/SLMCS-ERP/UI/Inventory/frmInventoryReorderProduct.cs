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
        private string selectedProductID;
        private ReorderOrder reorderOrder;
        private ReorderOrderLine reorderOrderLine;
        public frmInventoryReorderProduct()
        {
            InitializeComponent();
            product = new Product();
            reorderOrder = new ReorderOrder();
            selectedProductID = "";
        }

        private void BtnReorderLevel_Click(object sender, EventArgs e)
        {
            dgvSearchRecord.DataSource = product.GetProdcutReorderLevelTable();
            //dgvSearchRecord.Rows[0].Selected = true;
        }

        private void BtnDangerLevel_Click(object sender, EventArgs e)
        {
            dgvSearchRecord.DataSource = product.GetProdcutDangerLevelTable();
            //dgvSearchRecord.Rows[0].Selected = true;

        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
//            Product product1 = new Product("A00000");
//            Product product2 = new Product("A00002");
//            Product product3 = new Product("A00009");
              Staff staff = new Staff("S19002708");
//            
//            ReorderOrder reorderOrder = new ReorderOrder();
//            
//            reorderOrder.AddReorderOrderLine(product1,2);
//            reorderOrder.AddReorderOrderLine(product2,5);
//            reorderOrder.AddReorderOrderLine(product3,7);
//            
//            
              reorderOrder.PlaceReorderOrder(staff,DateTime.Today.ToString("yyyy-MM-dd"));
              //staff.AddReorderOrder(reorderOrder);
        }

        private void FrmInventoryReorderProduct_Load(object sender, EventArgs e)
        {
            dgvReorderOrder.AllowUserToAddRows = false;
            dgvReorderOrder.RowHeadersVisible = false;
            dgvReorderOrder.ReadOnly = true;
            
            dgvSearchRecord.AllowUserToAddRows = false;
            dgvSearchRecord.RowHeadersVisible = false;
            dgvSearchRecord.ReadOnly = true;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (cboCondition.Text != "" && txtCondition.Text != "")
            {
                string condition = "WHERE " + cboCondition.Text + " LIKE '%" + txtCondition.Text + "%'";
                //MessageBox.Show(condition);
                dgvSearchRecord.DataSource = product.GetProdcutTable(condition);
            } else
            {
                MessageBox.Show("Please input and select condition");
            }
        }

        private void DgvSearchRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedProductID = dgvSearchRecord.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
            MessageBox.Show(selectedProductID);

            int quantity = 10;
            Product product = new Product(selectedProductID);
            reorderOrder.AddReorderProductLine(product, quantity);
    

            dgvReorderOrder.DataSource = null;
            dgvReorderOrder.DataSource = reorderOrder.GetReorderProductLine();
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

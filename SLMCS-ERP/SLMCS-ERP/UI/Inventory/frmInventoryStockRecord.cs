using System;
using System.Windows.Forms;
using SLMCS_Class;

namespace SLMCS_ERP
{
    public partial class frmInventoryStockRecord : Form
    {
        string selectedProductID = "";
        public frmInventoryStockRecord()
        {
            InitializeComponent();
        }

        private void FrmInventoryStockRecord_Load(object sender, EventArgs e)
        {
            dgvStockRecord.ReadOnly = true;
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            //if (txtProductID.Text != "")
            //{
            //    dgvStockRecord.DataSource = product.GetProdcutTable("WHERE ProductID LIKE '" + txtProductID.Text + "%'");
            //}
            //if (cboProductType.Text !="")
            //{
            //    dgvStockRecord.DataSource = product.GetProdcutTable("WHERE ProductType = '" + cboProductType.Text + "'");
            //}
            //if (txtProductName.Text != "")
            //{
            //    dgvStockRecord.DataSource = product.GetProdcutTable("WHERE ProductName LIKE '" + txtProductName.Text + "%'");
            //}
            
            dgvStockRecord.DataSource = product.GetProdcutTable("");



            //DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();

            //chk.HeaderText = "";
            //chk.Name = "chk";
            //dgvStockRecord.Columns.Add(chk);
            //dgvStockRecord.Columns["chk"].DisplayIndex = 0;
            selectedProductID = dgvStockRecord.Rows[0].Cells["ProductID"].Value.ToString();
        }

        private void BtnNewProduct_Click(object sender, EventArgs e)
        {
            frmInventoryNewProduct inventoryNewProduct = new frmInventoryNewProduct();
            inventoryNewProduct.Show();
        }


        private void BtnEditProduct_Click(object sender, EventArgs e)
        {
            if (selectedProductID == "")
            {
                MessageBox.Show("Please select product");
            } else
            {
                frmInventoryEditProduct inventoryEditProduct = new frmInventoryEditProduct(selectedProductID);
                inventoryEditProduct.Show();
            }
            
        }

        private void DgvStockRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedProductID = dgvStockRecord.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}

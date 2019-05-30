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
            dgvStockRecord.AllowUserToAddRows = false;
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

            dgvStockRecord.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStockRecord.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStockRecord.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStockRecord.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStockRecord.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStockRecord.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStockRecord.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStockRecord.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
                MessageBox.Show("Please select a product");
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

        private void DgvStockRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmInventoryEditProduct inventoryEditProduct = new frmInventoryEditProduct(selectedProductID);
            inventoryEditProduct.Show();
        }
    }
}

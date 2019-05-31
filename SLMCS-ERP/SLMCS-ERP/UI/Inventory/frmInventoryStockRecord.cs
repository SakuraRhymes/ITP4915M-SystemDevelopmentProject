using System;
using System.Windows.Forms;
using SLMCS_Class;
using System.Linq;

namespace SLMCS_ERP
{
    public partial class frmInventoryStockRecord : Form
    {
        string selectedProductID = "";
        Product product;
        public frmInventoryStockRecord()
        {
            InitializeComponent();
            dgvStockRecord.AllowUserToAddRows = false;
            dgvStockRecord.RowHeadersVisible = false;
            dgvStockRecord.ReadOnly = true;
            product = new Product();
        }

        private void FrmInventoryStockRecord_Load(object sender, EventArgs e)
        {
           
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string queryString = "";
            if (txtProductID.Text != "")
            {
//                dgvStockRecord.DataSource = product.GetProdcutTable("WHERE ProductID LIKE '" + txtProductID.Text + "%'");
                queryString += "ProductID LIKE '" + txtProductID.Text + "%'" + "/";
            }
            if (cboProductType.Text !="")
            {
//                dgvStockRecord.DataSource = product.GetProdcutTable("WHERE ProductType = '" + cboProductType.Text + "'");
                queryString += "ProductType = '" + cboProductType.Text + "' " + "/";
            }
            if (txtProductName.Text != "")
            {
//                dgvStockRecord.DataSource = product.GetProdcutTable("WHERE ProductName LIKE '" + txtProductName.Text + "%'");
                queryString += "ProductName LIKE '" + txtProductName.Text + "%' " + "/";
            }

            //DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();

            //chk.HeaderText = "";
            //chk.Name = "chk";
            //dgvStockRecord.Columns.Add(chk);
            //dgvStockRecord.Columns["chk"].DisplayIndex = 0;
            
            //string theString = "Some Very Large String Here";
            //string firstElem = array.First();
            //MessageBox.Show(lastElem.ToString());
            var queryArray = queryString.Split('/');
            queryArray = queryArray.Take(queryArray.Count() - 1).ToArray();
            string restOfqueryArray = string.Join(" AND ", queryArray);
            string finalQuery = "WHERE " + restOfqueryArray;
            //MessageBox.Show(finalQuery);
            if (restOfqueryArray == "")
            {
                finalQuery = "";
            }
            dgvStockRecord.DataSource = product.GetProdcutTable(finalQuery);
            selectedProductID = dgvStockRecord.Rows[0].Cells["ProductID"].Value.ToString();
            DGVSearchFormatSetting();
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
                OpenEditProductForm(selectedProductID);
            }
            
        }

        private void DgvStockRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedProductID = dgvStockRecord.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                dgvStockRecord.Rows[e.RowIndex].Selected = true;
            }
        }

        private void DgvStockRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenEditProductForm(selectedProductID);
            dgvStockRecord.Rows[e.RowIndex].Selected = true;
        }

        private void OpenEditProductForm(string selectedProductID)
        {
            frmInventoryEditProduct inventoryEditProduct = new frmInventoryEditProduct(selectedProductID);
            inventoryEditProduct.Show();
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (selectedProductID == "")
            {
                MessageBox.Show("Please select a product");
            }
            else
            {
                Product currentProduct = new Product(selectedProductID);
                if (MessageBox.Show("Delete?\n\tProduct ID :" + selectedProductID + "\n\tName :" + currentProduct.ProductName, "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //delete product
                
                    currentProduct.DeleteProduct(selectedProductID);
                    RefreshSearchResult(sender, e);
                }
            }
        }

        private void RefreshSearchResult(object sender, EventArgs e)
        {
            BtnSearch_Click(sender, e);
        }

        private void DGVSearchFormatSetting()
        {
            dgvStockRecord.Rows[0].Selected = true;

            dgvStockRecord.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStockRecord.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStockRecord.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStockRecord.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStockRecord.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStockRecord.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStockRecord.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStockRecord.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}

using System;
using System.Windows.Forms;
using SLMCS_Class;


namespace SLMCS_ERP
{
    public partial class frmInventoryStockRecord : Form
    {
        string selectedProductID = "";
        Product product;
        public frmInventoryStockRecord()
        {
            InitializeComponent();
            product = new Product();
        }

        private void FrmInventoryStockRecord_Load(object sender, EventArgs e)
        {
            dgvStockRecord.AllowUserToAddRows = false;
            dgvStockRecord.RowHeadersVisible = false;
            dgvStockRecord.ReadOnly = true;
            //cboProductType.DropDownStyle = ComboBoxStyle.DropDownList;
            //cboProductPrice.DropDownStyle = ComboBoxStyle.DropDownList;
            //cboStockQuantity.DropDownStyle = ComboBoxStyle.DropDownList;
            lblDProductIDData.Text = "---";
            lblDProductTypeData.Text = "---";
            lblDProductNameData.Text = "---";
            lblDProductDescData.Text = "---";
            lblDProductUnitData.Text = "---";
            lblDProductPriceData.Text = "---";
            lblDActualQtyData.Text = "---";
            lblDReorderLevelData.Text = "---";
            lblDDangerLevelData.Text = "---";
            lblDProductStatus.Text = "---";
            lblDVendorIDData.Text = "---";

            btnReorderLevel.Enabled = false;
            btnDangerLevel.Enabled = false;
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string queryString = ProductMultiSearchString();
            dgvStockRecord.DataSource = product.GetProdcutRecordTable(queryString);
            DGVSearchFormatSetting();
        }

        private void DgvStockRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedProductID = dgvStockRecord.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                dgvStockRecord.Rows[e.RowIndex].Selected = true;
                product = new Product(selectedProductID);

                lblDProductIDData.Text = product.ProductID;
                lblDProductTypeData.Text = product.ProductType;
                lblDProductNameData.Text = product.ProductName;
                lblDProductDescData.Text = product.ProductDescription;
                lblDProductUnitData.Text = product.ProductUnit;
                lblDProductPriceData.Text = product.ProductPrice.ToString();
                lblDActualQtyData.Text = product.ActualQuantity.ToString();
                lblDReorderLevelData.Text = product.ReorderLevel.ToString();
                lblDDangerLevelData.Text = product.DangerLevel.ToString();
                lblDProductStatus.Text = product.ProductStatus;
                lblDVendorIDData.Text = product.VendorID;

                btnReorderLevel.Enabled = true;
                btnDangerLevel.Enabled = true;
            }
        }

        private void RefreshSearchResult(object sender, EventArgs e)
        {
            BtnSearch_Click(sender, e);
        }

        private string ProductMultiSearchString()
        {
            string queryString = "";
            if (txtProductID.Text != "")
            {
                queryString += "ProductID LIKE '%" + txtProductID.Text + "%'" + " AND ";
            }
            if (cboProductType.Text != "")
            {
                queryString += "ProductType LIKE '%" + cboProductType.Text + "%' " + " AND ";
            }
            if (cboProductUnit.Text != "")
            {
                queryString += "ProductUnit LIKE '%" + cboProductUnit.Text + "%' " + " AND ";
            }
            if (txtProductName.Text != "")
            {
                queryString += "ProductName LIKE '%" + txtProductName.Text + "%' " + " AND ";
            }
            if (txtVendorID.Text != "")
            {
                queryString += "VendorID LIKE '%" + txtVendorID.Text + "%'" + " AND ";
            }
            if (cboStockQuantity.Text != "" && txtStockQuantity.Text != "")
            {
                switch (cboStockQuantity.Text)
                {
                    case ">":
                        queryString += "ActualQuantity > " + txtStockQuantity.Text + " AND ";
                        break;
                    case ">=":
                        queryString += "ActualQuantity >= " + txtStockQuantity.Text + "AND ";
                        break;
                    case "<":
                        queryString += "ActualQuantity < " + txtStockQuantity.Text + " AND ";
                        break;
                    case "<=":
                        queryString += "ActualQuantity <= " + txtStockQuantity.Text + " AND ";
                        break;
                    case "=":
                        queryString += "ActualQuantity = " + txtStockQuantity.Text + " AND ";
                        break;
                }
            }
            if (cboProductPrice.Text != "" && txtProductPrice.Text != "")
            {
                switch (cboProductPrice.Text)
                {
                    case ">":
                        queryString += "ProductPrice > " + txtProductPrice.Text + " AND ";
                        break;
                    case ">=":
                        queryString += "ProductPrice >= " + txtProductPrice.Text + " AND ";
                        break;
                    case "<":
                        queryString += "ProductPrice < " + txtProductPrice.Text + " AND ";
                        break;
                    case "<=":
                        queryString += "ProductPrice <= " + txtProductPrice.Text + " AND ";
                        break;
                    case "=":
                        queryString += "ProductPrice = " + txtProductPrice.Text + " AND ";
                        break;
                }
            }
            if (cboProductStatus.Text != "")
            {
                queryString += "ProductStatus LIKE '%" + cboProductStatus.Text + "%' " + " AND ";
            }
            if (queryString != "")
            {
                queryString = queryString.Remove(queryString.Length - 5);
            }

            return queryString;
        }

        private void DGVSearchFormatSetting()
        {
            //dgvStockRecord.Rows[0].Selected = true;

            dgvStockRecord.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStockRecord.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStockRecord.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStockRecord.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStockRecord.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStockRecord.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void BtnReorderLevel_Click(object sender, EventArgs e)
        {
            if (selectedProductID == "")
            {
                MessageBox.Show("Please select a product");
            }
            else
            {
                frmInventoryReorderLevelSetting inventoryReorderLevelSetting = new frmInventoryReorderLevelSetting(selectedProductID);
                inventoryReorderLevelSetting.Show();
            }
        }

        private void BtnDangerLevel_Click(object sender, EventArgs e)
        {
            if (selectedProductID == "")
            {
                MessageBox.Show("Please select a product");
            }
            else
            {
                frmInventoryDangerLevelSetting inventoryDangerLevelSetting = new frmInventoryDangerLevelSetting(selectedProductID);
                inventoryDangerLevelSetting.Show();
            }
        }
    }
}

using System;
using SLMCS_Class;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLMCS_ERP.UI.Management
{
    public partial class frmProductManagement : Form
    {
        string selectedProductID = "";
        Product product;
        public frmProductManagement()
        {
            InitializeComponent();
            product = new Product();
        }
        private void FrmProductManagement_Load(object sender, EventArgs e)
        {
            dgvStockRecord.AllowUserToAddRows = false;
            dgvStockRecord.RowHeadersVisible = false;
            dgvStockRecord.ReadOnly = true;
            //cboProductType.DropDownStyle = ComboBoxStyle.DropDownList;
            //cboProductPrice.DropDownStyle = ComboBoxStyle.DropDownList;
            //cboStockQuantity.DropDownStyle = ComboBoxStyle.DropDownList;
            lblDProductIDData.Text = "";
            lblDProductTypeData.Text = "";
            lblDProductNameData.Text = "";
            lblDProductDescData.Text = "";
            lblDProductUnitData.Text = "";
            lblDProductPriceData.Text = "";
            lblDActualQtyData.Text = "";
            lblDReorderLevelData.Text = "";
            lblDDangerLevelData.Text = "";
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string queryString = ProductMultiSearchString();
            dgvStockRecord.DataSource = product.GetProdcutRecordTable(queryString);
            DGVSearchFormatSetting();
        }

        private void BtnNewProduct_Click(object sender, EventArgs e)
        {
            frmProductManagement_NewProduct productManagement_NewProduct = new frmProductManagement_NewProduct();
            productManagement_NewProduct.Show();
        }


        private void BtnEditProduct_Click(object sender, EventArgs e)
        {
            OpenEditProductForm();
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
                lblProductStatus.Text = product.ProductStatus.ToString();
            }
        }

        private void DgvStockRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedProductID != "")
            {
                OpenEditProductForm();
                dgvStockRecord.Rows[e.RowIndex].Selected = true;
            }
        }

        private void OpenEditProductForm()
        {
            if (selectedProductID != "")
            {
                frmProductManagement_EditProduct productManagement_EditProduct = new frmProductManagement_EditProduct(selectedProductID);
                productManagement_EditProduct.Show();
            }
            else
            {
                MessageBox.Show("Please select a product");
            }
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

            dgvStockRecord.DataSource = product.GetProdcutRecordTable("");
            DGVSearchFormatSetting();
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
                        queryString += "ActualQuantity >= " + txtStockQuantity.Text + " AND ";
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

        private void BtnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            BtnSearch_Click(sender, e);
        }
    }
}
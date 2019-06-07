using SLMCS_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLMCS_ERP.UI.Sales
{
    public partial class frmBrowseProduct : Form
    {
        private Product product;
        private SalesOrder salesOrder;
        private DataGridViewCellEventArgs cellEvent;
        frmNewSalesOrder newSalesOrderPage;
        private string selectedProductID;
        private string addedProductID;

        public frmBrowseProduct(frmNewSalesOrder newSalesOrderPage, SalesOrder salesOrder)
        {
            InitializeComponent();
            this.newSalesOrderPage = newSalesOrderPage;
            this.salesOrder = salesOrder;
            product = new Product();
            startUp();
        }

        private void startUp()
        {
            selectedProductID = "";

            dgvSearchRecord.AllowUserToAddRows = false;
            dgvSearchRecord.RowHeadersVisible = false;
            dgvSearchRecord.ReadOnly = true;
            dgvSearchRecord.AllowUserToResizeRows = false;
            dgvSearchRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            cboCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCondition.Text = "ProductID";

            dgvSearchRecord.DataSource = null;
            searchProduct();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            searchProduct();
        }

        private void searchProduct()
        {
            string condition = "";
            if (txtCondition.Text != "")
            {
                condition = "Product." + cboCondition.Text + " LIKE '%" + txtCondition.Text + "%'";
                //MessageBox.Show(condition);

            }
            //MessageBox.Show(condition);
            dgvSearchRecord.DataSource = product.GetProductDetailForSalesOrderBrowseProduct(condition);
            DGVSearchRecordFormatSetting();
        }

        private void DGVSearchRecordFormatSetting()
        {
            dgvSearchRecord.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchRecord.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchRecord.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSearchRecord.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchRecord.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchRecord.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchRecord.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private String[] getSelectProductDetail(DataGridViewCellEventArgs e)
        {
            string prodcutID = dgvSearchRecord.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
            string productName = dgvSearchRecord.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
            string productType = dgvSearchRecord.Rows[e.RowIndex].Cells["ProductType"].Value.ToString();
            string productUnit = dgvSearchRecord.Rows[e.RowIndex].Cells["ProductUnit"].Value.ToString();
            string productPrice = dgvSearchRecord.Rows[e.RowIndex].Cells["ProductPrice"].Value.ToString();
            string saleableQuantity = dgvSearchRecord.Rows[e.RowIndex].Cells["SaleableQuantity"].Value.ToString();

            String[] productDetail = {prodcutID, productName, productType, productUnit, productPrice , saleableQuantity };

            return productDetail;
        }

        private void DgvSearchRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cellEvent = e;
        }

        private void DgvSearchRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAddProduct addProductPage = new frmAddProduct(newSalesOrderPage, getSelectProductDetail(e), salesOrder);
            addProductPage.Show();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            if(cellEvent != null)
            {
                DgvSearchRecord_CellDoubleClick(this, cellEvent);
            }
            else
            {
                MessageBox.Show("Please Select A Product!");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

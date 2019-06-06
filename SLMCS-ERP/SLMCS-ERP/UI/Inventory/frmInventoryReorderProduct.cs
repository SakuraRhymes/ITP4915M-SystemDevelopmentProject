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
        private string addedProductID;
        private ReorderOrder reorderOrder;
        private ReorderOrderLine reorderOrderLine;
        private string staffID;
        public frmInventoryReorderProduct()
        {
            InitializeComponent();
            staffID = frmMain.CurrentStaff.StaffID;
        }

        private void BtnReorderLevel_Click(object sender, EventArgs e)
        {
            dgvSearchRecord.DataSource = product.GetProdcutReorderLevelTable();
            DGVSearchRecordDangerReorderFormatSetting();
        }

        private void BtnDangerLevel_Click(object sender, EventArgs e)
        {
            dgvSearchRecord.DataSource = product.GetProdcutDangerLevelTable();
            DGVSearchRecordDangerReorderFormatSetting();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            

            if (selectedProductID == "")
            {
                MessageBox.Show("Please select product first");
            }
            else
            {
                if (dgvReorderOrder.Rows.Count != 0)
                {
                    if (MessageBox.Show("Confirm Order?", "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        Staff staff = new Staff(staffID);
                        reorderOrder.PlaceReorderOrder(staff, DateTime.Today.ToString("yyyy-MM-dd"));
                        FrmInventoryReorderProduct_Load(sender, e);
                        MessageBox.Show("Order has been complete");
                    }
                }
                else
                {
                    MessageBox.Show("No product at the order");
                }
            }
        }

        private void FrmInventoryReorderProduct_Load(object sender, EventArgs e)
        {
            product = new Product();
            reorderOrder = new ReorderOrder();
            selectedProductID = "";

            dgvReorderOrder.AllowUserToAddRows = false;
            dgvReorderOrder.RowHeadersVisible = false;
            dgvReorderOrder.ReadOnly = true;
            dgvReorderOrder.AllowUserToResizeRows = false;
            dgvReorderOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvSearchRecord.AllowUserToAddRows = false;
            dgvSearchRecord.RowHeadersVisible = false;
            dgvSearchRecord.ReadOnly = true;
            dgvSearchRecord.AllowUserToResizeRows = false;
            dgvSearchRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblReorderOrderID.Text = "Reorder Order ID : " + reorderOrder.GetNextReorderOrderID();
            cboCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCondition.Text = "ProductID";

            dgvSearchRecord.DataSource = null;
            dgvReorderOrder.DataSource = null;


        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string condition = "";
            if (txtCondition.Text != "")
            {
                condition = " WHERE " + cboCondition.Text + " LIKE '%" + txtCondition.Text + "%'";
                //MessageBox.Show(condition);
                
            }
            //MessageBox.Show("Please input and select condition");
            //MessageBox.Show(condition);
            dgvSearchRecord.DataSource = product.GetReorderProductTable(condition);
            DGVSearchRecordFormatSetting();
        }

        private void DgvSearchRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmInventoryAddReorderProduct inventoryAddReorderProduct = new frmInventoryAddReorderProduct(this, selectedProductID);
            inventoryAddReorderProduct.Show();     
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FrmInventoryReorderProduct_Load(sender, e);
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            if (selectedProductID == "")
            {
                MessageBox.Show("Please select product first");
            }
            else
            {
                frmInventoryAddReorderProduct inventoryAddReorderProduct = new frmInventoryAddReorderProduct(this, selectedProductID);
                inventoryAddReorderProduct.Show();
            }
            
        }

        public void SetDGVreorderOrder(Product product, int quantity)
        {
            reorderOrder.AddReorderProductLine(product, quantity);
            dgvReorderOrder.DataSource = null;
            dgvReorderOrder.DataSource = reorderOrder.GetReorderProductLine();
        }

        private void DgvSearchRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedProductID = dgvSearchRecord.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
            }
        }

        private void DgvReorderOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                addedProductID = dgvReorderOrder.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                // testing
            }
        }

        private void DGVSearchRecordFormatSetting()
        {
            dgvSearchRecord.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchRecord.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchRecord.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchRecord.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchRecord.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchRecord.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchRecord.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchRecord.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void DGVSearchRecordDangerReorderFormatSetting()
        {
            dgvSearchRecord.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchRecord.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchRecord.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchRecord.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchRecord.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchRecord.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchRecord.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}

using SLMCS_Class;
using System;
using System.Data;
using System.Windows.Forms;

namespace SLMCS_ERP.UI.Sales
{
    public partial class frmNewSalesOrder : Form
    {
        private SalesOrder salesOrder;

        private string notAvailableMessage;

        public frmNewSalesOrder()
        {
            InitializeComponent();
            startUp();
        }

        private void startUp()
        {
            salesOrder = new SalesOrder();
            salesOrder.StaffID = frmMain.CurrentStaff.StaffID;
            notAvailableMessage = "Not available";

            txtDealerID.Focus();

            lblOrderID.Text = salesOrder.SalesOrderID;
            lblOrderDate.Text = salesOrder.SalesOrderDate;
            lblStaffID.Text = salesOrder.StaffID;

            txtDealerID.Text = "";
            txtOrderQunatity.Text = "";
            txtSearchForProduct.Text = "";
            btnAddItem.Enabled = false;
            dgvOrderItem.Enabled = false;

            dgvOrderItem.AllowUserToAddRows = false;
            dgvOrderItem.RowHeadersVisible = false;
            dgvOrderItem.ReadOnly = true;
            dgvOrderItem.AllowUserToResizeRows = false;
            dgvOrderItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            updateDGV();
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            if (txtSearchForProduct.Text != "" && txtOrderQunatity.Text != "" && Convert.ToInt32(txtOrderQunatity.Text) > 0)
            {
                if (Convert.ToInt32(txtOrderQunatity.Text) <= Convert.ToInt32(lblProductAvailability.Text))
                {

                    string productID = txtSearchForProduct.Text;
                    int quantity = Convert.ToInt32(txtOrderQunatity.Text);
                    Product product = new Product(productID);

                    salesOrder.addProduct(product, quantity);

                    updateDGV();

                    txtSearchForProduct.Text = "";
                    txtOrderQunatity.Text = "";
                    lblTotalAmount.Text = salesOrder.getTotalPrice().ToString();

                    btnPlaceOrder.Enabled = true;
                    btnReserveOrder.Enabled = true;
                }
                else
                {
                    MessageBox.Show("The Product Do Not Have Enough Stock!");
                }
            } else
            {
                if (lblProductAvailability.Text == "Not available")
                {
                    MessageBox.Show("Please Input Product ID");
                }
                else if (txtOrderQunatity.Text != "")
                {
                    //if (Convert.ToInt32(txtOrderQunatity.Text) <= 0)
                        MessageBox.Show("Quantity Should Be More Than 0");
                }
                else
                {
                    MessageBox.Show("Please Input Quantity");
                }
            }
        }

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            if(txtDealerID.Text == "")
            {
                MessageBox.Show("Please Enter Dealer ID!");
            }
            else
            {
                if (MessageBox.Show("Confirm Order?", "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    salesOrder.placeOrder("Processing");
                    startUp();
                    MessageBox.Show("Place Order Successfully");
                }
            }
        }

        private void BtnReserveOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Reserve Order?", "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                salesOrder.placeOrder("Reserved");
                startUp();
                MessageBox.Show("Place Reserve Order Successfully");
            } 
        }

        private void TxtDealerID_TextChanged(object sender, EventArgs e)
        {
            if (txtDealerID.Text.Length == 8)
            {
                String[] reslut = salesOrder.updataDealerInfo((txtDealerID.Text).ToUpper());
                if(reslut != null)
                {
                    lblDealerName.Text = reslut[0];
                    lblDealerAddress.Text = reslut[1];
                    btnAddItem.Enabled = true;
                }
                if (dgvOrderItem.Rows.Count > 0)
                {
                    btnPlaceOrder.Enabled = true;
                }
            }
            else
            {
                lblDealerName.Text = lblDealerAddress.Text = notAvailableMessage;
                btnAddItem.Enabled = false;
                btnPlaceOrder.Enabled = false;
            }   
        }

        private void TxtSearchForProduct_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchForProduct.Text.Length == 6)
            {
                String[] reslut = salesOrder.updataProductInfo(txtSearchForProduct.Text);
                if (reslut != null)
                {
                    lblProductName.Text = reslut[0];
                    lblProductAvailability.Text = reslut[1];
                }
            }
            else
            {
                lblProductName.Text = lblProductAvailability.Text = notAvailableMessage;
            }
        }


        private void BtnCancelPlaceOrder_Click(object sender, EventArgs e)
        {
            startUp();
        }

        private void updateDGV()
        {
            dgvOrderItem.DataSource = null;
            dgvOrderItem.DataSource = salesOrder._SalesOrderLine;

            dgvOrderItem.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvOrderItem.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvOrderItem.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvOrderItem.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvOrderItem.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        private void TxtOrderQunatity_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInputNumberOnly(e);
        }

        private void CheckInputNumberOnly(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }
        private void TxtSearchForProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAddItem_Click(this, new EventArgs());
            }
        }

        private void TxtOrderQunatity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAddItem_Click(this, new EventArgs());
            }
        }
    }
}

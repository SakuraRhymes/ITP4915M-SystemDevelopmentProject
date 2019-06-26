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
    public partial class frmAddProduct : Form
    {
        frmNewSalesOrder newSalesOrderPage;
        private SalesOrder salesOrder;
        public frmAddProduct(frmNewSalesOrder newSalesOrderPage, String[] productDetail, SalesOrder salesOrder)
        {
            InitializeComponent();

            this.newSalesOrderPage = newSalesOrderPage;
            this.salesOrder = salesOrder;

            lblProductID.Text = productDetail[0];
            lblProductName.Text = productDetail[1];
            lblProductType.Text = productDetail[2];
            lblProductUnit.Text = productDetail[3];
            lblProductPrice.Text = productDetail[4];
            lblAvailability.Text = productDetail[5];
        }

        private void TxtOrderAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAdd_Click(this, new EventArgs());
            }
        }

        private void TxtOrderAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        public bool checkProductDuplicate(string productID)
        {
            if (salesOrder._SalesOrderLine != null)
            {
                foreach (var orderLine in salesOrder._SalesOrderLine)
                {
                    if (orderLine.ProductID == productID)
                        return false;
                }
            }
            return true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (checkProductDuplicate(lblProductID.Text))
            {
                if (txtOrderAmount.Text != "")
                {
                    int orderAmount = Convert.ToInt32(txtOrderAmount.Text);
                    if (orderAmount <= 0)
                    {
                        MessageBox.Show("Order Quantity Should Be Greater Than 0!");
                    }
                    else
                    {

                        if (Convert.ToInt32(lblAvailability.Text) < orderAmount)
                        {
                            MessageBox.Show("The Product Do Not Have Enough Stock!");

                        }
                        else
                        {
                            string productID = lblProductID.Text;
                            int quantity = orderAmount;
                            Product product = new Product(productID);

                            salesOrder.addProduct(product, quantity);

                            newSalesOrderPage.updateAddedOrderLine();

                            BtnCancel_Click(this, e);
                            MessageBox.Show("Successfully Added Product To Sales Order!");
                            newSalesOrderPage.browseProductPage.BringToFront();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Order Quantity!");
                }
            }
            else
            {
                MessageBox.Show("Product has been selected!");
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
            newSalesOrderPage.browseProductPage.BringToFront();
        }
    }
}

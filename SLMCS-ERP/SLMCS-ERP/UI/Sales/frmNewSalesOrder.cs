using SLMCS_Class;
using System;
using System.Windows.Forms;

namespace SLMCS_ERP.UI.Sales
{
    public partial class frmNewSalesOrder : Form
    {
        public frmNewSalesOrder()
        {
            InitializeComponent();
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            string productID = txtSearchForProduct.Text;
            Product product = new Product();

            //dgvOrderItem.DataSource = product.SearchForProduct(productID);


        }
    }
}

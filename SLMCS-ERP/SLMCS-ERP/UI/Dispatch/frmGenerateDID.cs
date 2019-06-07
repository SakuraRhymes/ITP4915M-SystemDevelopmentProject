using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLMCS_Class;

namespace SLMCS_ERP.UI.Dispatch
{
    public partial class frmGenerateDID : Form
    {
        private SalesOrderLine salesOrderLine;
        public frmGenerateDID(string orderID, string productID)
        {
            salesOrderLine = new SalesOrderLine(orderID, productID);
            InitializeComponent();
        }

        private void FrmGenerateDID_Load(object sender, EventArgs e)
        {
            lblSalesOrderIDData.Text = salesOrderLine.SalesOrderID;
            lblProductIDData.Text = salesOrderLine.ProductID;
            lblQuantityData.Text = salesOrderLine.Quantity.ToString() + " " + salesOrderLine.ProductUnit;
            lblDateData.Text = DateTime.Now.ToString("yy-MM-dd");
            lblProductNameData.Text = salesOrderLine.ProductName;
        }
    }
}

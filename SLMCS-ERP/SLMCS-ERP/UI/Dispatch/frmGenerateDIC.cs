using System;
using System.Collections.Generic;
//using System.ComponentMordel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLMCS_ERP;
using SLMCS_Class;

namespace SLMCS_ERP.UI.Dispatch
{
    public partial class frmGenerateDIC : Form
    {
        private SalesOrder salesOrder;
        public frmGenerateDIC(string salesOrderID)
        {
            salesOrder = new SalesOrder(salesOrderID);
            InitializeComponent();
        }

        private void CrvDataTable_Load(object sender, EventArgs e)
        {
           
        }

        private void FrmGenerateDIC_Load(object sender, EventArgs e)
        {
            lblSalesOrderIDData.Text = salesOrder.SalesOrderID;
            lblSalesOrderDateData.Text = salesOrder.SalesOrderDate;
            lblDealerIDData.Text = salesOrder.DealerID;
            lblPrintDateData.Text = DateTime.Now.ToString("yy-MM-dd");
        }
    }
}
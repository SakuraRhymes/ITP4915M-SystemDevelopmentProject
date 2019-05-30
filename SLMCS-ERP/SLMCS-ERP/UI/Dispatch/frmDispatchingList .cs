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


namespace SLMCS_ERP{
    public partial class frmDispatchingList : Form
    {
        private SalesOrder salesOrder;
        public frmDispatchingList()
        {
            salesOrder = new SalesOrder();
            InitializeComponent();
            startUp();
        }

        private void startUp()
        {
            dgvSalesOrderList.DataSource = null;
            dgvSalesOrderList.DataSource = salesOrder.GetSalesOrderTableBySalesOrderStatus("Dispatching");
        }

        private void DataGridView2_Load(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

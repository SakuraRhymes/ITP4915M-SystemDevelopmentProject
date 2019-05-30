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
            dgvSalesOrderList.DataSource = salesOrder.getSalesOrderTableBySalesOrderStatus("Dispatching");
        }

        private void DataGridView2_Load(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void FrmDispatchingList_Load(object sender, EventArgs e)
        {

        }

        private void DgvSalesOrderList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("My message here");
        }

        private void DgvSalesOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvOrderDetail.DataSource = null;
            dgvOrderDetail.DataSource =salesOrder.getSalesOrderLineBySalesOrderID(dgvSalesOrderList.SelectedCells[0].Value.ToString());

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            dgvOrderDetail.DataSource = null;
            dgvSalesOrderList.DataSource = null;
            dgvSalesOrderList.DataSource = salesOrder.getSalesOrderTableBySalesOrderStatus("Dispatching");
        }
    }
}

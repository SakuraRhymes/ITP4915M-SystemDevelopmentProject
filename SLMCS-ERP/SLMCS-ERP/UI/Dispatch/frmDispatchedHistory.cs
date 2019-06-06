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
    public partial class frmDispatchedHistory : Form
    {
        private string selectedOrderID;
        private string generateForDID;
        private string orderIDForGenerate;
        private string selectedOrderDetail;
        private SalesOrder salesOrder;

        public frmDispatchedHistory()
        {
            salesOrder = new SalesOrder();
            InitializeComponent();
        }

        private void changeDispatchingDvgContect(DataTable table)
        {
            dgvDispatchedList.DataSource = null;
            dgvDispatchedList.DataSource = table;
        }

        private void refreshDvg()
        {
            changeDispatchingDvgContect(salesOrder.getSalesOrderTableBySalesOrderStatus("Dispatched"));

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            refreshDvg();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string condition = "";
            int andCount = 0;
            if (txtOrderID.Text != "")
            {
                condition += "SalesOrderID LIKE \"%" + txtOrderID.Text + "%\"";
                andCount++;
            }

            if (txtStaffID.Text != "")
            {
                if (andCount > 0)
                {
                    condition += " AND ";
                    andCount--;
                }
                condition += "StaffID LIKE \"%" + txtStaffID.Text + "%\"";
                andCount++;
            }

            if (txtOrderDate.Text != "")
            {
                if (andCount > 0)
                {
                    condition += " AND ";
                    andCount--;
                }
                condition += "DealerID LIKE \"%" + txtOrderDate.Text + "%\"";
                andCount++;
            }

            if (andCount > 0)
            {
                condition += " AND ";
                andCount--;
            }

            condition += "SalesOrderStatus = \"Dispatched\"";

            changeDispatchingDvgContect(salesOrder.getSalesTableByWhereQuery(condition));
        }
    }
}

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
    public partial class frmGoodsReceivedList : Form
    {
        ProcurementOrder procurementOrder;
        public frmGoodsReceivedList()
        {
            InitializeComponent();
            procurementOrder = new ProcurementOrder();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvGoodsRecevieList.DataSource = null;
            changeGoodsReceviedDvgContent(procurementOrder.getProcurementOrderTableByProcurementOrderStatus("Prcossing"));
        }

        private void changeGoodsReceviedDvgContent(DataTable table)
        {
            dgvGoodsRecevieList.DataSource = null;
            dgvGoodsRecevieList.DataSource = table;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string condition = "";
            int andCount = 0;
            if (txtOrderID.Text != "")
            {
                condition += "ProcurementOrderID LIKE \"%" + txtOrderID.Text + "%\"";
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

            if (txtVendorID.Text != "")
            {
                if (andCount > 0)
                {
                    condition += " AND ";
                    andCount--;
                }
                condition += "VendorID LIKE \"%" + txtVendorID.Text + "%\"";
                andCount++;
            }

            if (andCount > 0)
            {
                condition += " AND ";
                andCount--;
            }

            condition += "ProcurementOrderStatus = \"Processing\"";

            changeGoodsReceviedDvgContent(procurementOrder.getProcurementTableByWhereQuery(condition));
        }
    }
}

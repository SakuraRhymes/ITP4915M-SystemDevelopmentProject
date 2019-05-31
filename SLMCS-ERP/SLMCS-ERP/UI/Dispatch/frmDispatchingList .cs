﻿using System;
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
        private string selectedOrderID;
        private SalesOrder salesOrder;
        public frmDispatchingList()
        {
            salesOrder = new SalesOrder();
            
            InitializeComponent();
            startUp();
        }

        private void startUp()
        {
            dgvOrderDetail.DataSource = null;
            changeDispatchingDvgContect(salesOrder.getSalesOrderTableBySalesOrderStatus("Dispatching"));
        }

        private void DataGridView2_Load(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string condition = "";
            int andCount = 0;
            if (txtOrderID.Text != "")
            {
                condition += "SalesOrderID LIKE \"%"+ txtOrderID.Text+"%\"";
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
            
            if (txtDealerID.Text != "")
            {
                if (andCount > 0)
                {
                    condition += " AND ";
                    andCount--;
                }
                condition += "DealerID LIKE \"%" + txtDealerID.Text + "%\"";
                andCount++;
            }

            if (andCount > 0)
            {
                condition += " AND ";
                andCount--;
            }

            condition += "SalesOrderStatus = \"Dispatching\"";

            //System.Windows.Forms.MessageBox.Show(condition);
            changeDispatchingDvgContect(salesOrder.getSalesTableByWhereQuery(condition));

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
            if (e.RowIndex != -1)
            {
                selectedOrderID = dgvSalesOrderList.Rows[e.RowIndex].Cells["SalesOrderID"].Value.ToString();
            }
            dgvOrderDetail.DataSource = null;
            dgvOrderDetail.DataSource =salesOrder.getSalesOrderLineBySalesOrderID(dgvSalesOrderList.Rows[e.RowIndex].Cells["SalesOrderID"].Value.ToString());

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            dgvOrderDetail.DataSource = null;
            changeDispatchingDvgContect(salesOrder.getSalesOrderTableBySalesOrderStatus("Dispatching"));
        }

        private void changeDispatchingDvgContect(DataTable table)
        {
            dgvSalesOrderList.DataSource = null;
            dgvSalesOrderList.DataSource = table;
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            
        }
    }
}

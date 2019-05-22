﻿using SLMCS_ERP.UI.Sales;
using System;
using System.Windows.Forms;

namespace SLMCS_ERP
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
            frmNewSalesOrder newSalesOrder = new frmNewSalesOrder();
            navigation(newSalesOrder, panelContent);
        }
        private void navigation(Form form, Panel panel)
        {
            form.TopLevel = false;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(form);
            form.Show();
        }
        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnNewSalesOrder_Click(object sender, EventArgs e)
        {
            frmNewSalesOrder newSalesOrder = new frmNewSalesOrder();
            navigation(newSalesOrder, panelContent);
        }

        private void BtnSalesOrderRecords_Click(object sender, EventArgs e)
        {
            frmSalesOrderRecords salesOrderRecords = new frmSalesOrderRecords();
            navigation(salesOrderRecords, panelContent);
        }
    }
}
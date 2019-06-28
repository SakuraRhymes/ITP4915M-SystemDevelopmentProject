using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLMCS_ERP
{
    public partial class frmInventoryMain : Form
    {
        public frmInventoryMain()
        {
            InitializeComponent();
            frmInventoryStockRecord inventoryStockRecord = new frmInventoryStockRecord();
            navigation(inventoryStockRecord, panelContent);
        }

        private void navigation(Form form, Panel panel)
        {
            form.TopLevel = false;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void BtnStockRecord_Click(object sender, EventArgs e)
        {
            frmInventoryStockRecord inventoryStockRecord = new frmInventoryStockRecord();
            navigation(inventoryStockRecord, panelContent);
        }

        private void BtnInwardGoods_Click(object sender, EventArgs e)
        {
            frmInventoryInwardGoods inventoryInwardGoods = new frmInventoryInwardGoods();
            navigation(inventoryInwardGoods, panelContent);
        }

        private void BtnReorderProduct_Click(object sender, EventArgs e)
        {
            frmInventoryReorderProduct inventoryReorderProduct = new frmInventoryReorderProduct();
            navigation(inventoryReorderProduct, panelContent);
        }

        private void BtnInwardGoodsRecord_Click(object sender, EventArgs e)
        {
            frmInventoryInwardGoodsRecord inventoryInwardGoodsRecord = new frmInventoryInwardGoodsRecord();
            navigation(inventoryInwardGoodsRecord, panelContent);
        }
    }

    
}

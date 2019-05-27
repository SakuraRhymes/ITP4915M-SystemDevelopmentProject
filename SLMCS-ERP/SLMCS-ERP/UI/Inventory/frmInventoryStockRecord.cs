using System;
using System.Windows.Forms;
using SLMCS_Class;

namespace SLMCS_ERP
{
    public partial class frmInventoryStockRecord : Form
    {
        public frmInventoryStockRecord()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            dgvStockRecord.DataSource = product.GetProdcutTable();

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
              
            chk.HeaderText = "";
            chk.Name = "chk";
            dgvStockRecord.Columns.Add(chk);
            dgvStockRecord.Columns["chk"].DisplayIndex = 0;
        }
    }
}

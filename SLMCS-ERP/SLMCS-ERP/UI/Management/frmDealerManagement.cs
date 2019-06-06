using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SLMCS_Class;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLMCS_ERP.UI.Management
{
    public partial class frmDealerManagement : Form
    {
        public frmDealerManagement()
        {
            InitializeComponent();
            dgvDealerList.AllowUserToAddRows = false;
            dgvDealerList.RowHeadersVisible = false;
            dgvDealerList.ReadOnly = true;
            Dealer dealer = new Dealer();
        }

        
        private void DGVSearchFormatSetting()
        {
            //dgvStockRecord.Rows[0].Selected = true;

            dgvDealerList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDealerList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDealerList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDealerList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDealerList.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDealerList.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BtnSearchDealer_Click(object sender, EventArgs e)
        {

        }
    }
}

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

namespace SLMCS_ERP
{
    public partial class frmInventoryVendorRecord : Form
    {
        private Vendor vendor;
        public frmInventoryVendorRecord()
        {
            InitializeComponent();
            vendor = new Vendor();
            dgvVendorRecord.DataSource = vendor.GetVendorTable();
        }

        private void FrmInventoryVendorRecord_Load(object sender, EventArgs e)
        {
            dgvVendorRecord.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvVendorRecord.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}

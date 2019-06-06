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
    }
}

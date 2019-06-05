using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLMCS_ERP.UI.Management
{
    public partial class frmManagementMain : Form
    {
        public frmManagementMain()
        {
            InitializeComponent();
            frmProductManagement productManagement = new frmProductManagement();
            navigation(productManagement, panelContent);
        }
        private void navigation(Form form, Panel panel)
        {
            form.TopLevel = false;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void BtnProductManagement_Click(object sender, EventArgs e)
        {
            frmProductManagement productManagement = new frmProductManagement();
            navigation(productManagement, panelContent);
        }

        private void BtnStaffManagement_Click(object sender, EventArgs e)
        {

        }

        private void BtnDealerManagement_Click(object sender, EventArgs e)
        {

        }

        private void BtnVendorManagement_Click(object sender, EventArgs e)
        {

        }
    }
}

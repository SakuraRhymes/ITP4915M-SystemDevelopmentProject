using SLMCS_Class;
using SLMCS_ERP.UI.Management;
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
    public partial class frmMain : Form
    {
        public static Staff CurrentStaff { get; set; }
        frmLogin loginPage;
        public frmMain(frmLogin loginPage, Staff staff)
        {
            InitializeComponent();
            this.loginPage = loginPage;
            CurrentStaff = staff;
            lblStaffID.Text = frmMain.CurrentStaff.StaffID;
            lblStaffName.Text = frmMain.CurrentStaff.StaffName;
            frmSales sales = new frmSales();
            navigation(sales, panelContent);
        }
        private void navigation(Form form, Panel panel)
        {
            form.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }
       
        private void btnSales_Click(object sender, EventArgs e)
        {
            frmSales sales = new frmSales();
            navigation(sales, panelContent);
        }
        private void BtnInventory_Click(object sender, EventArgs e)
        {
            frmInventoryMain inventoryMain = new frmInventoryMain();
            navigation(inventoryMain, panelContent);
        }
        private void BtnDispatch_Click(object sender, EventArgs e)
        {
            frmDispatch dispatch = new frmDispatch();
            navigation(dispatch, panelContent);
        }

        private void BtnUserManagement_Click(object sender, EventArgs e)
        {
            frmManagementMain management = new frmManagementMain();
            navigation(management, panelContent);
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            frmReportMain reportMain = new frmReportMain();
            navigation(reportMain, panelContent);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginPage.Show();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginPage.Show();
        }
    }
}

using SLMCS_Class;
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
            frmHome home = new frmHome();
            navigation(home, panelContent);
        }
        private void navigation(Form form, Panel panel)
        {
            form.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            navigation(home, panelContent);
        }
        private void btnSales_Click(object sender, EventArgs e)
        {
            frmSales sales = new frmSales();
            navigation(sales, panelContent);
        }
        private void BtnProcurement_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            frmInventoryMain inventoryMain = new frmInventoryMain();
            navigation(inventoryMain, panelContent);
        }

        private void BtnFinance_Click(object sender, EventArgs e)
        {

        }

        private void BtnReporting_Click(object sender, EventArgs e)
        {

        }

        private void BtnDispatch_Click(object sender, EventArgs e)
        {
            frmDispatch dispatch = new frmDispatch();
            navigation(dispatch, panelContent);
        }

        private void BtnUserManagement_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            loginPage.Show();
            this.Hide();
        }
    }
}

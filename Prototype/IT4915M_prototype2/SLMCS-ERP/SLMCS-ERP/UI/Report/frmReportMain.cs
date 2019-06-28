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
    public partial class frmReportMain : Form
    {
        public frmReportMain()
        {
            InitializeComponent();
            frmSalesReport frmSalesReport = new frmSalesReport();
            navigation(frmSalesReport, panelContent);
        }

        private void BtnSalesReport_Click(object sender, EventArgs e)
        {
            frmSalesReport frmSalesReport = new frmSalesReport();
            navigation(frmSalesReport, panelContent);
        }

        private void BtnProductReport_Click(object sender, EventArgs e)
        {
            frmProductReport frmProductReport = new frmProductReport();
            navigation(frmProductReport, panelContent);
        }

        private void navigation(Form form, Panel panel)
        {
            form.TopLevel = false;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(form);
            form.Show();
        }

    }
}

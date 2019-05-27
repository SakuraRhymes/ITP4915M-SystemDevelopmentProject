//using SLMCS_ERP.UI.Dispatch;
using System;
using System.Windows.Forms;

namespace SLMCS_ERP
{
    public partial class frmDispatch : Form
    {
        public frmDispatch()
        {
            InitializeComponent();
        }
        private void navigation(Form form, Panel panel)
        {
            form.TopLevel = false;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }

}

using System;
using System.Windows.Forms;

namespace SLMCS_ERP
{
    public partial class frmDispatch : Form
    {
        public frmDispatch()
        {
            InitializeComponent();
            frmDispatchingList frmDispatchingList = new frmDispatchingList();
            navigation(frmDispatchingList, panelContent);
        }
        private void navigation(Form form, Panel panel)
        {
            form.TopLevel = false;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void PanelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

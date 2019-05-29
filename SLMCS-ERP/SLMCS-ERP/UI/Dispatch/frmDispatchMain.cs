using System;
using System.Windows.Forms;
using SLMCS_ERP.UI.Dispatch;

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

        private void DispatchingList_Click(object sender, EventArgs e)
        {
            frmDispatchingList dispatchList = new frmDispatchingList();
            navigation(dispatchList, panelContent);
        }

        private void GoodsReceviedList_Click(object sender, EventArgs e)
        {
            frmGoodsReceivedList goodsReceivedList = new frmGoodsReceivedList();
            navigation(goodsReceivedList, panelContent);
        }
    }
}

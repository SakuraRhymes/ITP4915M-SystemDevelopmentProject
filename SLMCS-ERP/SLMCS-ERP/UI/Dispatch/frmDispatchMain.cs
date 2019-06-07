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

        private void DispatchingList_Click(object sender, EventArgs e)
        {
            frmDispatchingList dispatchList = new frmDispatchingList();
            navigation(dispatchList, panelContent);
        }

        private void BtnDispatchedHistory_Click(object sender, EventArgs e)
        {
            frmDispatchedHistory dispatchedHistory = new frmDispatchedHistory();
            navigation(dispatchedHistory, panelContent);
        }

        private void BtnGoodsRecevie_Click(object sender, EventArgs e)
        {
            frmGoodsReceiveList goodsReceiveList = new frmGoodsReceiveList();
            navigation(goodsReceiveList, panelContent);
        }

        private void BtnGoodsReceivedHistory_Click(object sender, EventArgs e)
        {
            frmGoodsReceivedHistory goodsReceivedHistory = new frmGoodsReceivedHistory();
            navigation(goodsReceivedHistory, panelContent);
        }
    }
}

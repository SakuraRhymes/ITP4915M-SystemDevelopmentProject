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

        private void BtnDispatchOrder_Click(object sender, EventArgs e)
        {
            frmDispatchingList dispatchList = new frmDispatchingList();
            navigation(dispatchList, panelContent);
        }

        private void BtnDispatchedRecord_Click(object sender, EventArgs e)
        {
            frmDispatchedRecord dispatchedRecord = new frmDispatchedRecord();
            navigation(dispatchedRecord, panelContent);
        }

        private void BtnGoodsRecevie_Click(object sender, EventArgs e)
        {
            frmGoodsReceiveList goodsReceiveList = new frmGoodsReceiveList();
            navigation(goodsReceiveList, panelContent);
        }

        private void BtnGoodsReceivedRecord_Click(object sender, EventArgs e)
        {
            frmGoodsReceivedRecord goodsReceivedRecord = new frmGoodsReceivedRecord();
            navigation(goodsReceivedRecord, panelContent);
        }

        
    }
}

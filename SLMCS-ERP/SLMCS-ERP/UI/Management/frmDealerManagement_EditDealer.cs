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

namespace SLMCS_ERP.UI.Management
{
    public partial class frmDealerManagement_EditDealer : Form
    {
        Dealer dealer ;
        public frmDealerManagement_EditDealer()
        {
            InitializeComponent();
            txtDealerID.Enabled = false;
        }
        public frmDealerManagement_EditDealer(string dealerID)
        {
            InitializeComponent();
            txtDealerID.Enabled = false;
            dealer = new Dealer(dealerID);
            txtDealerID.Text = dealer.DealerID;
            txtDealerName.Text = dealer.DealerName;
            txtDealerPhoneNo.Text = dealer.DealerPhoneNo;
            txtDealerInvoiceAddress.Text = dealer.DealerInvoiceAddress;
            txtDealerShippingAddress.Text = dealer.DealerShippingAddress;
            ckbAvailable.Checked = (dealer.DealerStatus == "Available");
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string dealerAvailable;
            if (ckbAvailable.Checked)
            {
                dealerAvailable = "Available";
            }
            else
            {
                dealerAvailable = "Unavailable";
            }

            try
            {
                dealer.UpdateDealerDetail(txtDealerID.Text, txtDealerName.Text, txtDealerInvoiceAddress.Text, txtDealerShippingAddress.Text, txtDealerPhoneNo.Text, dealerAvailable);
                BtnReset_Click(sender, e);
                MessageBox.Show("Dealer detail has been changed");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtDealerID.Text = dealer.DealerID;
            txtDealerName.Text = dealer.DealerName;
            txtDealerPhoneNo.Text = dealer.DealerPhoneNo;
            txtDealerInvoiceAddress.Text = dealer.DealerInvoiceAddress;
            txtDealerShippingAddress.Text = dealer.DealerShippingAddress;
            ckbAvailable.Checked = (dealer.DealerStatus == "Available");
        }
    }
}


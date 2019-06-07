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
    public partial class frmDealerManagement_NewDealer : Form
    {
            Dealer dealer = new Dealer();
        public frmDealerManagement_NewDealer()
        {
            InitializeComponent();
            txtDealerID.Text = dealer.GetNextDealerID();
            txtDealerID.Enabled = false;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            
            string DealerName = txtDealerName.Text;
            string DealerPhoneNo = txtDealerPhoneNo.Text;
            string DealerInvoiceAddress = txtDealerInvoiceAddress.Text;
            string DealerShippingAddress = txtDealerShippingAddress.Text;

            string dealerStatus = (ckDealerAvailable.Checked ? "Available" : "Unvailable");
            try
            {
                if (CheckInputFieldIsValid())
                {
                    dealer.CreateNewDealer(DealerName, DealerPhoneNo, DealerInvoiceAddress, DealerShippingAddress, dealerStatus);
                    BtnReset_Click(sender, e);
                    MessageBox.Show("Dealer has been added");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool CheckInputFieldIsValid()
        {

            if (txtDealerName.Text != "" && lblDealerPhoneNo.Text != "" && txtDealerInvoiceAddress.Text != "" && txtDealerShippingAddress.Text != "")
            {
                return true;
            }
            if (txtDealerName.Text == "")
            {
                MessageBox.Show("Please input dealer name");
                return false;
            }
            if (lblDealerPhoneNo.Text == ""|| lblDealerPhoneNo.Text.Length!=11)
            {
                MessageBox.Show("Please input valid dealer phone no");
                return false;
            }
            if (txtDealerInvoiceAddress.Text == "")
            {
                MessageBox.Show("Please input dealer invoice address");
                return false;
            }
            if (txtDealerShippingAddress.Text == "")
            {
                MessageBox.Show("Please input dealer shipping address");
                return false;
            }
            return false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtDealerName.Text = "";
            lblDealerPhoneNo.Text = "";
            txtDealerInvoiceAddress.Text = "";
            txtDealerShippingAddress.Text = "";
        }
    }
}

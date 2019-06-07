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
    public partial class frmVendorManagement_NewVendor : Form
    {
        Vendor vendor = new Vendor();
        public frmVendorManagement_NewVendor()
        {
            InitializeComponent();
            txtVendorID.Text = vendor.GetNextVendorID();
            txtVendorID.Enabled = false;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {

            string vendorID = txtVendorID.Text;
            string vendorName = txtVendorName.Text;
            string vendorAddress = txtVendorAddress.Text;
            string vendorPhoneNo = txtVendorPhoneNo.Text;
            string vendorStatus = (ckVendorAvailable.Checked ? "Available" : "Unvailable");
            try
            {
                if (CheckInputFieldIsValid())
                {
                    vendor.CreateNewVendor(vendorID, vendorName, vendorAddress, vendorPhoneNo, vendorStatus);
                    BtnReset_Click(sender, e);
                    MessageBox.Show("Vendor has been added");
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

            if (txtVendorName.Text != "" && lblVendorPhoneNo.Text != "" && txtVendorAddress.Text != "" )
            {
                return true;
            }
            if (txtVendorName.Text == "")
            {
                MessageBox.Show("Please input vendor name");
                return false;
            }
            if (lblVendorPhoneNo.Text == "")
            {
                MessageBox.Show("Please input vendor phone no");
                return false;
            }
            if (txtVendorAddress.Text == "")
            {
                MessageBox.Show("Please input vendor address");
                return false;
            }
            return false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtVendorName.Text = "";
            txtVendorPhoneNo.Text = "";
            txtVendorAddress.Text = "";
        }
    }
}

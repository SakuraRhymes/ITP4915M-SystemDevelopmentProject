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

    public partial class frmVendorManagement_EditVendor : Form
    {

        Vendor vendor;
        public frmVendorManagement_EditVendor()
        {
            InitializeComponent();
            vendor = new Vendor();
        }
        public frmVendorManagement_EditVendor(string vendorID)
        {
            InitializeComponent();
            vendor = new Vendor(vendorID);
        }


        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string vendorID = txtVendorID.Text;
            string vendorName = txtVendorName.Text;
            string vendorAddress = txtVendorAddress.Text;
            string vendorPhoneNo = txtVendorPhoneNo.Text;
            string vendorStatus = (ckVendorAvailable.Checked ? "Available" : "Unvailable");

            if (CheckInputFieldIsValid())
            {
                try
                {
                    vendor.UpdateVendorDetail(vendorID, vendorName, vendorAddress, vendorPhoneNo, vendorStatus);
                    MessageBox.Show("The vendor account" + vendorID + " has been edit!");
                    this.Close();
                    //need KILL?

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtVendorName.Text = vendor.VendorName;
            txtVendorAddress.Text = vendor.VendorAddress;
            txtVendorPhoneNo.Text = vendor.VendorPhoneNo;
            ckVendorAvailable.Checked = (vendor.VendorStatus == "Available");
        }

        private void frmVendorManagement_EditVendor_Load(object sender, EventArgs e)
        {
            txtVendorID.Text = vendor.VendorID;
            BtnCancel_Click(sender, e);
            txtVendorID.Enabled = false;
        }
        private bool CheckInputFieldIsValid()
        {

            if (txtVendorName.Text != "" && txtVendorPhoneNo.Text != "" && txtVendorAddress.Text != "")
            {
                return true;
            }
            if (txtVendorName.Text == "")
            {
                MessageBox.Show("Please input vendor name");
                return false;
            }
            if (txtVendorPhoneNo.Text == "" || txtVendorPhoneNo.Text.Length != 11)
            {
                MessageBox.Show("Please input valid vendor phone no");
                return false;
            }
            if (txtVendorAddress.Text == "")
            {
                MessageBox.Show("Please input vendor address");
                return false;
            }
            return false;
        }
    }
}

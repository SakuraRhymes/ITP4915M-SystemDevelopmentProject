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

namespace SLMCS_ERP.UI.Login
{
    public partial class frmForgetPassword : Form
    {
        string result;
        public frmForgetPassword()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRetrievePassword_Click(object sender, EventArgs e)
        {
            string staffID = txtStaffID.Text;
            string staffPhone = txtPhoneNumber.Text;
            if(staffID != "" && staffPhone != "")
            {
                Staff staff = new Staff(staffID);
                result = staff.ForgetPassword(staffPhone);
                if (result != null)
                {
                    frmSMSConfirm smsConfirm = new frmSMSConfirm(this);
                    smsConfirm.Show();               
                }
                else
                {
                    MessageBox.Show("Wrong Staff Info! Please Try Again");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Your Staff Info!");
            }

        }

        private void TxtStaffID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnRetrievePassword_Click(this, new EventArgs());
            }
        }

        private void TxtPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnRetrievePassword_Click(this, new EventArgs());
            }
        }

        private void TxtStaffID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        public void ConfirmSMSSuccessful()
        {
            MessageBox.Show("Your Password is " + result);
            Close();
        }
    }
}

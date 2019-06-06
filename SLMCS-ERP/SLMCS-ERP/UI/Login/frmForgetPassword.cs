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
                string result = staff.ForgetPassword(staffPhone);
                if (result != null)
                {
                    MessageBox.Show("Your Password is " + result);
                    Close();
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
    }
}

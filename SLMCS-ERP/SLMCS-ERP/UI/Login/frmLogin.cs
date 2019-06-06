using SLMCS_Class;
using SLMCS_ERP.UI.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLMCS_ERP
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string staffID = txtStaffID.Text;
            string password = txtPassword.Text;

            try
            {
                Staff staff = new Staff(staffID);
                if(staff.Verify(password)){
                    frmMain main = new frmMain(this, staff);

                    txtStaffID.Text = "";
                    txtPassword.Text = "";

                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Password invaild! Please Try again.");
                }
            }
            catch (Exception exception)
            {
                //MessageBox.Show("Staff ID invaild! Please Try again.");
                MessageBox.Show(exception.Message);
            }


        }

        private void BtnForgetPassword_Click(object sender, EventArgs e)
        {
            frmForgetPassword forgetPasswordPage = new frmForgetPassword();
            forgetPasswordPage.Show();
        }
    }
}

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

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtStaffID.MaxLength = 9;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string staffID = txtStaffID.Text;
            string password = txtPassword.Text;
            if (staffID != "" && password != "")
            {
                try
                {
                    Staff staff = new Staff(staffID);
                    if (staff.Verify(password))
                    {
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
            else
            {
                if (staffID == "" && password != "")
                {
                    MessageBox.Show("Staff ID is Empty! Please input your Staff ID.");
                }
                else if (staffID != "" && password == "")
                {
                    MessageBox.Show("Password is Empty! Please input your Password.");
                }
                else
                {
                    MessageBox.Show("Staff ID and Password are Empty! Please Try again.");
                }
            }
        }

        private void BtnForgetPassword_Click(object sender, EventArgs e)
        {
            frmForgetPassword forgetPasswordPage = new frmForgetPassword();
            forgetPasswordPage.Show();
        }

        private void TxtStaffID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(this, new EventArgs());
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(this, new EventArgs());
            }
        }
    }
}

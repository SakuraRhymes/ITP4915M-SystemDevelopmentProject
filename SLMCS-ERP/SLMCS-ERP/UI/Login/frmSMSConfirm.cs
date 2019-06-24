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
    public partial class frmSMSConfirm : Form
    {
        frmForgetPassword forgetPassword;
        public frmSMSConfirm(frmForgetPassword forgetPassword)
        {
            InitializeComponent();
            this.forgetPassword = forgetPassword;
        }

        private void BtnConfirmCode_Click(object sender, EventArgs e)
        {
            if(txtSMSCode.Text == "123")
            {
                Close();
                forgetPassword.ConfirmSMSSuccessful();
            }
            else
            {
                MessageBox.Show("The SMS Code is invalid!");
            }
        }
    }
}

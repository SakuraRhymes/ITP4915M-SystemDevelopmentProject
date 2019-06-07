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
    public partial class frmStaffManagement_NewStaff : Form
    {
        Staff staff;
        public frmStaffManagement_NewStaff()
        {
            InitializeComponent();
            staff = new Staff();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string staffID = txtStaffID.Text;
            string staffName = txtStaffName.Text;
            string departmentID = cbStaffDepartment.Text;
            string staffPhoneNo = txtStaffPhoneNo.Text;
            string staffPassword = txtStaffPassword.Text;
            string available = (ckAvailable.Checked? "Available": "Unvailable");

            try
            {
                if (CheckInputFieldIsValid())
                {
                    staff.CreateStaffAccount(staffID, staffPassword, staffName, staffPhoneNo, departmentID, available);
                    BtnCancel_Click(sender, e);
                    MessageBox.Show("The staff account has been created!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtStaffName.Text = "" ;
            cbStaffDepartment.Text = "HR";
            txtStaffPhoneNo.Text = "";
        }

        private bool CheckInputFieldIsValid()
        {
            if (cbStaffDepartment.Text == "")
            {
                MessageBox.Show("Please select staff department");
                return false;
            }
            if (txtStaffName.Text == "")
            {
                MessageBox.Show("Please input staff name");
                return false;
            }
            if (txtStaffPhoneNo.Text == "")
            {
                MessageBox.Show("Please input staff phone No");
                return false;
            }
            return true;
        }

        private void frmStaffManagement_NewStaff_Load(object sender, EventArgs e)
        {
            txtStaffID.Text = staff.GetNextStaffID();
            txtStaffPassword.Text = staff.RandomPassword();
            cbStaffDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            txtStaffID.Enabled = false;
            txtStaffPassword.Enabled = false;
        }
    }
}

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

    public partial class frmStaffManagement_EditStaff : Form
    {

        Staff staff;
        public frmStaffManagement_EditStaff()
        {
            InitializeComponent();
            staff = new Staff();
        }
        public frmStaffManagement_EditStaff(string staffID)
        {
            InitializeComponent();
            staff = new Staff(staffID);
        }
        

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string staffID = txtStaffID.Text;
            string staffName = txtStaffName.Text;
            string departmentID = cbStaffDepartment.Text;
            string staffPhoneNo = txtStaffPhoneNo.Text;
            string staffPassword = txtStaffPassword.Text;
            string available = (ckAvailable.Checked ? "Available" : "Unvailable");
            if (CheckInputFieldIsValid())
            {
                try
                {
                    staff.EditStaffAccountPasswordUnchanged(staffID, staffName, staffPhoneNo, departmentID, available);
                    MessageBox.Show("The staff account" + staffID + " has been edit!");
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
            txtStaffName.Text = staff.StaffName;
            cbStaffDepartment.Text = staff.DepartmentID;
            txtStaffPhoneNo.Text = staff.StaffPhoneNo;
            ckAvailable.Checked = (staff.StaffStatus== "Available");
        }

        private void frmStaffManagement_EditStaff_Load(object sender, EventArgs e)
        {
            txtStaffID.Text = staff.StaffID;
            txtStaffPassword.Text = staff.Password;
            BtnCancel_Click(sender,e);
            cbStaffDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            txtStaffID.Enabled = false;
            txtStaffPassword.Enabled = false;
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
            if (txtStaffPhoneNo.Text == "" || txtStaffPhoneNo.Text.Length != 11)
            {
                MessageBox.Show("Please input valid staff phone No");
                return false;
            }
            return true;
        }
    }

}

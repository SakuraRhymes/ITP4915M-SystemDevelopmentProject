using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLMCS_Class;

namespace SLMCS_ERP.UI.Management
{

    public partial class frmStaffManagement : Form
    {
        String selectedStaffID;
        Staff staff;
        public frmStaffManagement()
        {
            InitializeComponent();
            dgvStaffList.AllowUserToAddRows = false;
            dgvStaffList.RowHeadersVisible = false;
            dgvStaffList.ReadOnly = true;
            selectedStaffID = "";
            staff = new Staff();
        }

        private void BtnSearchStaff_Click(object sender, EventArgs e)
        {
            changeDgvStaffList(staff.GetStaffTable(staffMultiSearchString()));

        }

        private string staffMultiSearchString()
        {
            string queryString = "";
            if (txtStaffID.Text != "")
            {
                queryString += "StaffID LIKE '%" + txtStaffID.Text + "%'" + " AND ";
            }
            if (txtStaffName.Text != "")
            {
                queryString += "StaffName LIKE '%" + txtStaffName.Text + "%' " + " AND ";
            }
            if (txtStaffPhoneNo.Text != "")
            {
                queryString += "StaffPhoneNo LIKE '%" + txtStaffPhoneNo.Text + "%' " + " AND ";
            }
            if (cbStaffDepartment.Text != " " && cbStaffDepartment.Text != "")
            {
                queryString += "DepartmentID LIKE '%" + cbStaffDepartment.Text + "%' " + " AND ";
            }
            if (queryString != "")
            {
                queryString = queryString.Remove(queryString.Length - 5);
            }

            return queryString;
        }

        private void changeDgvStaffList(DataTable table)
        {
            dgvStaffList.DataSource = null;
            dgvStaffList.DataSource = table;
            dgvStaffList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStaffList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStaffList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStaffList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStaffList.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void DgvStaffList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedStaffID = dgvStaffList.Rows[e.RowIndex].Cells["StaffID"].Value.ToString();
                dgvStaffList.Rows[e.RowIndex].Selected = true;
                staff = new Staff(selectedStaffID);

                lblStaffID.Text = staff.StaffID;
                lblStaffName.Text = staff.StaffName;
                lblStaffPhoneNo.Text = staff.StaffPhoneNo;
                lblStaffPassword.Text = staff.Password;
                lblDepartmentID.Text = staff.DepartmentID;
                lblStaffStatus.Text = staff.StaffStatus;
            }
        }

        private void BtnNewStaff_Click(object sender, EventArgs e)
        {
            frmStaffManagement_NewStaff frmNewStaff = new frmStaffManagement_NewStaff();
            frmNewStaff.Show();
        }

        private void BtnEditStaff_Click(object sender, EventArgs e)
        {
            if (selectedStaffID != "")
            {
                frmStaffManagement_EditStaff frmEditStaff = new frmStaffManagement_EditStaff(selectedStaffID);
                frmEditStaff.Show();
            }
            else
            {
                MessageBox.Show("Please select a staff");
            }
        }

        private void DgvStaffList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEditStaff_Click(sender,e);
        }

        private void FrmStaffManagement_Load(object sender, EventArgs e)
        {
            dgvStaffList.AllowUserToAddRows = false;
            dgvStaffList.RowHeadersVisible = false;
            dgvStaffList.ReadOnly = true;
            dgvStaffList.AllowUserToResizeRows = false;
            dgvStaffList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cbStaffDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}

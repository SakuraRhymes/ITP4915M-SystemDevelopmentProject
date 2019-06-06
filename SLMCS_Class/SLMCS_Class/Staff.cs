using System;
using System.Collections.Generic;
using System.Data;
using SLMCS_ERP;

namespace SLMCS_Class
{
    public class Staff
    {
        private string staffID;
        private string password;
        private DateTime passwordChangeDate;
        private string staffName;
        private string staffPhoneNo;
        private string staffPositionID;//determine the system function
        private string departmentID;

        private DBConnection dbConnection;
        private DataTable staffTable;

        private Department _department; //may don't need
        private List<ReorderOrder> _reorderOrder;

        public Staff()
        {
            dbConnection = new DBConnection();
        }

        public Staff(string staffID)
        {
            dbConnection = new DBConnection();
            _reorderOrder = new List<ReorderOrder>();

            string query = "SELECT * FROM Staff WHERE StaffID ='" + staffID + "'";

            staffTable = dbConnection.GetDataTable(query);
            DataRow[] rows = staffTable.Select();

            StaffID = (string)rows[0]["StaffID"];
            Password = (string)rows[0]["Password"];
            PasswordChangeDate = (DateTime)rows[0]["PasswordChangeDate"];
            StaffName = (string)rows[0]["StaffName"];
            StaffPhoneNo = (string)rows[0]["StaffPhoneNo"];
            StaffPositionID = (string)rows[0]["StaffPositionID"];
            DepartmentID = (string)rows[0]["DepartmentID"];
        }
        //login the system via staffID and password
        public bool Verify(string password)
        {
            return password == Password;
        }
        //change staff login password
        public bool ChangePassword(string newPassword)
        {
            if (Verify(password))
            {
                dbConnection.Update("Staff", "Password='" + newPassword + "', PasswordChangeDate=" + "CURDATE()" + "", "WHERE StaffID='" + staffID + "'");
                Password = newPassword;
                //PasswordChangeDate = DateTime.Today.ToString("dd/MM/yyyy");
                Console.WriteLine("change successful"); // for testing
                return true;
            }
            Console.WriteLine("change fail"); // for testing
            return false;
        }
        //staffPhoneNo for checking the password
        public string ForgetPassword(string _staffPhoneNo)
        {
            if (_staffPhoneNo == staffPhoneNo)
            {
                return password;
            }
            else
            {
                return null;
            }
        }

        //CreateStaffAccount incomplete
        public bool CreateStaffAccount(string staffName, string staffPhoneNo, string staffPositionID, string departmentID)
        {
            return false;
        }
        //new Staff ID for creation
        public string GetNextStaffID()
        {
            return "";
        }

        public void AddReorderOrder(ReorderOrder reorderOrder)
        {
            _reorderOrder.Add(reorderOrder);
        }

        public void RemoveReorderOrder(ReorderOrder reorderOrder)
        {
            _reorderOrder.Add(reorderOrder);
        }

        public List<ReorderOrder> GetStaffReorderOrders()
        {
            return _reorderOrder;
        }


        //        all get set method below
        public string StaffID
        {
            get => staffID;
            set => staffID = value;
        }
        public string StaffName
        {
            get => staffName;
            set => staffName = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public DateTime PasswordChangeDate
        {
            get => passwordChangeDate;
            set => passwordChangeDate = value;
        }

        public string StaffPhoneNo
        {
            get => staffPhoneNo;
            set => staffPhoneNo = value;
        }

        public string StaffPositionID
        {
            get => staffPositionID;
            set => staffPositionID = value;
        }

        public string DepartmentID
        {
            get => departmentID;
            set => departmentID = value;
        }

        //may don't need
        public Department Department
        {
            get => _department;
            set => _department = value;
        }

        public override string ToString()
        {
            string staffDetail = staffID + ", " + password + ", ";
            return staffDetail + staffName + ", " + staffPhoneNo + ", " + staffPositionID + ", " + departmentID;
        }
    }
}
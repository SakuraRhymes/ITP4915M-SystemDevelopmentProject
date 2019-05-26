using System;
using System.Data;
using SLMCS_ERP;

namespace SLMCS_Class.Properties
{
    public class Staff
    {
        private string staffID;
        private string password;
        private string passwordChangeDate;
        private string staffName;
        private string staffPhoneNo;
        private string staffPositionID;//determine the system function
        private string departmentID;

        private DBConnection dbConnection;
        private DataTable staffTable;
        
        private Department _department; //may don't need
        
        public Staff()
        {
            dbConnection = new DBConnection();
        }
        //login the system via staffID and password
        public bool login(string staffID, string password)
        {
            string query = "SELECT * FROM Staff WHERE StaffID='" + staffID +  "' AND Password='" + password + "'";
            staffTable = dbConnection.getDataTable(query);
            if (staffTable.Rows.Count == 1)
            {
                this.staffID = staffID;
                this.password = password;
                
                DataRow[] rows = staffTable.Select();
                passwordChangeDate = ((DateTime) rows[0]["PasswordChangeDate"]).ToString("dd/MM/yyyy");
                staffName = (string) rows[0]["StaffName"];
                staffPhoneNo = (string) rows[0]["StaffPhoneNo"];
                staffPositionID = (string) rows[0]["StaffPositionID"];
                departmentID = (string) rows[0]["DepartmentID"];
                Console.WriteLine("login successful"); // for testing
                return true;
            }
            Console.WriteLine("password or id invalid"); // for testing
            return false;
        }
        //change staff login password
        public bool changePassword(string newPassword)
        {
            if (login(staffID, password))
            {
                dbConnection.update("Staff", "Password='" + newPassword + "', PasswordChangeDate="+ "CURDATE()" + "", "WHERE StaffID='" + staffID + "'");
                setPassword(newPassword);
                setPasswordChangeDate((DateTime.Today).ToString("dd/MM/yyyy"));
                Console.WriteLine("change successful"); // for testing
                return true;
            }
            Console.WriteLine("change fail"); // for testing
            return false;
        }
        //staffName and staffPhoneNo for checking the password
        public string forgetPassword(string staffName, string staffPhoneNo)
        {
            if (this.staffName.Equals(staffName) && this.staffPhoneNo.Equals(staffPhoneNo))
            {
                return password;
            }  
            return "input wrong, please try again!";
        }
        
        //CreateStaffAccount incomplete
        public bool CreateStaffAccount(string staffName, string staffPhoneNo, string staffPositionID,string departmentID)
        {
            return false;
        }
        
//        all get set method below
        public void setStaffID(string newStaffID)
        {
            staffID = newStaffID;
        }

        public string getStaffID()
        {
            return staffID;
        }
        
        private void setPassword(string newPassword)
        {
            password = newPassword;
        }

        public string getPassword()
        {
            return staffID;
        }
        
        public void setStaffName(string newStaffName)
        {
            staffName = newStaffName;
        }

        public string getStaffName()
        {
            return staffName;
        }
        
        public void setPasswordChangeDate(string passwordChangeDate)
        {
            this.passwordChangeDate = passwordChangeDate;
        }

        public string getPasswordChangeDate()
        {
            return passwordChangeDate;
        }
        
        public void setDepartment(Department _department)
        {
            this._department = _department;
        }
        
        public Department getDepartment()
        {
            return _department;
        }

        public override string ToString()
        {
            string staffDetail = staffID + ", " + password + ", ";
            return staffDetail + staffName + ", " + staffPhoneNo + ", " + staffPositionID + ", " + departmentID ;
        }
    }
}
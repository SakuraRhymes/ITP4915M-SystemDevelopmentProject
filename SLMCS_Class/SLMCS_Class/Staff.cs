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
        private string staffPositionID;
        private string departmentID;
        private Department _department;
        private DBConnection dbConnection;
        private DataTable staffTable;
        
        public Staff(string staffID, string password)
        {
            dbConnection = new DBConnection();
            if (verify(staffID, password))
            {
                this.staffID = staffID;
                this.password = password;
                
                DataRow[] rows = staffTable.Select();
                passwordChangeDate = ((DateTime) rows[0]["PasswordChangeDate"]).ToString("dd/MM/yyyy");
                staffName = (string) rows[0]["StaffName"];
                staffPhoneNo = (string) rows[0]["StaffPhoneNo"];
                staffPositionID = (string) rows[0]["StaffPositionID"];
                departmentID = (string) rows[0]["DepartmentID"];
                
                //only for testing Console.WriteLine
                Console.WriteLine(passwordChangeDate);
                Console.WriteLine("login successful");
            }
            else
            {
                Console.WriteLine("password or id invalid");
            }
        }
        
        private bool verify(string staffID, string password)
        {
            string query = "SELECT * FROM Staff WHERE StaffID='" + staffID +  "' AND Password='" + password + "'";
            staffTable = dbConnection.getDataTable(query);
            if (staffTable.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }

        public void changePassword(string newPassword)
        {
            if (verify(staffID, password))
            {
                dbConnection.update("Staff", "Password='" + newPassword + "'", "WHERE StaffID='" + staffID + "'");
                setPassword(newPassword);
            }
        }

        public string forgetPassword()
        {
            return "";
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
        
        public void setPassword(string newPassword)
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
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

        public Staff()
        {
            dbConnection = new DBConnection();
        }
        //login the system via staffID and password
        public bool verify(string staffID, string password)
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
            if (verify(staffID, password))
            {
                dbConnection.update("Staff", "Password='" + newPassword + "', PasswordChangeDate="+ "CURDATE()" + "", "WHERE StaffID='" + staffID + "'");
                Password = newPassword;
                PasswordChangeDate = DateTime.Today.ToString("dd/MM/yyyy");
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
        //new Staff ID for creation
        public string NextStaffID()
        {
            return "";
        }
        
//        all get set method below
        public string StaffID
        {
            get { return staffID;}
            set { staffName = value; }
        }
        
        public string Password
        {
            get { return password;}
            set { password = value; }
        }
        
        public string PasswordChangeDate
        {
            get { return passwordChangeDate;}
            set { passwordChangeDate = value; }
        }
        
        public string StaffName
        {
            get { return staffName;}
            set { staffName = value; }
        }
        
        public string StaffPhoneNo
        {
            get { return staffPhoneNo;}
            set { staffPhoneNo = value; }
        }
        
        public string StaffPositionID
        {
            get { return staffPositionID;}
            set { staffPositionID = value; }
        }
        
        public string DepartmentID
        {
            get { return departmentID;}
            set { departmentID = value; }
        }

        public override string ToString()
        {
            string staffDetail = staffID + ", " + password + ", ";
            return staffDetail + staffName + ", " + staffPhoneNo + ", " + staffPositionID + ", " + departmentID ;
        }
    }
}
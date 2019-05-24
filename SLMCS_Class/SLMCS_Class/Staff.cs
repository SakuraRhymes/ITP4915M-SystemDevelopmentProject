using System;

namespace SLMCS_Class.Properties
{
    public class Staff
    {
        private string staffID;
        private string password;
        private DateTime passwordChangeDate;
        private string staffName;
        private string staffPhoneNo;
        private Department _department;
        
        public Staff(string staffID, string password)
        {
            this.staffID = staffID;
            this.password = password;
            if (verify(staffID, password))
            {
                this.staffName = staffName;
                Console.WriteLine("login successful");
                
            }
            else
            {
                Console.WriteLine("password or id invalid");
            }
        }
        
        public bool verify(string staffID, string password)
        {
            if (staffID == "s" && password == "p")
            {
                return true;
            }
            return false;
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
            return staffName;
        }
    }
}
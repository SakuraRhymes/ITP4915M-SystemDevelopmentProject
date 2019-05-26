using System.Collections.Generic;
using SLMCS_Class.Properties;

namespace SLMCS_Class
{
    public class Department
    {
        private string departmentID;
        private string departmentName;
        private List<Staff> _staff;
        
        public Department(string departmentID, string departmentName)
        {
            this.departmentID = departmentID;
            this.departmentName = departmentName;
            _staff = new List<Staff>();
        }

        public void addStaff(Staff staff)
        {
            _staff.Add(staff);
        }

        public void removeStaff(Staff staff)
        {
            _staff.Remove(staff);
        }

        public List<Staff> getStaff()
        {
            return _staff;
        }
        
        //get set method
        public void setDepartmentID(string departmentID)
        {
            this.departmentID = departmentID;
        }
        
        public string getDepartmentID()
        {
            return departmentID;
        }
        
        public void setDepartmentName(string departmentName)
        {
            this.departmentName = departmentName;
        }
        
        public string getDepartmentName()
        {
            return departmentName;
        }
        
        public override string ToString()
        {
            return "Department ID: " + departmentID + " Department Name: " + departmentName;
        }
    }
}
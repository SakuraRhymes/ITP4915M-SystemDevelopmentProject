using System.Collections.Generic;
using SLMCS_Class;

namespace SLMCS_Class
{
    public class Department
    {
        private string departmentID;
        private string departmentName;
        //private List<Staff> _staff; //may don't need
        
        public Department()
        { 
            //_staff = new List<Staff>();
        }

        //may don't need
//        public void addStaff(Staff staff)
//        {
//            _staff.Add(staff);
//        }
//
//        public void removeStaff(Staff staff)
//        {
//            _staff.Remove(staff);
//        }
//
//        public List<Staff> getStaff()
//        {
//            return _staff;
//        }
        
        //get set method
        public string DepartmentID
        {
            get { return departmentID; }
            set { departmentID = value; }
        }
        
        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }

        //may don't need
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
using System;
using SLMCS_Class.Properties;

namespace SLMCS_Class
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Department salesDepartment = new Department("SA", "Sales Department");
            Staff staff1 = new Staff("s", "p", "staffA");
            Staff staff2 = new Staff("s", "p", "staffB");
            Staff staff3 = new Staff("s", "p", "staffC");
            
            staff1.setDepartment(salesDepartment);
            salesDepartment.addStaff(staff1);
            salesDepartment.addStaff(staff2);
            salesDepartment.addStaff(staff3);
            foreach (var staffMember in salesDepartment.getStaff())
            {
                Console.WriteLine(staffMember);
            }
            Console.WriteLine(staff1.getDepartment());
        }
    }
}
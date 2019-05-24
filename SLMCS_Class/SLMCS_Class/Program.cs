using System;
using SLMCS_Class.Properties;
using SLMCS_ERP;

namespace SLMCS_Class
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Staff s1 = new Staff("S19002708", "546456");
            
            Console.WriteLine(s1);
            
            s1.changePassword("wqehge324");
            Console.WriteLine(s1);
        }
    }
}
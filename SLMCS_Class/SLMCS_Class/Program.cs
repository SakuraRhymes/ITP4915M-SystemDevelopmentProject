using System;
using SLMCS_Class.Properties;
using SLMCS_ERP;

namespace SLMCS_Class
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Staff s1 = new Staff();
            s1.Verify("S19002708", "aa");
            Console.WriteLine(s1.Password);
            Console.WriteLine(s1.PasswordChangeDate);
        }
    }
}
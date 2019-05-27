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
            s1.verify("S19002708", "werwer");
            Console.WriteLine(s1.Password);
            Console.WriteLine(s1.PasswordChangeDate);
            Console.WriteLine(s1.forgetPassword("Tisdale", "41300364487"));
            Console.WriteLine(s1.changePassword("neeeee"));
            Console.WriteLine(s1);
        }
    }
}
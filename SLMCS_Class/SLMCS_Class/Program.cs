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
            s1.login("S19002708", "werwer");
            Console.WriteLine(s1.forgetPassword("Tisdal","41300364487"));
        }
    }
}
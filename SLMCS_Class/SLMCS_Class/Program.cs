using System;
using SLMCS_Class.Properties;
using SLMCS_ERP;

namespace SLMCS_Class
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Department po = new Department("s","sd");
            Staff s1 = new Staff("S19002708", "u1s5tw051");
            
            Console.WriteLine(s1);
        }
    }
}
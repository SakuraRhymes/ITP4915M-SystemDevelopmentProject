using System;
using SLMCS_Class.Properties;
using SLMCS_ERP;

namespace SLMCS_Class
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DBConnection db = new DBConnection();
            if (db.openConnection())
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
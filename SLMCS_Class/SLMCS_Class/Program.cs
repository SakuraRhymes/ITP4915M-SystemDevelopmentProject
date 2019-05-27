using System;
using SLMCS_Class.Properties;
using SLMCS_ERP;

namespace SLMCS_Class
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Product product = new Product();

            Console.WriteLine(product.GetNextProductID("A"));
            
        }
    }
}
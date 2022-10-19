using System;
using ClassLibrary1;
using ExtensionNameSpace;

namespace ClassLib
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Product p = new Product() { ProductCost = 500, DiscountPercentage = 20 };
            
            Console.WriteLine(p.GetDiscount());
            Console.ReadKey();
        }
    }
}
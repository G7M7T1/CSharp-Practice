using System;

namespace FileIO
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string mon = "10";
            string da = "10";
            string yer = "10";
            
            Console.WriteLine("{0}.{1}.{2}", mon, da, yer);
            
            Console.WriteLine(mon + "." + da + "." + yer);
            
            Console.WriteLine($"{mon}.{da}.{yer}");
        }
    }
}
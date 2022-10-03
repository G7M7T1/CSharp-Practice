using System;
using System.IO;

namespace FileIO
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] lines = { "First line", "Second line" };
            
            File.WriteAllLines(@"C:\Projects\Read2.txt", lines);

            Console.ReadKey();
            
        }
    }
}
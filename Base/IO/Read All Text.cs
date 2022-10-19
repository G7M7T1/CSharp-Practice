using System;

namespace FileIO
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Projects\Read.txt");
            
            Console.WriteLine($"The Text In Read Is: {text}");
            Console.ReadKey();
        }
    }
}
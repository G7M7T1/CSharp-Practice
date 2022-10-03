using System;

namespace FileIO
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Projects\Read.txt");
            
            Console.WriteLine($"The Text In Read Is: {text}");

            string[] lines = System.IO.File.ReadAllLines(@"C:\Projects\Read.txt");
            
            Console.WriteLine();
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }

            Console.ReadKey();
            
        }
    }
}
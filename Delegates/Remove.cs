using System;
using System.Collections.Generic;

namespace ApplicationBase
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // list of name
            List<string> names = new List<string>() { "Alide", "Stave", "Li", "Yui" };
            Console.WriteLine("------Before------");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            
            names.RemoveAll(Filter);
            
            Console.WriteLine("------After------");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static bool Filter(string s)
        {
            return s.Contains("i");
        }
    }
}
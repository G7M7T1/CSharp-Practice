using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace RegexE
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            string pattern = @"\d";
            Regex regex = new Regex(pattern);

            string text = "Hello there, my number is 123456";

            MatchCollection matchCollection = regex.Matches(text);
            
            Console.WriteLine(matchCollection.Count);
            Console.WriteLine(text);

            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine(group[0]);
            }
        }
    }
}
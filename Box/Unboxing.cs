using System;

namespace UnboxingEXM
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            object obj = 10;
            int x = (int)obj;
            
            Console.WriteLine(obj);
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
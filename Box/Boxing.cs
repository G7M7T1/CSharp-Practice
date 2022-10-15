using System;

namespace BoxingEXM
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //primitive variable
            int x = 10;
            
            //boxing value to reference
            object obj = x;
            
            Console.WriteLine(x);
            Console.WriteLine(obj);

        }
    }
}
using System;

namespace NullableTyle
{
    class Person
    {
        public int? NoOfChild;
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person() { NoOfChild = null };
            Person p2 = new Person() { NoOfChild = null };
            
            Console.WriteLine(p1.NoOfChild ?? 0);
            Console.WriteLine(p2.NoOfChild.HasValue ? p2.NoOfChild.Value : 0);
            
            Console.ReadKey();
        }
    }
}
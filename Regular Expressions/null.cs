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
            Person p1 = new Person() { NoOfChild = 2 };
            Person p2 = new Person() { NoOfChild = null };

            if (p1.NoOfChild != null)
            {
                Console.WriteLine(p1.NoOfChild);
            }
            
            if (p2.NoOfChild.HasValue)
            {
                Console.WriteLine(p2.NoOfChild);
            }
            Console.ReadKey();
        }
    }
}
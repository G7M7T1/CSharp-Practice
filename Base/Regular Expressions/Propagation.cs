using System;

namespace NullableTyle
{
    class Person
    {
        public int? Age;
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person() { Age = 20 };
            Console.WriteLine(p1 == null ? null : Convert.ToString(p1.Age));

            Person p2 = null;
            Console.WriteLine(p2?.Age);
            
            Console.ReadKey();
        }
    }
}
using System;

namespace ImplictlyTypedVariable
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            namespace1.namespace2.namespace3.Person p1;
            p1 = new namespace1.namespace2.namespace3.Person() { PersonName = "Yun" };

            var p2 = new namespace1.namespace2.namespace3.Person() { PersonName = "Lis" };

            var p3 = "Lis".ToUpper();
            Console.WriteLine(p3);
            Console.WriteLine(p2.PersonName);
            Console.WriteLine(p1.PersonName);

            Console.ReadKey();
        }
    }
}
using System;
using ClassLibrary1;

namespace PatternMatchingEXM
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ParentClass pc;

            pc = new ChildClass() { x = 10, y = 20 };
            
            Console.WriteLine(pc.x); // only can access x 

            if (pc is ChildClass)
            {
                ChildClass cc = (ChildClass)pc;
                Console.WriteLine(cc.y);
                Console.WriteLine(cc.x);
            }
            
            Console.ReadKey();
        }
    }
}
using System;

namespace GCE
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MarksPrinter<GraduateStudent> mp = new MarksPrinter<GraduateStudent>();
            mp.stu = new GraduateStudent() { Marks = 80 };
            mp.PrintMarks();
            
            Console.ReadKey();
        }
    }
}
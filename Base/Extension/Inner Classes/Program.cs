using System;
using ClassLibrary1;

namespace InnerClass
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MarksCalculation mc = new MarksCalculation();
            Student s = new Student() { SecuredMarks = 35, MaxMarks = 50 };
            mc.CalculatePercentage(s);
            Console.WriteLine(s.Percentage);

            Console.ReadKey();
        }
    }
}
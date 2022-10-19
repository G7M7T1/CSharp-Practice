using System;

namespace DynamicallyTypedVariablesExample
{
    class Student
    {
        public string StudentName { get; set; }
    }
    class Program
    {
        static void Main()
        {
            //dynamically typed variable
            dynamic x;

            x = 100;

            x = "Hello";

            x = new Student() { StudentName = "Harsha" };
            Student y = new Student() { StudentName = "Lis" };

            Console.WriteLine(x.StudentName);
            Console.WriteLine(y.StudentName);
            
            Console.ReadKey();
        }
    }
}

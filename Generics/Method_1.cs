namespace GME
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Sample sam = new Sample();

            Employee emp = new Employee() { Salary = 3000 };
            Student stu = new Student() { Marks = 92 };
            
            sam.PrintData(emp);
            sam.PrintData(stu);

        }
    }
}
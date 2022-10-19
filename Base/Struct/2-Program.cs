namespace SttuctureE2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // instance structure
            Structure1 structure1;
            // don't have to new
            structure1.x = 10;
            structure1.y = 20;
            
            
            // object based on class
            Class1 class1;
            class1 = new Class1();
            class1.x = 10;
            class1.y = 20;
            
            // instance structure 2
            Structure1 structure2 = new Structure1();
            // reference variable of class1
            Class1 class2;

            // copy data from structure1 to structure2
            structure2 = structure1;
            // copy data from class1 to class2
            class2 = class1;
            
            // modify data of structure2
            structure2.x = 100;
            structure2.y = 200;
            // modify data of class2
            class2.x = 100;
            class2.y = 200;

            System.Console.WriteLine(structure1.x);
            System.Console.WriteLine(structure1.y);
            System.Console.WriteLine();
            System.Console.WriteLine(structure2.x);
            System.Console.WriteLine(structure2.y);
            System.Console.WriteLine();
            System.Console.WriteLine(class2.x);
            System.Console.WriteLine(class2.y);

        }
    }
}
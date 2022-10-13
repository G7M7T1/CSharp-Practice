namespace Nullables 
{
    internal class Program 
    {
        public static void Main(string[] args)
        {
            double? num1 = 13.5;
            double? num2 = null;
            
            double num3;

            if (num1 == null) 
            {
                num3 = 0.0;
            }
            else
            {
                num3 = (double)num1;
            }

            System.Console.WriteLine($"Value of num3 is {num3}");


            // Method 2

            num3 = num1 ?? 8.35;
            System.Console.WriteLine($"Value of num3 is {num3}");
            num3 = num2 ?? 8.35;
            System.Console.WriteLine($"Value of num3 is {num3}");
        }
    }
}
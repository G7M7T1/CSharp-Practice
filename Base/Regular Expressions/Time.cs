using System;

namespace DateTimeT
{
    class Program 
    {
        static void Main(string[] args) 
        {
            DateTime datetime = new DateTime(2018, 5, 31);
            Console.WriteLine("My birthday is {0}", datetime);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            
            Console.WriteLine(GetTomorrow());
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
    }
}
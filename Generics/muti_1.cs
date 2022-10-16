using System;

namespace GCE
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            User<int, int> user1 = new User<int, int>();
            User<bool, int> user2 = new User<bool, int>();

            user1.RegistrationStatus = 12345;
            user1.Age = 18;
            user2.RegistrationStatus = false;
            user2.Age = 20;
            
            Console.WriteLine(user1.RegistrationStatus);
            Console.WriteLine(user2.RegistrationStatus);

            Console.ReadKey();
        }
    }
}
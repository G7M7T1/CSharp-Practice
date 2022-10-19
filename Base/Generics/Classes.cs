using System;

namespace GCE
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            User<int> user1 = new User<int>();
            User<bool> user2 = new User<bool>();

            user1.RegistrationStatus = 12345;
            user2.RegistrationStatus = false;
            
            Console.WriteLine(user1.RegistrationStatus);
            Console.WriteLine(user2.RegistrationStatus);

            Console.ReadKey();
        }
    }
}
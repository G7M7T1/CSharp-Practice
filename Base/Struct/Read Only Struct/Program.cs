using System;

namespace ReadOnlyStructure
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Marvel m = new Marvel("Thanos");
            
            Console.WriteLine(m.CharacterName);
            m.PrintCharacterName();

            Console.ReadKey();
        }
    }
}
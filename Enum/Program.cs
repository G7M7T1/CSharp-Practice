namespace EnumE
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.PersonName = "John";
            person1.Email = "John@gg.com";
            person1.AgeGroup = AgeGroupEnum.Adult;
            
            System.Console.WriteLine(person1.AgeGroup);
            System.Console.ReadKey();
        }
    }
}
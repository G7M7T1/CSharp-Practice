using System;
using System.Collections.Generic;

namespace ApplicationBase
{
    internal class Program
    {
        public delegate bool FilterDelegate(Person p);
        
        public static void Main(string[] args)
        {

            Person p1 = new Person() { Name = "Lani", Age = 81 };
            Person p2 = new Person() { Name = "Lci", Age = 19 };
            Person p3 = new Person() { Name = "Waller", Age = 61 };
            Person p4 = new Person() { Name = "ily", Age = 17 };

            List<Person> people = new List<Person>() { p1, p2, p3, p4 };
            
            DisplayPeople("Kid", people, IsAdult);
        }

        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);

            foreach (Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine($"{p.Name}, {p.Age} years old");
                }
            }
        }

        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18 && p.Age <= 64;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
    }
}
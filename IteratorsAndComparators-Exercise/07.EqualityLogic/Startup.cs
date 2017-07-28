namespace _07.EqualityLogic
{
    using Models;
    using System.Collections.Generic;
    using System;

    class Startup
    {
        static void Main(string[] args)
        {
            SortedSet<Person> sortedPeople = new SortedSet<Person>();
            HashSet<Person> hashedPeople = new HashSet<Person>();

            ReadPeople(sortedPeople, hashedPeople);

            Console.WriteLine(sortedPeople.Count);
            Console.WriteLine(hashedPeople.Count);
        }

        private static void ReadPeople(SortedSet<Person> sortedPeople, HashSet<Person> hashedPeople)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] personData = Console.ReadLine().Split();

                Person person = new Person(personData[0], int.Parse(personData[1]));
                sortedPeople.Add(person);
                hashedPeople.Add(person);
            }
        }
    }
}

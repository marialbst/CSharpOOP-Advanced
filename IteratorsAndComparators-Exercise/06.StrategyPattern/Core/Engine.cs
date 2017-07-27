namespace _06.StrategyPattern.Core
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Models;
    using Models.Comparators;

    public class Engine : IEngine
    {
        private SortedSet<IPerson> peopleByAge;
        private SortedSet<IPerson> peopleByName;

        public Engine()
        {
            this.peopleByAge = new SortedSet<IPerson>(new AgeComparator());
            this.peopleByName = new SortedSet<IPerson>(new NameComparator());
        }


        public void Run()
        {
            ReadPeople();
            PrintPeople();
        }

        private void PrintPeople()
        {
            if (this.peopleByAge.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, this.peopleByName));
                Console.WriteLine(string.Join(Environment.NewLine, this.peopleByAge));
            }
        }

        private void ReadPeople()
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] personData = Console.ReadLine().Split();
                IPerson person = new Person(personData[0], int.Parse(personData[1]));
                this.peopleByAge.Add(person);
                this.peopleByName.Add(person);
            }
        }
    }
}

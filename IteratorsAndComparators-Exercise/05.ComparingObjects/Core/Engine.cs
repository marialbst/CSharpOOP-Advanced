namespace _05.ComparingObjects.Core
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Models;

    public class Engine : IEngine
    {
        private IList<IPerson> people;
        private int matchesCount;
        private int differentCount;

        public Engine()
        {
            this.people = new List<IPerson>();
        }

        public void Run()
        {

            this.ReadPeople();
            this.ComparePeople();

            if (this.matchesCount <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{this.matchesCount} {this.differentCount} {this.people.Count}");
            }
        }

        private void ComparePeople()
        {
            int nthPersonIndex = int.Parse(Console.ReadLine()) - 1;

            IPerson compPerson = this.people[nthPersonIndex];

            for (int i = 0; i < this.people.Count; i++)
            {
                if (compPerson.CompareTo(this.people[i]) == 0)
                {
                    this.matchesCount++;
                }
                else
                {
                    this.differentCount++;
                }
            }
        }

        private void ReadPeople()
        {
            string command = String.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] personData = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                IPerson person = new Person(personData[0], int.Parse(personData[1]), personData[2]);
                this.people.Add(person);
            }
        }
    }
}

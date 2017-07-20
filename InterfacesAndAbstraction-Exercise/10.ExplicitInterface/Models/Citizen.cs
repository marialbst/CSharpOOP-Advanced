namespace _10.ExplicitInterface.Models
{
    using Interfaces;
    using System;

    public class Citizen : IPerson, IResident
    {
        public Citizen(string name, string country, int age)
        {
            this.Age = age;
            this.Name = name;
            this.Country = country;
        }

        public int Age { get; private set; }

        public string Country { get; private set; }

        public string Name { get; private set; }

        string IPerson.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }

        string IResident.GetName()
        {
            return this.Name;
        }
    }
}

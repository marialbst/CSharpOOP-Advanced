namespace _01.IPerson.Models
{
    using Interfaces;

    public class Citizen : IPerson
    {
        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public int Age { get; private set; }

        public string Name { get; private set; }
    }
}
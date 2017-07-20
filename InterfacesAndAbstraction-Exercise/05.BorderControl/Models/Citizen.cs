namespace _05.BorderControl.Models
{
    using Interfaces;

    public class Citizen : ISocietyMember
    {
        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public string Id { get; private set; }
        public int Age { get; private set; }
        public string Name { get; private set; }
    }
}
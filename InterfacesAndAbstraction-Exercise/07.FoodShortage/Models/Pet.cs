namespace _07.FoodShortage.Models
{
    using Interfaces;

    public class Pet : IBirthdate
    {
        public Pet(string name, string birthdate)
        {
            this.Birthdate = birthdate;
            this.Name = name;
        }

        public string Birthdate { get; private set; }
        public string Name { get; private set; }
    }
}

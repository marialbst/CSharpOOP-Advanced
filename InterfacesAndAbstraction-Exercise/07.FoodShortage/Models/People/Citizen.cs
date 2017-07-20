namespace _07.FoodShortage.Models.People
{
    using Interfaces;

    public class Citizen : Human, ISocietyMember, IBirthdate
    {
        public Citizen(string name, int age, string id, string birthdate)
            :base(name, age)
        {
            
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Birthdate { get; private set; }
        public string Id { get; private set; }

        public override void BuyFood()
        {
            this.Food += 10;
        }
    }
}
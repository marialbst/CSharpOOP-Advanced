namespace _07.FoodShortage.Models.People
{
    public class Rebel : Human
    {
        public Rebel(string name, int age, string group) 
            : base(name, age)
        {
            this.Group = group;
        }

        public string Group { get; private set; }

        public override void BuyFood()
        {
            this.Food += 5;
        }
    }
}

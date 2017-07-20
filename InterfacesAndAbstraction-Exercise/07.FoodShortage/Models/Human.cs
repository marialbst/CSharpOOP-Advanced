namespace _07.FoodShortage.Models
{
    using Interfaces;

    public abstract class Human : IHuman
    {
        public Human(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Food = 0;
        }

        public int Age { get; protected set; }
        public string Name { get; protected set; }
        public int Food { get; set; }
        public abstract void BuyFood();
    }
}

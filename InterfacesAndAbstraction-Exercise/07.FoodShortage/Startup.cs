namespace _07.FoodShortage
{
    using Interfaces;
    using Models.People;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            
            ICollection<IHuman> buyers = FillWithPeople();

            BuyFood(buyers);
            Console.WriteLine(buyers.Sum(b => b.Food));
            
        }

        private static void BuyFood(ICollection<IHuman> buyers)
        {
            var name = Console.ReadLine();

            while(name != "End")
            {
                var buyer = buyers.FirstOrDefault(b => b.Name == name);

                if (buyer != null)
                {
                    buyer.BuyFood();
                }

                name = Console.ReadLine();
            }
        }

        private static ICollection<IHuman> FillWithPeople()
        {
            ICollection<IHuman> buyers = new List<IHuman>();
            int peopleCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < peopleCount; i++)
            {
                var inputArgs = Console.ReadLine().Split();

                if (inputArgs.Length == 4)
                {
                    buyers.Add(new Citizen(inputArgs[0], int.Parse(inputArgs[1]), inputArgs[2], inputArgs[3]));
                }
                else
                {
                    buyers.Add(new Rebel(inputArgs[0], int.Parse(inputArgs[1]), inputArgs[2]));
                }
            }
            return buyers;
        }
    }
}

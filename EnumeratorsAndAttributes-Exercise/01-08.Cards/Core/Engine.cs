namespace _01_02.Cards.Core
{
    using System;
    using Enums;

    public class Engine
    {
        public void Run()
        {
            var command = Console.ReadLine();

            switch (command)
            {
                case "Card Suits":
                    this.PrintCards(command, Enum.GetValues(typeof(CardSuit)));
                    break;
                case "Card Ranks":
                    this.PrintCards(command, Enum.GetValues(typeof(CardRank)));
                    break;
            }
        }

        private void PrintCards(string command, Array values)
        {
            
            Console.WriteLine($"{command}:");
            foreach (var val in values)
            {
                Console.WriteLine($"Ordinal value: {(int)val}; Name value: {val}");
            }
        }
    }
}

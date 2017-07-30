namespace _03_08.CardPower.Core
{
    using System;
    using System.Collections.Generic;
    using Attributes;
    using Enums;
    using Models;

    public class Engine
    {
        public void Run()
        {
            //this.CompareCards();

            //this.PrintAttribute();

            //this.PrintDeckOfCards();

            this.CardGame();

        }

        private void CardGame()
        {
            List<string> cardsDeck = this.GenerateDeckOfCards();
            string firstPlayer = Console.ReadLine();
            string secondPlayer = Console.ReadLine();

            Game game = new Game(cardsDeck, firstPlayer, secondPlayer);
            ReadCards(firstPlayer, secondPlayer, game);

            Console.WriteLine(game);
        }

        private static void ReadCards(string firstPlayer, string secondPlayer, Game game)
        {
            while (game.FirstPlayer.Cards.Count != 5)
            {
                string cardString = Console.ReadLine();
                try
                {
                    game.AddCard(firstPlayer, cardString);
                }
                catch (InvalidOperationException ei)
                {
                    Console.WriteLine(ei.Message);
                }
                
            }

            while (game.SecondPlayer.Cards.Count != 5)
            {
                string cardString = Console.ReadLine();
                try
                {
                    game.AddCard(secondPlayer, cardString);
                }
                catch (InvalidOperationException ei)
                {
                    Console.WriteLine(ei.Message);
                }
            }
        }

        private void PrintDeckOfCards()
        {
            List<string> cardsDeck = this.GenerateDeckOfCards();
            var command = Console.ReadLine();
            if (command == "Card Deck")
            {
                Console.WriteLine(String.Join(Environment.NewLine, cardsDeck));
            }
        }

        private List<string> GenerateDeckOfCards()
        {
            List<string> cardsDeck = new List<string>();

            string[] cardSuits = Enum.GetNames(typeof(CardSuit));
            string[] cardRanks = Enum.GetNames(typeof(CardRank));

            foreach (var suit in cardSuits)
            {
                foreach (var rank in cardRanks)
                {
                    if (rank == "Ace")
                    {
                        cardsDeck.Insert(cardsDeck.Count-12, $"{rank} of {suit}");
                    }
                    else
                    {
                        cardsDeck.Add($"{rank} of {suit}");
                    }
                }   
            }

            return cardsDeck;
        }

        private void PrintAttribute()
        {
            string input = Console.ReadLine();
            Type type;
            if (input == "Rank")
            {
                type = typeof(CardRank);
            }
            else
            {
                type = typeof(CardSuit);
            }

            var customAttributes = type.GetCustomAttributes(false);

            foreach (TypeAttribute customAttribute in customAttributes)
            {
                Console.WriteLine($"Type = {customAttribute.Type}, Description = {customAttribute.Description}");
            }
        }

        private void CompareCards()
        {
            string rank1 = Console.ReadLine();
            string suit1 = Console.ReadLine();
            Card card1 = new Card(rank1, suit1);

            string rank2 = Console.ReadLine();
            string suit2 = Console.ReadLine();
            Card card2 = new Card(rank2, suit2);

            Console.WriteLine(card1.Compare(card2));
        }
    }
}

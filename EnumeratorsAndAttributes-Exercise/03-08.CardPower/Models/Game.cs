namespace _03_08.CardPower.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Enums;

    public class Game
    {
        public Game(IList<string> deckOfCards, string player1Name, string player2Name)
        {
            this.DeckOfCards = deckOfCards;
            this.CardsInPlay = new List<string>();
            this.FirstPlayer = new Player(player1Name);
            this.SecondPlayer = new Player(player2Name);
        }

        public IList<string> CardsInPlay { get; set; }

        public IList<string> DeckOfCards { get; set; }

        public Player FirstPlayer { get; set; }
        public Player SecondPlayer { get; set; }

        public void AddCard(string name, string cardString)
        {
            if (this.DeckOfCards.All(c => c != cardString))
            {
                if (this.CardsInPlay.All(c => c != cardString))
                {
                    throw new InvalidOperationException("No such card exists.");
                }

                throw new InvalidOperationException("Card is not in the deck.");
            }

            string[] cardData = cardString.Split(new[] {" of "}, StringSplitOptions.RemoveEmptyEntries);
            Card card = new Card(cardData[0], cardData[1]);

            if (name == this.FirstPlayer.Name)
            {
                this.FirstPlayer.AddCard(card);
            }
            else
            {
                this.SecondPlayer.AddCard(card);
            }

            this.DeckOfCards.Remove(cardString);
            this.CardsInPlay.Add(cardString);
        }

        public Player Winner()
        {
            if (this.FirstPlayer.MaxPowerCard().CompareTo(this.SecondPlayer.MaxPowerCard()) > 0)
            {
                return this.FirstPlayer;
            }
            return this.SecondPlayer;
        }

        public override string ToString()
        {
            return $"{this.Winner().Name} wins with {this.Winner().MaxPowerCard().CardRank} of {this.Winner().MaxPowerCard().CardSuit}.";
        }
    }
}

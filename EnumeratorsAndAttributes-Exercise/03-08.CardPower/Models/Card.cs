namespace _03_08.CardPower.Models
{
    using System;
    using Enums;

    public class Card : IComparable<Card>
    {
        public Card(string cardRank, string cardSuit)
        {
            this.CardSuit = (CardSuit)Enum.Parse(typeof(CardSuit), cardSuit);
            this.CardRank = (CardRank)Enum.Parse(typeof(CardRank), cardRank);
        }

        public CardSuit CardSuit { get; set; }
        public CardRank CardRank { get; set; }

        public int CardPower { get { return this.GetPower(); } }

        private int GetPower()
        {
            return (int)this.CardSuit + (int)this.CardRank;
        }

        public int CompareTo(Card other)
        {
            return this.CardPower.CompareTo(other.CardPower);
        }

        public override string ToString()
        {
            return $"Card name: {this.CardRank} of {this.CardSuit}; Card power: {this.CardPower}";
        }

        public Card Compare(Card card2)
        {
            if (this.CompareTo(card2) == 1)
            {
                return this;
            }

            return card2;
        }
    }
}

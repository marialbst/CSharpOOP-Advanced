namespace _03_08.CardPower.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Player
    {
        public Player(string name)
        {
            this.Name = name;
            this.Cards = new List<Card>();
        }

        public string Name { get; set; }

        public IList<Card> Cards { get; set; }

        public void AddCard(Card card)
        {
            this.Cards.Add(card);
        }

        public Card MaxPowerCard()
        {
            return this.Cards.First(cc => cc.CardPower == this.Cards.Max(c => c.CardPower));
        }
    }
}

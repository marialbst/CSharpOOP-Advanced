namespace _02.CoffeeMachine.Models
{
    using System;
    using System.Collections.Generic;
    using Enums;

    public class CoffeeMachine
    {
        private List<CoffeeType> coffeesSold;
        private int coins;

        public CoffeeMachine()
        {
            this.coffeesSold = new List<CoffeeType>();
        }

        public IEnumerable<CoffeeType> CoffeesSold { get { return this.coffeesSold; } }

        public void BuyCoffee(string size, string type)
        {
            CoffeeType coffeeType = (CoffeeType) Enum.Parse(typeof(CoffeeType), type);
            CoffeePrice price = (CoffeePrice) Enum.Parse(typeof(CoffeePrice), size);

            if (this.coins >= (int)price)
            {
                this.coffeesSold.Add(coffeeType);
                this.coins = 0;
            }
        }

        public void InsertCoin(string coin)
        {
            Coin coinEnum = (Coin) Enum.Parse(typeof(Coin), coin);

            this.coins += (int) coinEnum;
        }
    }
}
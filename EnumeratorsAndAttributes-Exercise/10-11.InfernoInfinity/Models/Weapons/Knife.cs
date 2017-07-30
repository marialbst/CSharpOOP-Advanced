﻿namespace _10_11.InfernoInfinity.Models.Weapons
{
    public class Knife : Weapon
    {
        public Knife(string name, string rarity) 
            : base(name, rarity, 2)
        {
            this.MaxDamage = 4;
            this.MinDamage = 3;
            this.GetRarityBonus();
        }
    }
}

namespace _10_11.InfernoInfinity.Models.Weapons
{
    public class Sword : Weapon
    {
        public Sword(string name, string rarity) 
            : base(name, rarity, 3)
        {
            this.MaxDamage = 6;
            this.MinDamage = 4;
            this.GetRarityBonus();
        }
    }
}

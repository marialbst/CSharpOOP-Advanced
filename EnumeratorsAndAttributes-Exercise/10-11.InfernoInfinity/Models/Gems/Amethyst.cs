namespace _10_11.InfernoInfinity.Models.Gems
{
    public class Amethyst : Gem
    {
        public Amethyst(string clarity) 
            : base(clarity)
        {
            this.Stat = new Stat(2,8,4);
            this.GetStatsBonus();
        }
    }
}

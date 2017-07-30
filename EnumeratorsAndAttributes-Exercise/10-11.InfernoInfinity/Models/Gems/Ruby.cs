namespace _10_11.InfernoInfinity.Models.Gems
{
    public class Ruby : Gem
    {
        public Ruby(string clarity) 
            : base(clarity)
        {
            this.Stat = new Stat(7,2,5);
            this.GetStatsBonus();
        }
    }
}

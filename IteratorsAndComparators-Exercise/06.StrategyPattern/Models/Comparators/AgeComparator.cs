namespace _06.StrategyPattern.Models.Comparators
{
    using Interfaces;

    public class AgeComparator : CustomComparator
    {
        public override int Compare(IPerson x, IPerson y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}

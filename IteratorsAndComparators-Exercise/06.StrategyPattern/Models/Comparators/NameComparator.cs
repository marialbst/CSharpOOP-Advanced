namespace _06.StrategyPattern.Models.Comparators
{
    using System;
    using Interfaces;

    public class NameComparator : CustomComparator
    {
        public override int Compare(IPerson x, IPerson y)
        {
            if (x.Name.Length != y.Name.Length)
            {
                return x.Name.Length.CompareTo(y.Name.Length);
            }

            return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
}

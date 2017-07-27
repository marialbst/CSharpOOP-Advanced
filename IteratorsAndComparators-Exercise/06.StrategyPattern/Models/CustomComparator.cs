namespace _06.StrategyPattern.Models
{
    using System.Collections.Generic;
    using Interfaces;

    public abstract class CustomComparator : IComparer<IPerson>
    {
        public abstract int Compare(IPerson x, IPerson y);
    }
}

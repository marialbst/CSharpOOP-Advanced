using System;

namespace _08_10.CustomList.Interfaces
{
    public interface ISorter<T>
        where T : IComparable
    {
        void Sort();
    }
}

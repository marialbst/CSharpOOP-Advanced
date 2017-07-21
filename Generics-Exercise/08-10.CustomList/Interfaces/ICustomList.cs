using System;
using System.Collections.Generic;

namespace _08_10.CustomList.Interfaces
{
    public interface ICustomList<T> : ISorter<T>, IEnumerable<T>
        where T : IComparable
    {
        void Add(T element);
        T Remove(int index);
        bool Contains(T element);
        void Swap(int index1, int index2);
        int CountGreaterThan(T element);
        T Max();
        T Min();
    }
}

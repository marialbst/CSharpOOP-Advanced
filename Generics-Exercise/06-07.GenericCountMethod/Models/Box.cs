
namespace _06_07.GenericCountMethod.Models
{
    using System;
    using System.Collections.Generic;

    public class Box<T>
        where T : IComparable<T>
    {
        public Box(T val)
        {
            this.TValue = val;
        }

        public T TValue { get; private set;}

        public int Compare(IEnumerable<Box<T>> items, T itemToCompare)
        {
            int counter = 0;

            foreach (var item in items)
            {
                if(item.TValue.CompareTo(itemToCompare) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public override string ToString()
        {
            return $"{this.TValue.GetType().FullName}: {this.TValue}";
        }
    }
}

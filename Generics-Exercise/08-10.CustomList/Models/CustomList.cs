namespace _08_10.CustomList.Models
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Collections;

    public class CustomList<T> : ICustomList<T>, IEnumerable<T>
        where T : IComparable
    {
        private IList<T> list;

        public CustomList()
        {
            this.list = new List<T>();
        }
        public void Add(T element)
        {
            this.list.Add(element);
        }

        public bool Contains(T element)
        {
            if(this.list.Contains(element))
            {
                return true;
            }
            return false;
        }

        public int CountGreaterThan(T element)
        {
            int counter = 0;
            foreach (var item in this.list)
            {
                if(item.CompareTo(element) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.list.GetEnumerator();
        }

        public T Max()
        {
            return this.list.Max();
        }

        public T Min()
        {
            return this.list.Min();
        }

        public T Remove(int index)
        {
            T item = this.list[index];
            this.list.RemoveAt(index);
            return item;
        }

        public void Sort()
        {
            var sorted = this.list.ToList();
            sorted.Sort();
            this.list = sorted;
        }

        public void Swap(int index1, int index2)
        {
            T item1 = this.list[index1];
            this.list[index1] = this.list[index2];
            this.list[index2] = item1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

namespace _01_02.ListyIterator.Models
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using System.Text;

    public class ListyIterator<T> : IListyIterator<T>, IEnumerable<T>
    {
        private IList<T> items;
        private int currentIndex;

        public ListyIterator(params T[] inputData)
        {
            this.items = new List<T>(inputData);
        }

        public bool Move()
        {
            if(currentIndex + 1 < this.items.Count)
            {
                currentIndex++;
                return true;
            }
            return false;
        }

        public T Print()
        {
            if (this.items.Count < 1)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            return this.items[currentIndex];
        }

        public bool HasNext()
        {
            return currentIndex < this.items.Count - 1;
        }

        public string PrintAll()
        {
            var sb = new StringBuilder();

            foreach (var item in this.items)
            {
                sb.Append($"{item} ");
            }
            return sb.ToString().Trim();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

namespace _09.CollectionHierarchy.Models
{
    using Interfaces;
    using System.Collections.Generic;

    public class MyList<T> : IMyList<T>
    {
        private IList<T> items;

        public MyList()
        {
            this.items = new List<T>();
        }

        public int Used { get { return this.items.Count; } }

        public int Add(T item)
        {
            this.items.Insert(0, item);
            return 0;
        }

        public T Remove()
        {
            var firstItem = this.items[0];
            this.items.RemoveAt(0);
            return firstItem;
        }
    }
}

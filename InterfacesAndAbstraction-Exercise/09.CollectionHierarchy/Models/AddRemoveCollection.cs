namespace _09.CollectionHierarchy.Models
{
    using Interfaces;
    using System.Collections.Generic;

    public class AddRemoveCollection<T> : IAddRemoveCollection<T>
    {
        private IList<T> items;

        public AddRemoveCollection()
        {
            this.items = new List<T>();
        }

        public int Add(T item)
        {
            this.items.Insert(0, item);
            return 0;
        }

        public T Remove()
        {
            var lastItem = this.items[this.items.Count - 1];
            this.items.RemoveAt(this.items.Count - 1);
            return lastItem;
        }
    }
}

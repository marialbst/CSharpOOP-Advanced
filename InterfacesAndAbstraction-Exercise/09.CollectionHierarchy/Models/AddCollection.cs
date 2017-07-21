namespace _09.CollectionHierarchy.Models
{
    using Interfaces;
    using System.Collections.Generic;

    public class AddCollection<T> : IAddCollection<T>
    {
        private IList<T> items;

        public AddCollection()
        {
            this.items = new List<T>();
        }
        public int Add(T item)
        {
            this.items.Add(item);
            return this.items.Count - 1;
        }
    }
}

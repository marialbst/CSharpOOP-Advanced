namespace Databasepr.Models
{
    using System;
    using Interfaces;

    public class Database<T> : IDatabase<T>
    {
        private const int Capacity = 16;

        private T[] items;
        private int filledIndex;

        public Database(params T[] data)
        {
            this.Items = data;
            //this.ValidateInput(data);
        }

        public int Count { get { return this.filledIndex; } }

        public T[] Items
        {
            get { return this.items; }
            private set {
                if (value == null || value.Length < 1 || value.Length > Capacity)
                {
                    throw new InvalidOperationException("Invalid input");
                }
                this.items = new T[Capacity];

                for (int i = 0; i < value.Length; i++)
                {
                    this.items[i] = value[i];
                }
                this.filledIndex = value.Length;
            }
        }

        public void Add(T item)
        {
            if (this.filledIndex == Capacity)
            {
                throw new InvalidOperationException("Items already reached max capacity");
            }
            this.Items[this.filledIndex] = item;
            this.filledIndex++;
        }

        public void Remove()
        {
            if (this.Items.Length == 0)
            {
                throw new InvalidOperationException("Cannot remove from empty collection.");
            }

            this.Items[this.filledIndex] = default(T);
            this.filledIndex--;
        }

        public T[] Fetch()
        {
            return this.Items;
        }
    }
}

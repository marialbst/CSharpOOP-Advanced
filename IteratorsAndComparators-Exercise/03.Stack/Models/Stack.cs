namespace _03.Stack.Models
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IEnumerable<T>, IStack<T>
    {
        private IList<T> items;

        public Stack()
        {
            this.items = new List<T>();
        }

        public T Pop()
        {
            if(this.items.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            T lastItem = this.items[this.items.Count - 1];
            this.items.RemoveAt(this.items.Count - 1);
            return lastItem;
        }

        public void Push(params T[] elements)
        {
            foreach (var item in elements)
            {
                this.items.Add(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.items.Count - 1; i >= 0; i--)
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

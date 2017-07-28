namespace _09.LinkedListTraversal.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedList<T> : IEnumerable<T> 
        where T : IComparable
    {
        public LinkedList()
        {
            this.Head = null;
            this.Count = 0;
        }

        public Node<T> Head { get; set; }
        public int Count { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> currentNode = this.Head;
            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Add(T item)
        {
            if (this.Count == 0)
            {
                this.Head = new Node<T>(item);
            }
            else
            {
                Node<T> lastItem = this.GetElementAtIndex(this.Count - 1);
                lastItem.Next = new Node<T>(item);
            }
            this.Count++;
        }

        public void Remove(T element)
        {
            int index = this.GetIndexByElement(element);

            if (index == 0)
            {
                this.Head = this.Head.Next;
                this.Count--;
            }
            else if(index > 0)
            {
                Node<T> prNode = this.GetElementAtIndex(index - 1);
                Node<T> currNode = this.GetElementAtIndex(index);
                prNode.Next = currNode.Next;
                this.Count--;
            }
            
        }

        public int GetIndexByElement(T element)
        {
            Node<T> currNode = this.Head;

            for (int i = 0; i < this.Count; i++)
            {
                if (currNode.Value.Equals(element))
                {
                    return i;
                }
                currNode = currNode.Next;
            }
            return -1;
        }

        private Node<T> GetElementAtIndex(int index)
        {
            var currentElement = this.Head;
            for (int i = 0; i < index; i++)
            {
                currentElement = currentElement.Next;
            }

            return currentElement;
        }
    }
}

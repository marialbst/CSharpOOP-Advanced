﻿namespace _09.LinkedListTraversal.Models
{
    public class Node<T>
    {
        public Node( T value)
        {
            this.Value = value;
        }

        public Node<T> Next { get; set; }
        public T Value { get; set; }
    }
}

using System.Collections.Generic;

public class Box<T> : IBox<T>
{
    private IList<T> items;

    public Box()
    {
        this.items = new List<T>();
    }

    public int Count { get { return this.items.Count; } }

    public void Add(T element)
    {
        this.items.Add(element);
    }

    public T Remove()
    {
        T lastElem = this.items[this.items.Count - 1];
        this.items.RemoveAt(this.items.Count - 1);
        return lastElem;
    }
}
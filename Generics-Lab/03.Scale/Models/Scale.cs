using System;

public class Scale<T>
       where T : IComparable<T>
{
    public Scale(T left, T right)
    {
        this.Left = left;
        this.Right = right;
    }

    private T Left { get; set; }
    private T Right { get; set; }

    public T GetHavier()
    {
        if (this.Left.CompareTo(this.Right) < 0)
        {
            return this.Right;
        }
        else if (this.Left.CompareTo(this.Right) > 0)
        {
            return this.Left;
        }
        return default(T);
    }
}
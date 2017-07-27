namespace _05.ComparingObjects.Interfaces
{
    using System;
    public interface IPerson : IComparable<IPerson>
    {
        string Name { get; }
        int Age { get; }
        string Town { get; }
    }
}

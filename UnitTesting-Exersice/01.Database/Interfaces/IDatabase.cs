namespace Databasepr.Interfaces
{
    public interface IDatabase<T>
    {
        T[] Items { get; }
        int Count { get; }
        void Add(T item);
        void Remove();
        T[] Fetch();
    }
}

namespace _01_02.ListyIterator.Interfaces
{
    public interface IListyIterator<T>
    {
        bool Move();
        bool HasNext();
        T Print();
        string PrintAll();
    }
}

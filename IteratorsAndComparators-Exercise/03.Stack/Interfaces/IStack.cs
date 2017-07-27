namespace _03.Stack.Interfaces
{
    public interface IStack<T>
    {
        void Push(params T[] elements);
        T Pop();
    }
}

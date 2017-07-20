namespace _09.CollectionHierarchy.Interfaces
{
    public interface IAddRemoveCollection<Type> : IAddCollection<Type>
    {
        void Remove(Type item);
    }
}

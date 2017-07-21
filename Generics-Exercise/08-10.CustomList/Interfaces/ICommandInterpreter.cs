using System.Collections.Generic;

namespace _08_10.CustomList.Interfaces
{
    interface ICommandInterpreter
    {
        void AddItem(IList<string> parameters);
        void RemoveItem(IList<string> parameters);
        void PrintIsContained(IList<string> parameters);
        void SwapElements(IList<string> parameters);
        void PrintGreaterThanValue(IList<string> parameters);
        void PrintMaxElement();
        void PrintMinElement();
        void PrintAll();
        void SortItems();
    }
}

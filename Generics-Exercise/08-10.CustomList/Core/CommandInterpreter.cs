namespace _08_10.CustomList.Core
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Models;

    public class CommandInterpreter : ICommandInterpreter
    {
        private ICustomList<string> items;

        public CommandInterpreter()
        {
            this.items = new CustomList<string>();
        }

        public void AddItem(IList<string> parameters)
        {
            var item = parameters[0];
            this.items.Add(item);
        }

        public void PrintAll()
        {
            foreach (var item in this.items)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void PrintGreaterThanValue(IList<string> parameters)
        {
            var value = parameters[0];
            Console.WriteLine(this.items.CountGreaterThan(value));
        }

        public void PrintIsContained(IList<string> parameters)
        {
            var item = parameters[0];
            Console.WriteLine(this.items.Contains(item));
        }

        public void PrintMaxElement()
        {
            Console.WriteLine(this.items.Max());
        }

        public void PrintMinElement()
        {
            Console.WriteLine(this.items.Min());
        }

        public void SortItems()
        {
            this.items.Sort();
        }

        public void RemoveItem(IList<string> parameters)
        {
            var index = int.Parse(parameters[0]);
            this.items.Remove(index);
        }

        public void SwapElements(IList<string> parameters)
        {
            var index1 = int.Parse(parameters[0]);
            var index2 = int.Parse(parameters[1]);

            this.items.Swap(index1, index2);
        }
    }
}

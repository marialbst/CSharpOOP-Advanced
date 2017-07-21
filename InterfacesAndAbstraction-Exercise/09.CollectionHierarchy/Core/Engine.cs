namespace _09.CollectionHierarchy.Core
{
    using Models;
    using Interfaces;
    using System.Collections.Generic;
    using System;

    public class Engine
    {
        private IAddCollection<string> addCollectionItems;
        private IAddRemoveCollection<string> addRemoveCollectionItems;
        private IMyList<string> myListItems;
        private ICollection<int> addCollectionResults;
        private ICollection<int> addRemoveCollectionResults;
        private ICollection<int> myListResults;
        private ICollection<string> addRemoveRes;
        private ICollection<string> myListRemoveRes;

        public Engine()
        {
            this.addCollectionItems = new AddCollection<string>();
            this.addRemoveCollectionItems = new AddRemoveCollection<string>();
            this.myListItems = new MyList<string>();
            this.addCollectionResults = new List<int>();
            this.addRemoveCollectionResults = new List<int>();
            this.myListResults = new List<int>();
            this.myListRemoveRes = new List<string>();
            this.addRemoveRes = new List<string>();
        }

        public void Run()
        {
            AddOperations();
            RemoveOperations();
        }

        private void RemoveOperations()
        {
            RemoveItemsFromCollections();
            PrintResults(this.addRemoveRes);
            PrintResults(this.myListRemoveRes);
        }

        private void PrintResults(ICollection<string> items)
        {
            Console.WriteLine(string.Join(" ", items));
        }

        private void RemoveItemsFromCollections()
        {
            int removeOps = int.Parse(Console.ReadLine());

            for (int i = 0; i < removeOps; i++)
            {
                this.addRemoveRes.Add(this.addRemoveCollectionItems.Remove());
                this.myListRemoveRes.Add(this.myListItems.Remove());
            }
        }

        private void AddOperations()
        {
            AddItemsInCollections();
            PrintAddResults(this.addCollectionResults);
            PrintAddResults(this.addRemoveCollectionResults);
            PrintAddResults(this.myListResults);
        }

        private void PrintAddResults(ICollection<int> collection)
        {
            Console.WriteLine(string.Join(" ", collection));
        }

        private void AddItemsInCollections()
        {
            string[] items = Console.ReadLine().Split();

            foreach (var item in items)
            {
                this.addCollectionResults.Add(this.addCollectionItems.Add(item));
                this.addRemoveCollectionResults.Add(this.addRemoveCollectionItems.Add(item));
                this.myListResults.Add(this.myListItems.Add(item));
            }
        }
    }
}

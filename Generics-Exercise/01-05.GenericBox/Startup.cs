namespace _01_05.GenericBox
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    class Startup
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            //Task 2, Task 4, Task 6
            IList<Box<string>> boxes = RunGenericBoxOfStringTask(count);
            //Task 3, Task 5
            //IList<Box<int>> boxes = RunGenericBoxOfIntTask(count);

            //Task 4, Task 5
            SwapMethod(boxes);
            //All tasks
            boxes.ToList().ForEach(b => Console.WriteLine(b));
        }

        private static void SwapMethod<T>(IList<Box<T>> boxes)
        {
            var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Swap(indexes[0], indexes[1], boxes);
        }

        private static IList<Box<string>> RunGenericBoxOfStringTask(int count)
        {
            IList<Box<string>> boxes = new List<Box<string>>();

            for (int i = 0; i < count; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());
                boxes.Add(box);
            }

            return boxes;
        }

        private static IList<Box<int>> RunGenericBoxOfIntTask(int count)
        {
            IList<Box<int>> boxes = new List<Box<int>>();

            for (int i = 0; i < count; i++)
            {
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
                boxes.Add(box);
            }

            return boxes;
        }
        
        private static void Swap<T>(int index1, int index2, IList<T> items)
        {
            T item1 = items[index1];
            items[index1] = items[index2];
            items[index2] = item1;
        }
    }
}

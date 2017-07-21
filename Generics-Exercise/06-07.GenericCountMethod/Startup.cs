namespace _06_07.GenericCountMethod
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            //CountStrings(count);
            CountDoubles(count);
        }

        private static void CountStrings(int count)
        {
            IEnumerable<Box<string>> boxes = RunGenericBoxOfStringTask(count);
            var boxVal = Console.ReadLine();
            Box<string> box = boxes.First();

            Console.WriteLine(box.Compare(boxes, boxVal));
        }

        private static void CountDoubles(int count)
        {
            IEnumerable<Box<double>> boxes = RunGenericBoxOfDoubleTask(count);
            var boxVal = double.Parse(Console.ReadLine());
            Box<double> box = boxes.First();

            Console.WriteLine(box.Compare(boxes, boxVal));
        }

        private static IList<Box<double>> RunGenericBoxOfDoubleTask(int count)
        {
            IList<Box<double>> boxes = new List<Box<double>>();

            for (int i = 0; i < count; i++)
            {
                Box<double> box = new Box<double>(double.Parse(Console.ReadLine()));
                boxes.Add(box);
            }

            return boxes;
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
    }
}

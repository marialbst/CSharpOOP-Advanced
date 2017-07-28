namespace _09.LinkedListTraversal
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using Models;

    class Startup
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            int comCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < comCount; i++)
            {
                var command = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Add":
                        list.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        list.Remove(int.Parse(command[1]));
                        break;
                }
            }

            Console.WriteLine(list.Count);
            Console.WriteLine(string.Join(" ", list));
        }
    }
}

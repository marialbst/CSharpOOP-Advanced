namespace _04.Froggy
{
    using Models;
    using System;
    using System.Linq;

    class Startup
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake(input);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}

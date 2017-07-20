namespace _10.ExplicitInterface
{
    using Interfaces;
    using Models;
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            ICollection<Citizen> citizens = new List<Citizen>();

            while(command != "End")
            {
                var input = command.Split();

                citizens.Add(new Citizen(input[0], input[1], int.Parse(input[2])));

                command = Console.ReadLine();
            }

            foreach (var citizen in citizens)
            {
                Console.WriteLine((citizen as IResident).GetName());
                Console.WriteLine((citizen as IPerson).GetName());
            }
        }
    }
}

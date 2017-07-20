namespace _06.BirthdayCelebrations
{
    using Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using System;
    using Models;

    public class Startup
    {
        public static void Main(string[] args)
        {
            ICollection<IBirthdate> society = ReadLivingMembers();
            string year = Console.ReadLine();

            society.Where(s => s.Birthdate.EndsWith(year))
                .ToList()
                .ForEach(i => Console.WriteLine(i.Birthdate));
        }

        private static ICollection<IBirthdate> ReadLivingMembers()
        {
            ICollection<IBirthdate> society = new List<IBirthdate>();

            var command = String.Empty;

            while((command = Console.ReadLine()) != "End")
            {
                var input = command.Split();

                switch(input[0])
                {
                    case "Citizen": society.Add(new Citizen(input[1], int.Parse(input[2]), input[3], input[4]));break;
                    case "Pet": society.Add(new Pet(input[1], input[2])); break;
                    default: break;
                }
            }

            return society;
        }
    }
}

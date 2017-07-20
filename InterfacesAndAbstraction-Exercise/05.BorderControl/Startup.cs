namespace _05.BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;
    using Interfaces;
    public class Startup
    {
        public static void Main(string[] args)
        {
            ICollection<ISocietyMember> society = ReadMembers();
            string fakeIdEnding = Console.ReadLine();

            society.Where(s => s.Id.EndsWith(fakeIdEnding))
                .ToList()
                .ForEach(i => Console.WriteLine(i.Id));

        }

        private static ICollection<ISocietyMember> ReadMembers()
        {
            ICollection<ISocietyMember> members = new List<ISocietyMember>();

            string command = Console.ReadLine();
            while (command != "End")
            {
                var input = command.Split();

                if (input.Length == 3)
                {
                    members.Add(new Citizen(input[0], int.Parse(input[1]), input[2]));
                }
                else
                {
                    members.Add(new Robot(input[0], input[1]));
                }
                command = Console.ReadLine();
            }

            return members;
        }
    }
}
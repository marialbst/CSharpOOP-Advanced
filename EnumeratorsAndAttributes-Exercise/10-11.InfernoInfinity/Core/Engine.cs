namespace _10_11.InfernoInfinity.Core
{
    using System;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using Attribute;
    using Models;

    public class Engine
    {
        private CommandInterpreter interpreter;

        public Engine()
        {
            this.interpreter = new CommandInterpreter();
        }

        public void Run()
        {
            string input = String.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] inputData = input.Split(';');

                switch (inputData[0])
                {
                    case "Add":
                        this.interpreter.Add(inputData[1], int.Parse(inputData[2]), inputData[3]);
                        break;
                    case "Create":
                        this.interpreter.Create(inputData[1], inputData[2]);
                        break;
                    case "Remove":
                        this.interpreter.Remove(inputData[1], int.Parse(inputData[2]));
                        break;
                    case "Print":
                        this.interpreter.Print(inputData[1]);
                        break;
                    default:
                        break;
                }
            }
        }

        public void PrintAttribute()
        {
            var customAttribute = (CustomClassAttribute)typeof(Weapon).GetCustomAttributes(false).First();
            string command = String.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                switch (command)
                {
                    case "Author":
                        Console.WriteLine($"{command}: {customAttribute.Author}");
                        break;
                    case "Revision":
                        Console.WriteLine($"{command}: {customAttribute.Revision}");
                        break;
                    case "Description":
                        Console.WriteLine($"Class description: {customAttribute.Description}");
                        break;
                    case "Reviewers":
                        Console.WriteLine($"{command}: {string.Join(", ", customAttribute.Reviewers)}");
                        break;
                }

            }
        }
    }
}

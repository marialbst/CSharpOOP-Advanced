namespace _01_02.ListyIterator.Core
{
    using Interfaces;
    using System;
    using System.Linq;

    public class Engine : IEngine
    {
        private CommandInterpreter interpreter;

        public Engine()
        {
            this.interpreter = new CommandInterpreter();
        }

        public void Run()
        {
            string command = Console.ReadLine();

            while(command != "END")
            {
                string[] input = command.Split();
                switch (input[0])
                {
                    case "Create":
                        interpreter.Create(input.Skip(1).ToArray());
                        break;
                    case "Move":
                        interpreter.Move();
                        break;
                    case "HasNext":
                        interpreter.HasNext();
                        break;
                    case "Print":
                        interpreter.Print();
                        break;
                    case "PrintAll":
                        interpreter.PrintAll();
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}

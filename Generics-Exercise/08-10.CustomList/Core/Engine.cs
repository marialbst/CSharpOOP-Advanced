using System;
using System.Linq;

namespace _08_10.CustomList.Core
{
    public class Engine
    {
        private CommandInterpreter interpreter;

        public Engine()
        {
            this.interpreter = new CommandInterpreter();
        }

        internal void Run()
        {
            var input = Console.ReadLine();

            while(input != "END")
            {
                var command = input.Split();
                var parameters = command.Skip(1).ToList();
                switch (command[0])
                {
                    case "Add": interpreter.AddItem(parameters);break;
                    case "Remove": interpreter.RemoveItem(parameters);break;
                    case "Contains": interpreter.PrintIsContained(parameters);break;
                    case "Swap": interpreter.SwapElements(parameters);break;
                    case "Greater": interpreter.PrintGreaterThanValue(parameters);break;
                    case "Min": interpreter.PrintMinElement();break;
                    case "Max": interpreter.PrintMaxElement();break;
                    case "Print": interpreter.PrintAll();break;
                    case "Sort": interpreter.SortItems();break;
                    default: break;
                }

                input = Console.ReadLine();
            }
        }
    }
}

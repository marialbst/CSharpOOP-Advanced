namespace _08.MilitaryElite.Core
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
            
            var command = Console.ReadLine();

            while (command != "End")
            {
                var inputArgs = command.Split();
                var parameters = inputArgs.Skip(1).ToList();
                switch (inputArgs[0])
                {
                    case "Private": this.interpreter.AddPrivate(parameters); break;
                    case "LeutenantGeneral": this.interpreter.AddLeutenant(parameters); break;
                    case "Engineer": this.interpreter.AddEngineer(parameters);break;
                    case "Commando": this.interpreter.AddCommando(parameters);break;
                    case "Spy": this.interpreter.AddSpy(parameters);break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(this.interpreter.PrintSoldiers());
        }
    }
}

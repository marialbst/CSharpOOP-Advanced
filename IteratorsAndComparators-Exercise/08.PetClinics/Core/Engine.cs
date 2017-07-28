namespace _08.PetClinics.Core
{
    using System;
    using System.Linq;

    public class Engine
    {
        private CommandInterpreter interpreter;

        public Engine()
        {
            this.interpreter = new CommandInterpreter();
        }

        public void Run()
        {
            int rows = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                string[] command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string[] arguments = command.Skip(1).ToArray();

                switch (command[0])
                {
                    case "Create": this.interpreter.Create(arguments); break;
                    case "HasEmptyRooms": Console.WriteLine(this.interpreter.HasEmptyRooms(arguments));break;
                    case "Add": Console.WriteLine(this.interpreter.AddPet(arguments));break;
                    case "Release": Console.WriteLine(this.interpreter.ReleasePet(arguments));break;
                    case "Print": this.interpreter.Print(arguments);break;
                    default:
                        throw new InvalidOperationException("Invalid operation");
                }
            }
        }
    }
}

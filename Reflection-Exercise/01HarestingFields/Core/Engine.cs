using System;

namespace _01HarestingFields.Core
{
    class Engine
    {
        Interpreter interpreter;

        public Engine()
        {
            this.interpreter = new Interpreter();
        }

        public void Run()
        {
            string command = String.Empty;
            while((command = Console.ReadLine())!="HARVEST")
            {
                this.interpreter.Print(command);
            }
        }
    }
}

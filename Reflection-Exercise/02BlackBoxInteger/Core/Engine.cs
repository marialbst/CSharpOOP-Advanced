using System;

namespace _02BlackBoxInteger.Core
{
    public class Engine
    {
        Interpreter interpreter;

        public Engine()
        {
            this.interpreter = new Interpreter();
        }

        public void Run()
        {
            string input = String.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                this.interpreter.PrintResult(input);
            }
        }
    }
}

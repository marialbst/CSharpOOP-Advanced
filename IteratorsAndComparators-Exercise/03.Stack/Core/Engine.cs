namespace _03.Stack.Core
{
    using Interfaces;
    using System;
    using Models;
    using System.Linq;

    public class Engine : IEngine
    {
        private Stack<string> myStack;

        public Engine()
        {
            this.myStack = new Stack<string>();
        }

        public void Run()
        {
            string command = Console.ReadLine();

            while(command != "END")
            {
                string[] input = command.Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
                
                if (input[0] == "Push")
                {
                    this.myStack.Push(input.Skip(1).ToArray());
                }
                else if(input[0] == "Pop")
                {
                    try
                    {
                        this.myStack.Pop();
                    }
                    catch (InvalidOperationException io)
                    {
                        Console.WriteLine(io.Message);
                    }
                }
                command = Console.ReadLine();
            }

            PrintResults(this.myStack);
        }

        private void PrintResults(Stack<string> myStack)
        {
            for (int i = 0; i < 2; i++)
            {
                foreach (var item in this.myStack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

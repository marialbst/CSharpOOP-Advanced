namespace _01_02.ListyIterator.Core
{
    using Models;
    using System;

    public class CommandInterpreter
    {
        private ListyIterator<string> listIterator;
        
        public void Create(params string[] inputArgs)
        {
            this.listIterator = new ListyIterator<string>(inputArgs);
        }

        public void Move()
        {
            Console.WriteLine(this.listIterator.Move());
        }

        public void HasNext()
        {
            Console.WriteLine(this.listIterator.HasNext());
        }

        public void Print()
        {
            try
            {
                Console.WriteLine(this.listIterator.Print());
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public void PrintAll()
        {
            Console.WriteLine(this.listIterator.PrintAll());
        }
    }
}

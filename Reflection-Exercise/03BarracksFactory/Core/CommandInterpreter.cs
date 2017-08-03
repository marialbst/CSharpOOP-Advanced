namespace _03BarracksFactory.Core
{
    using Commands;
    using Contracts;
    using System;
    using System.Globalization;

    public class CommandInterpreter : ICommandInterpreter
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            commandName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(commandName);
            commandName = (commandName == "Add" ? "AddUnit" : commandName);
            string command = "_03BarracksFactory.Core.Commands." + commandName + "Command";

            Type type = Type.GetType(command);

            try
            {
                return (Command)Activator.CreateInstance(type, new object[] { data, repository, unitFactory });
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Invalid command!");
            }
        }
    }
}

namespace _03BarracksFactory.Core
{
    using Attributes;
    using Commands;
    using Contracts;
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;

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

            IExecutable comm = null;

            try
            {
                comm = (Command)Activator.CreateInstance(type, new object[] { data});
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Invalid command!");
            }

            comm = this.InjectDependencies(comm);

            return comm;
        }

        private IExecutable InjectDependencies(IExecutable comm)
        {
            FieldInfo[] commFields = comm.GetType()
                                             .GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            FieldInfo[] interpreterFields = typeof(CommandInterpreter)
                                              .GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var field in commFields)
            {
                var fieldAttribute = field.GetCustomAttribute(typeof(InjectAttribute));
                if (fieldAttribute != null)
                {
                    if (interpreterFields.Any(x => x.FieldType == field.FieldType))
                    {
                        field.SetValue(comm,
                            interpreterFields.First(x => x.FieldType == field.FieldType)
                            .GetValue(this));
                    }
                }
            }

            return comm;
        }
    }
}

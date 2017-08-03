namespace _03BarracksFactory.Core.Commands
{
    using Attributes;
    using Contracts;

    public class AddUnitCommand : Command
    {
        [Inject]
        private IRepository repository;

        [Inject]
        private IUnitFactory factory;

        public AddUnitCommand(string[] data) 
            : base(data)
        {
        }

        public override string Execute()
        {
            string unitType = this.Data[1];
            IUnit unitToAdd = this.factory.CreateUnit(unitType);
            this.repository.AddUnit(unitToAdd);
            return unitType + " added!"; 
        }
    }
}

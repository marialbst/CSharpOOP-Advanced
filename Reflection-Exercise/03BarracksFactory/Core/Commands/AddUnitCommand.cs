namespace _03BarracksFactory.Core.Commands
{
    using Contracts;

    public class AddUnitCommand : Command
    {
        public AddUnitCommand(string[] data, IRepository repository, IUnitFactory factory) 
            : base(data, repository, factory)
        {
        }

        public override string Execute()
        {
            string unitType = this.Data[1];
            IUnit unitToAdd = this.Factory.CreateUnit(unitType);
            this.Repository.AddUnit(unitToAdd);
            return unitType + " added!"; 
        }
    }
}

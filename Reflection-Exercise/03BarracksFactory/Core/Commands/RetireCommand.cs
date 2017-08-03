namespace _03BarracksFactory.Core.Commands
{
    using Contracts;

    public class RetireCommand : Command
    {
        public RetireCommand(string[] data, IRepository repository, IUnitFactory factory) 
            : base(data, repository, factory)
        {
        }

        public override string Execute()
        {
            string unitType = this.Data[1];
            this.Repository.RemoveUnit(unitType);
            return unitType + " retired!";
        }
    }
}

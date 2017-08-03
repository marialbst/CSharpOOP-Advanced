namespace _03BarracksFactory.Core.Commands
{
    using Contracts;

    public class ReportCommand : Command
    {
        public ReportCommand(string[] data, IRepository repository, IUnitFactory factory) 
            : base(data, repository, factory)
        {
        }

        public override string Execute()
        {
            return this.Repository.Statistics;
        }
    }
}

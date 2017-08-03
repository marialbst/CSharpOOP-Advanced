namespace _03BarracksFactory.Core.Commands
{
    using Contracts;

    public abstract class Command : IExecutable
    {
        private string[] data;
        private IRepository repository;
        private IUnitFactory factory;

        public Command(string[] data, IRepository repository, IUnitFactory factory)
        {
            this.Data = data;
            this.Repository = repository;
            this.Factory = factory;
        }

        protected string[] Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        protected IRepository Repository
        {
            get { return this.repository; }
            set { this.repository = value; }
        }


        protected IUnitFactory Factory
        {
            get { return this.factory; }
            set { this.factory = value; }
        }

        public abstract string Execute();
    }
}

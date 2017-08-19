using System.Collections.Generic;

public abstract class Command : IExecutable
{
    protected Command()
        :this(new List<string>(), new HeroManager())
    {
        
    }

    protected Command(IList<string> args, IManager manager)
    {
        this.ArgsList = args;
        this.Manager = manager;
    }

    public IList<string> ArgsList { get; protected set; }
    public IManager Manager { get; protected set; }
    public abstract string Execute();
}
namespace _08.MilitaryElite.Interfaces
{
    using Enumerables;

    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}

namespace _08.MilitaryElite.Interfaces
{
    using Enumerables;

    public interface IMission
    {
        string CodeName { get; }
        MissionState MissionState { get; }
        void CompleteMission();
    }
}

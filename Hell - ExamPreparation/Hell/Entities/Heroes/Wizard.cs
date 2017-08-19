public class Wizard : AbstractHero
{
    private const int StrengthVal = 25;
    private const int AgilityVal = 25;
    private const int IntelligenceVal = 100;
    private const int HitPointsVal = 100;
    private const int DamageVal = 250;

    public Wizard(string name)
        : base(name, StrengthVal, AgilityVal, IntelligenceVal, HitPointsVal, DamageVal)
    {
    }
}

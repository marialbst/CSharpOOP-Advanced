public class Barbarian : AbstractHero
{
    private const int StrengthVal = 90;
    private const int AgilityVal = 25;
    private const int IntelligenceVal = 10;
    private const int HitPointsVal = 350;
    private const int DamageVal = 150;

    public Barbarian(string name) 
        : base(name, StrengthVal, AgilityVal, IntelligenceVal, HitPointsVal, DamageVal)
    {
    }
}
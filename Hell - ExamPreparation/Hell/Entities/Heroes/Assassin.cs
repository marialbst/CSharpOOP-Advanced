public class Assassin : AbstractHero
{
    private const int StrengthVal = 25;
    private const int AgilityVal = 100;
    private const int IntelligenceVal = 15;
    private const int HitPointsVal = 150;
    private const int DamageVal = 300;

    public Assassin(string name) 
        : base(name, StrengthVal, AgilityVal, IntelligenceVal, HitPointsVal, DamageVal)
    {
    }

}
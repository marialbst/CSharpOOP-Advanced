using System.Text;

public abstract class AbstractItem : IItem
{
    private string name;
    private int strengthBonus;
    private int agilityBonus;
    private int intelligenceBonus;
    private int hitPointsBonus;
    private int damageBonus;

    protected AbstractItem(string name, int strengthBonus, int agilityBonus, int intelligenceBonus, int hitPointsBonus, int damageBonus)
    {
        this.Name = name;
        this.StrengthBonus = strengthBonus;
        this.AgilityBonus = agilityBonus;
        this.IntelligenceBonus = intelligenceBonus;
        this.HitPointsBonus = hitPointsBonus;
        this.DamageBonus = damageBonus;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int StrengthBonus
    {
        get { return this.strengthBonus; }
        set { this.strengthBonus = value; }
    }

    public int AgilityBonus
    {
        get { return this.agilityBonus; }
        set { this.agilityBonus = value; }
    }

    public int IntelligenceBonus
    {
        get { return this.intelligenceBonus; }
        set { this.intelligenceBonus = value; }
    }

    public int HitPointsBonus
    {
        get { return this.hitPointsBonus; }
        set { this.hitPointsBonus = value; }
    }

    public int DamageBonus
    {
        get { return this.damageBonus; }
        set { this.damageBonus = value; }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"###Item: {this.Name}")
            .AppendLine($"###+{this.StrengthBonus} Strength")
            .AppendLine($"###+{this.AgilityBonus} Agility")
            .AppendLine($"###+{this.IntelligenceBonus} Intelligence")
            .AppendLine($"###+{this.HitPointsBonus} HitPoints")
            .Append($"###+{this.DamageBonus} Damage");
        return sb.ToString();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public abstract class AbstractHero : IHero, IComparable<AbstractHero>
{
    private IInventory inventory;

    private long strength;
    private long agility;
    private long intelligence;
    private long hitPoints;
    private long damage;

    protected AbstractHero(string name, int strength, int agility, int intelligence, int hitPoints, int damage)
    { 
        this.Name = name;
        this.Strength = strength;
        this.Agility = agility;
        this.Intelligence = intelligence;
        this.HitPoints = hitPoints;
        this.Damage = damage;
        this.Inventory = new HeroInventory();
    }

    public string Name { get; private set; }

    public long Strength
    {
        get { return this.strength + this.inventory.TotalStrengthBonus; }
        set { this.strength = value; }
    }

    public long Agility
    {
        get { return this.agility + this.inventory.TotalAgilityBonus; }
        set { this.agility = value; }
    }

    public long Intelligence
    {
        get { return this.intelligence + this.inventory.TotalIntelligenceBonus; }
        set { this.intelligence = value; }
    }

    public long HitPoints
    {
        get { return this.hitPoints + this.inventory.TotalHitPointsBonus; }
        set { this.hitPoints = value; }
    }

    public long Damage
    {
        get { return this.damage + this.inventory.TotalDamageBonus; }
        set { this.damage = value; }
    }

    public long PrimaryStats
    {
        get { return this.Strength + this.Agility + this.Intelligence; }
    }

    public long SecondaryStats
    {
        get { return this.HitPoints + this.Damage; }
    }

    public IInventory Inventory
    {
        get { return this.inventory; }
        set { this.inventory = value; }
    }

    //REFLECTION
    public ICollection<IItem> Items
    {
        get
        {
            FieldInfo[] inventoryFieldInfos = this.Inventory.GetType()
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (FieldInfo fieldInfo in inventoryFieldInfos)
            {
                ItemAttribute attribute = (ItemAttribute) fieldInfo.GetCustomAttributes(typeof(ItemAttribute), true)
                    .FirstOrDefault();

                if (attribute != null)
                {
                    Dictionary<string, IItem> items = (Dictionary<string, IItem>) fieldInfo.GetValue(this.inventory);
                    return items.Select(i => i.Value).ToList();
                }
            }

           throw new Exception("something went wrong");
        }
    }

    public void AddRecipe(IRecipe recipe)
    {
        this.inventory.AddRecipeItem(recipe);
    }
    
    public int CompareTo(AbstractHero other)
    {
        if (ReferenceEquals(this, other))
        {
            return 0;
        }
        if (ReferenceEquals(null, other))
        {
            return 1;
        }
        var primary = this.PrimaryStats.CompareTo(other.PrimaryStats);
        if (primary != 0)
        {
            return primary;
        }
        return this.SecondaryStats.CompareTo(other.SecondaryStats);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        
        sb.AppendLine($"Hero: {this.Name}, Class: {this.GetType().Name}")
          .AppendLine($"HitPoints: {this.HitPoints}, Damage: {this.Damage}")
          .AppendLine($"Strength: {this.Strength}{Environment.NewLine}Agility: {this.Agility}")
          .AppendLine($"Intelligence: {this.Intelligence}")
          .Append("Items: ");

        if (this.Items.Count > 0)
        {
            sb.AppendLine();
            foreach (var item in this.Items)
            {
                sb.AppendLine(item.ToString());
            }
        }
        else
        {
            sb.Append("None");
        }
        return sb.ToString().Trim();
    }

    public string PrintFinalStatistic()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"{this.GetType().Name}: {this.Name}");
        sb.AppendLine($"###HitPoints: {this.HitPoints}{Environment.NewLine}###Damage: {this.Damage}");
        sb.AppendLine($"###Strength: {this.Strength}{Environment.NewLine}###Agility: {this.Agility}");
        sb.AppendLine($"###Intelligence: {this.Intelligence}");
        sb.Append("###Items: ");

        IList<string> items = this.Items.Select(i => i.Name).ToList();

        if (items.Count > 0)
        {
            sb.Append(string.Join(", ", items));
        }
        else
        {
            sb.AppendLine("None");
        }
        return sb.ToString().Trim();
    }
}
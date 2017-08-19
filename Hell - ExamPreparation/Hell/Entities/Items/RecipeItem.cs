using System.Collections.Generic;
using System.Linq;

public class RecipeItem : AbstractItem, IRecipe
{
    public RecipeItem(string name, int strengthBonus, int agilityBonus, int intelligenceBonus, int hitPointsBonus, int damageBonus, IList<string> requiredItems) 
        : base(name, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus, damageBonus)
    {
        this.RequiredItems = requiredItems.ToList();
    }

    public List<string> RequiredItems { get; }
}
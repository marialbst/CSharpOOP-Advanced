using System.Collections.Generic;

public class RecipeItemFake : AbstractItem, IRecipe
{
    public RecipeItemFake(params string[] requiredItems) 
        : base("Knife", 5, 15, 25, 35, 45)
    {
        this.RequiredItems = new List<string>(requiredItems);
    }

    public List<string> RequiredItems { get; }
}

//sum = 125
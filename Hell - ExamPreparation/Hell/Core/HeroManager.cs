using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class HeroManager : IManager
{
    public IDictionary<string, IHero> heroes;

    public HeroManager()
    {
        this.heroes = new Dictionary<string, IHero>();
    }

    //seems ok!!!
    public string AddHero(IList<string> arguments)
    {
        string heroName = arguments[0];
        string heroType = arguments[1];

        try
        {
            Type typeOfHero = Type.GetType(heroType);
            if (typeOfHero != null)
            {
                ConstructorInfo[] constructors = typeOfHero.GetConstructors();
                IHero hero = (IHero) constructors[0].Invoke(new object[] {heroName});
                this.heroes.Add(heroName, hero);
                return string.Format(Constants.HeroCreateMessage, hero.GetType().Name, hero.Name);
            }
        }
        catch (Exception e)
        {
            return e.Message;
        }

        return null;
    }

    public string AddItemToHero(IList<string> arguments)
    {
        string itemName = arguments[0];
        string heroName = arguments[1];
        int strengthBonus = int.Parse(arguments[2]);
        int agilityBonus = int.Parse(arguments[3]);
        int intelligenceBonus = int.Parse(arguments[4]);
        int hitPointsBonus = int.Parse(arguments[5]);
        int damageBonus = int.Parse(arguments[6]);

        IHero hero = this.heroes[heroName];
        
        IItem item = new CommonItem(itemName, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus,
            damageBonus);

        hero.Inventory.AddCommonItem(item);

        return string.Format(Constants.ItemCreateMessage, item.Name, hero.Name);
    }

    public string Inspect(IList<string> arguments)
    {
        string heroName = arguments[0];

        return this.heroes[heroName].ToString();
    }
    
    public string Quit()
    {
        IEnumerable<IHero> orderedHeroes = this.heroes.Select(h => h.Value).OrderByDescending(h => h.PrimaryStats).ThenByDescending(h=>h.SecondaryStats);
        int counter = 1;   
        StringBuilder sb = new StringBuilder();
        foreach (var hero in orderedHeroes)
        {
            sb.AppendLine($"{counter}. {hero.PrintFinalStatistic()}");
            counter++;
        }
        return sb.ToString().Trim();
    }

    public string AddRecipeToHero(IList<string> arguments)
    {
        string itemName = arguments[0];
        string heroName = arguments[1];
        int strengthBonus = int.Parse(arguments[2]);
        int agilityBonus = int.Parse(arguments[3]);
        int intelligenceBonus = int.Parse(arguments[4]);
        int hitPointsBonus = int.Parse(arguments[5]);
        int damageBonus = int.Parse(arguments[6]);
        string[] receipeItems = arguments.Skip(7).ToArray();

        IHero hero = this.heroes[heroName];
        IRecipe recipe = new RecipeItem(itemName,strengthBonus,agilityBonus,intelligenceBonus,hitPointsBonus,damageBonus,receipeItems);

        hero.AddRecipe(recipe);
        return string.Format(Constants.RecipeCreatedMessage, recipe.Name, hero.Name);
    }
}
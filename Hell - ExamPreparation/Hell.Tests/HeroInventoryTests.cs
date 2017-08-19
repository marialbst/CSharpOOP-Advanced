using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

[TestFixture]
public class HeroInventoryTests
{
    private IInventory testedObj;
    private string[] components;
    private IItem item;
    private IRecipe recipe;

    [SetUp]
    public void Initializer()
    {
        this.testedObj = new HeroInventory();
        this.components = new string[] { "Axe" };
        this.item = new CommonItemFake();
        this.recipe = new RecipeItemFake(this.components);
    }

    [Test]
    public void CreatingNewInventoryIsSuccessfull()
    {
        this.testedObj = new HeroInventory();

        Assert.Pass();
    }

    [Test]
    public void AddingNewItemChangesStrength()
    {
        this.testedObj.AddCommonItem(item);

        Assert.AreEqual(10, this.testedObj.TotalStrengthBonus);
    }

    [Test]
    public void AddingNewItemChangesInteligence()
    {
        this.testedObj.AddCommonItem(item);

        Assert.AreEqual(10, this.testedObj.TotalIntelligenceBonus);
    }

    [Test]
    public void AddingNewItemChangesDamage()
    {
        this.testedObj.AddCommonItem(item);

        Assert.AreEqual(10, this.testedObj.TotalDamageBonus);
    }

    [Test]
    public void AddingNewItemChangesAgility()
    {
        this.testedObj.AddCommonItem(item);

        Assert.AreEqual(10, this.testedObj.TotalAgilityBonus);
    }

    [Test]
    public void AddingNewItemChangesHitPoints()
    {
        this.testedObj.AddCommonItem(item);

        Assert.AreEqual(10, this.testedObj.TotalHitPointsBonus);
    }

    [Test]
    public void ChainingReceipe()
    {
        this.testedObj.AddCommonItem(this.item);
        this.testedObj.AddRecipeItem(this.recipe);

        this.item = new CommonItem("Saw", 1,2,3,4,5);
        this.testedObj.AddCommonItem(this.item);
        this.components = new[] {"Saw", "Knife"};
        IRecipe newRecipe = new RecipeItem("Baloon", 20, 10, 15, 0, 0, this.components.ToList());
        this.testedObj.AddRecipeItem(newRecipe);
        long sum = this.testedObj.TotalAgilityBonus + this.testedObj.TotalDamageBonus +
                   this.testedObj.TotalHitPointsBonus + this.testedObj.TotalIntelligenceBonus +
                   this.testedObj.TotalStrengthBonus;

        Assert.AreEqual(45, sum);
    }

    [Test]
    public void InitialStatsAreZero()
    {
        this.testedObj = new HeroInventory();

        Assert.AreEqual(0, this.testedObj.TotalAgilityBonus);
        Assert.AreEqual(0, this.testedObj.TotalDamageBonus);
        Assert.AreEqual(0, this.testedObj.TotalHitPointsBonus);
        Assert.AreEqual(0, this.testedObj.TotalIntelligenceBonus);
        Assert.AreEqual(0, this.testedObj.TotalStrengthBonus);
    }

    [Test]
    public void AddingItemIsSuccessfull()
    {
        this.testedObj.AddCommonItem(this.item);

        Assert.Pass();
    }

    [Test]
    public void AddingItemChangesStats()
    {
        this.testedObj.AddCommonItem(this.item);

        long sum = this.testedObj.TotalAgilityBonus + this.testedObj.TotalDamageBonus +
                   this.testedObj.TotalHitPointsBonus + this.testedObj.TotalIntelligenceBonus +
                   this.testedObj.TotalStrengthBonus;
        Assert.AreEqual(50, sum, "Sums are not equal");
    }

    [Test]
    public void AddingRecipeWithExistingRequiredItemsReplacesThemInInventory()
    {
        this.testedObj.AddCommonItem(this.item);
        this.testedObj.AddRecipeItem(this.recipe);

        long sumWithRecipe = this.testedObj.TotalAgilityBonus + this.testedObj.TotalDamageBonus +
                                this.testedObj.TotalHitPointsBonus + this.testedObj.TotalIntelligenceBonus +
                                this.testedObj.TotalStrengthBonus;

        Assert.AreEqual(125, sumWithRecipe, "They are not equal");
    }

    [Test]
    public void TryingToAddRecipeWithMissingComponentsChangesNothing()
    {
        this.testedObj.AddRecipeItem(this.recipe);

        long sum = this.testedObj.TotalAgilityBonus + this.testedObj.TotalDamageBonus +
                   this.testedObj.TotalHitPointsBonus + this.testedObj.TotalIntelligenceBonus +
                   this.testedObj.TotalStrengthBonus;

        Assert.AreEqual(0, sum, "They are not eqial");
    }

    [Test]
    public void TryingToAddRecipeWithMissingComponentsThenAddingTheMissingChangesNothing()
    {
        this.testedObj.AddRecipeItem(this.recipe);
        this.testedObj.AddCommonItem(this.item);
        long sum = this.testedObj.TotalAgilityBonus + this.testedObj.TotalDamageBonus +
                   this.testedObj.TotalHitPointsBonus + this.testedObj.TotalIntelligenceBonus +
                   this.testedObj.TotalStrengthBonus;

        Assert.AreEqual(125, sum, "They are not eqial");
    }

    [Test]
    public void AddReceipeItemWithNullThrowsAnException()
    {
        this.recipe = null;

        Assert.Throws<NullReferenceException>(() => this.testedObj.AddRecipeItem(this.recipe));
    }

    [Test]
    public void AddCommonItemWithNullThrowsAnException()
    {
        this.item = null;

        Assert.Throws<NullReferenceException>(() => this.testedObj.AddCommonItem(this.item));
    }

    [Test]
    public void AddExistingItemThrowsAnException()
    {
        this.testedObj.AddCommonItem(this.item);

        Assert.Throws<ArgumentException>(() => this.testedObj.AddCommonItem(this.item));
    }

    [Test]
    public void AddExistingRecipeThrowsAnException()
    {
        this.testedObj.AddRecipeItem(this.recipe);

        Assert.Throws<ArgumentException>(() => this.testedObj.AddRecipeItem(this.recipe));
    }
}
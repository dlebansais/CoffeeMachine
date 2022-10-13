namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;

[TestFixture]
internal partial class TestCoffeeMachine
{
    [Test]
    public void TestPropertyRecipeList()
    {
        BasicCoffeeMachine NewInstance = BasicCoffeeMachine.Create();

        Assert.That(NewInstance.RecipeList.Count, Is.EqualTo(5));
        Assert.That(NewInstance.RecipeList[0], Is.EqualTo(BasicRecipe.Expresso));
        Assert.That(NewInstance.RecipeList[1], Is.EqualTo(BasicRecipe.LongCoffee));
        Assert.That(NewInstance.RecipeList[2], Is.EqualTo(BasicRecipe.Cappucino));
        Assert.That(NewInstance.RecipeList[3], Is.EqualTo(BasicRecipe.Chocolate));
        Assert.That(NewInstance.RecipeList[4], Is.EqualTo(BasicRecipe.Tea));
    }
}

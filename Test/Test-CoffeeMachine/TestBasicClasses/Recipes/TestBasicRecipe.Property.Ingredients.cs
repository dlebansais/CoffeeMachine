namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
internal partial class TestBasicRecipe
{
    [Test]
    public void TestPropertyIngredients()
    {
        List<Dose> TestIngredients = new List<Dose>() { new Dose(new BasicIngredient("No name", 0)) };
        IRecipe TestRecipe = new BasicRecipe("No name", TestIngredients);
        IReadOnlyList<Dose> Ingredients = TestRecipe.Ingredients;

        Assert.That(Ingredients.Count, Is.GreaterThanOrEqualTo(1));
    }
}

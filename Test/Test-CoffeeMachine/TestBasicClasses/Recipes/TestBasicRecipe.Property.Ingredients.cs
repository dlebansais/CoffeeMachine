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
        IRecipe TestRecipe = BasicRecipe.Expresso;
        IReadOnlyList<Dose> Ingredients = TestRecipe.Ingredients;

        Assert.That(Ingredients.Count, Is.GreaterThanOrEqualTo(1));
    }
}

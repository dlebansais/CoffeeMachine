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
        IRecipe Expresso = WellKnownRecipe.Expresso;
        IReadOnlyList<Dose> Ingredients = Expresso.Ingredients;

        Assert.That(Ingredients.Count, Is.GreaterThanOrEqualTo(1));
    }
}

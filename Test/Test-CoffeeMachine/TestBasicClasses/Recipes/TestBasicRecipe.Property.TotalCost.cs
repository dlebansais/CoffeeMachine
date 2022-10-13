namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
internal partial class TestBasicRecipe
{
    [Test]
    public void TestPropertyTotalCosts()
    {
        IRecipe TestRecipe = BasicRecipe.Expresso;
        IReadOnlyList<Dose> TestIngredients = TestRecipe.Ingredients;
        double TotalCost = TestRecipe.TotalCost;

        Assert.That(TotalCost, Is.Not.NaN);
        Assert.That(TotalCost, Is.GreaterThanOrEqualTo(0));

        double TestTotalCost = 0;
        foreach (Dose Dose in TestIngredients)
            TestTotalCost += Dose.Ingredient.Cost * Dose.Quantity;

        Assert.That(TestTools.IsDoubleEqual(TestTotalCost, TotalCost), Is.True);
    }
}

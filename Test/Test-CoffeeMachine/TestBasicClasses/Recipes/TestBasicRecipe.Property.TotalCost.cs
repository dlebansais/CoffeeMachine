namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;

[TestFixture]
internal partial class TestBasicRecipe
{
    [Test]
    public void TestPropertyTotalCosts()
    {
        IRecipe Expresso = WellKnownRecipe.Expresso;
        IReadOnlyList<Dose> Ingredients = Expresso.Ingredients;
        double TotalCost = Expresso.TotalCost;

        double TestTotalCost = 0;
        foreach (Dose Dose in Ingredients)
            TestTotalCost += Dose.Ingredient.Cost * Dose.Quantity;

        Assert.That(TestTools.IsDoubleEqual(TestTotalCost, TotalCost), Is.True);
    }
}

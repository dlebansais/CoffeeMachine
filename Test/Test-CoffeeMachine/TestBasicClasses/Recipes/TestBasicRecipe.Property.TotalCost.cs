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
        IRecipe TestRecipe = BasicRecipe.Expresso;
        IReadOnlyList<Dose> TestIngredients = TestRecipe.Ingredients;
        double TotalCost = TestRecipe.TotalCost;

        Assert.That(TotalCost, Is.Not.NaN);
        Assert.That(TotalCost, Is.GreaterThanOrEqualTo(0));

        double TestTotalCost = 0;
        foreach (Dose Dose in TestIngredients)
            TestTotalCost += Dose.Ingredient.Cost * Dose.Quantity;

        Assert.That(IsDoubleEqual(TestTotalCost, TotalCost), Is.True);
    }

    // Compares equality of two doubles up to 1e-10 precision.
    // To account for different results when operations that should give the same result are implemented differently.
    private static bool IsDoubleEqual(double d1, double d2)
    {
        Debug.Assert(!double.IsNaN(d1));
        Debug.Assert(!double.IsNaN(d2));

        return Math.Abs(d2 - d1) < 1e-10;
    }
}

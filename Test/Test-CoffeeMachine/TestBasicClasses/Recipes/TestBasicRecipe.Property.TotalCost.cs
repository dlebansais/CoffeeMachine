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
        List<Dose> TestIngredients = new List<Dose>() { new Dose(new BasicIngredient("No name", 0)) };
        IRecipe TestRecipe = new BasicRecipe("No name", TestIngredients);
        double TotalCost = TestRecipe.TotalCost;

        Assert.That(TotalCost, Is.Not.NaN);
        Assert.That(TotalCost, Is.GreaterThanOrEqualTo(0));
    }
}

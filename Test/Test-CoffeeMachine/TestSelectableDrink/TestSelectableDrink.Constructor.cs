namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;
using System;

[TestFixture]
internal partial class TestSelectableDrink
{
    [Test]
    public void TestCreateNewInstance()
    {
        IRecipe TestRecipe = WellKnownRecipe.Expresso;
        double TestCostMultiplier = 2.0;
        SelectableDrink NewInstance = new SelectableDrink(TestRecipe, TestCostMultiplier);
        double ExpectedPrice = TestRecipe.TotalCost * TestCostMultiplier;

        Assert.That(NewInstance.Recipe, Is.EqualTo(TestRecipe));
        Assert.That(TestTools.IsDoubleEqual(NewInstance.Price, ExpectedPrice), Is.True);
    }

    [Test]
    public void TestCreateNewInstanceWithInvalidRecipe()
    {
        IRecipe TestRecipe = null!;
        double TestCostMultiplier = 2.0;

        Assert.Throws<ArgumentNullException>(() => new SelectableDrink(TestRecipe, TestCostMultiplier));
    }

    [Test]
    public void TestCreateNewInstanceWithInvalidMultiplier()
    {
        IRecipe TestRecipe = WellKnownRecipe.Expresso;
        double TestCostMultiplier = double.NaN;

        Assert.Throws<ArgumentException>(() => new SelectableDrink(TestRecipe, TestCostMultiplier));
    }

    [Test]
    public void TestCreateNewInstanceWithExoticMultiplier()
    {
        double[] CostMultipliers = new[]
        {
            0,
            -2.0,
            double.PositiveInfinity,
            double.NegativeInfinity,
        };

        IRecipe TestRecipe = WellKnownRecipe.Expresso;

        foreach (double Item in CostMultipliers)
        {
            SelectableDrink NewInstance = new SelectableDrink(TestRecipe, Item);

            if (double.IsPositiveInfinity(Item))
            {
                Assert.That(double.IsPositiveInfinity(NewInstance.Price), Is.True);
            }
            else if (double.IsNegativeInfinity(Item))
            {
                Assert.That(double.IsNegativeInfinity(NewInstance.Price), Is.True);
            }
            else
            {
                double ExpectedPrice = TestRecipe.TotalCost * Item;
                Assert.That(TestTools.IsDoubleEqual(NewInstance.Price, ExpectedPrice), Is.True);
            }
        }
    }
}

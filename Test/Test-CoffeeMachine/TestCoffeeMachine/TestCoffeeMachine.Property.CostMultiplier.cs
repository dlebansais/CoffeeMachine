namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
internal partial class TestCoffeeMachine
{
    [Test]
    public void TestPropertyCostMultiplier()
    {
        BasicCoffeeMachine CoffeeMachine = BasicCoffeeMachine.Create();

        Assert.That(CoffeeMachine.CostMultiplier, Is.EqualTo(1.3));
    }

    [Test]
    public void TestPropertyChangeCostMultiplier()
    {
        BasicCoffeeMachine CoffeeMachine = BasicCoffeeMachine.Create();
        double TestCostMultiplier = 2.0;
        CoffeeMachine.CostMultiplier = TestCostMultiplier;

        Assert.That(CoffeeMachine.CostMultiplier, Is.EqualTo(TestCostMultiplier));
    }

    [Test]
    public void TestPropertyPriceChanged()
    {
        BasicCoffeeMachine CoffeeMachine = BasicCoffeeMachine.Create();
        double TestCostMultiplier = 2.0;
        CoffeeMachine.CostMultiplier = TestCostMultiplier;

        IReadOnlyList<SelectableDrink> DrinkList = CoffeeMachine.DrinkList;
        foreach (SelectableDrink Item in DrinkList)
        {
            double RecipeCost = Item.Recipe.TotalCost;
            double TestPrice = RecipeCost * TestCostMultiplier;
            double Price = Item.Price;

            Assert.That(TestTools.IsDoubleEqual(Price, TestPrice), Is.True);
        }
    }
}

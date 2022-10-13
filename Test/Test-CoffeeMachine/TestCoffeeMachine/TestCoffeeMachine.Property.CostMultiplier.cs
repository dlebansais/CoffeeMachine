namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

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
    public void TestPropertyUnchangedCostMultiplier()
    {
        BasicCoffeeMachine CoffeeMachine = BasicCoffeeMachine.Create();
        double TestCostMultiplier = CoffeeMachine.CostMultiplier;
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

    [Test]
    public void TestPropertyCostMultiplierNotification()
    {
        BasicCoffeeMachine CoffeeMachine = BasicCoffeeMachine.Create();
        double TestCostMultiplier = 2.0;
        CoffeeMachine.PropertyChanged += OnCostMultiplierPropertyChanged;

        ClearLastNotification();
        CoffeeMachine.CostMultiplier = TestCostMultiplier;

        Assert.That(CoffeeMachine.CostMultiplier, Is.EqualTo(TestCostMultiplier));
        Assert.That(LastNotificationSender, Is.EqualTo(CoffeeMachine));

        PropertyChangedEventArgs? LastArgs = LastPropertyChangedEventArgs as PropertyChangedEventArgs;

        Assert.That(LastArgs, Is.Not.Null);
        Assert.That(LastArgs.PropertyName, Is.EqualTo(nameof(CoffeeMachine.CostMultiplier)));
    }

    private void OnCostMultiplierPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        LastNotificationSender = sender;
        LastPropertyChangedEventArgs = e;
    }

    private void ClearLastNotification()
    {
        LastNotificationSender = null;
        LastPropertyChangedEventArgs = EventArgs.Empty;
    }

    private object? LastNotificationSender = null;
    private EventArgs LastPropertyChangedEventArgs = EventArgs.Empty;
}

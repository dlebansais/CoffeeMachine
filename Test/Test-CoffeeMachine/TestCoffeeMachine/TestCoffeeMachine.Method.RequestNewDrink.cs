namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;
using System;
using System.Collections.Generic;

[TestFixture]
internal partial class TestCoffeeMachine
{
    [Test]
    public void TestMethodRequestNewDrink()
    {
        BasicCoffeeMachine CoffeeMachine = BasicCoffeeMachine.Create();

        IReadOnlyList<SelectableDrink> DrinkList = CoffeeMachine.DrinkList;

        for (int i = 0; i < DrinkList.Count; i++)
        {
            CoffeeMachine.RequestNewDrink(i);

            Assert.That(CoffeeMachine.LastSelection, Is.EqualTo((Selection)i));
            Assert.That(CoffeeMachine.HasDrink, Is.True);
            Assert.That(CoffeeMachine.LastDrink, Is.Not.Null);
            Assert.That(CoffeeMachine.LastDrink.Recipe, Is.EqualTo(DrinkList[i].Recipe));

            CoffeeMachine.WithdrawLastDrink();
        }
    }

    [Test]
    public void TestMethodRequestNewDrinkWithInvalidSelection()
    {
        BasicCoffeeMachine CoffeeMachine = BasicCoffeeMachine.Create();

        IReadOnlyList<SelectableDrink> DrinkList = CoffeeMachine.DrinkList;
        int InvalidSelection1 = -1;
        int InvalidSelection2 = int.MinValue;
        int InvalidSelection3 = DrinkList.Count;
        int InvalidSelection4 = int.MaxValue;

        Assert.Throws<ArgumentException>(() => CoffeeMachine.RequestNewDrink(InvalidSelection1));
        Assert.Throws<ArgumentException>(() => CoffeeMachine.RequestNewDrink(InvalidSelection2));
        Assert.Throws<ArgumentException>(() => CoffeeMachine.RequestNewDrink(InvalidSelection3));
        Assert.Throws<ArgumentException>(() => CoffeeMachine.RequestNewDrink(InvalidSelection4));
    }

    [Test]
    public void TestMethodRequestNewDrinkButBusy()
    {
        BasicCoffeeMachine CoffeeMachine = BasicCoffeeMachine.Create();

        CoffeeMachine.RequestNewDrink(0);

        Assert.Throws<CoffeeMachineException>(() => CoffeeMachine.RequestNewDrink(0));
    }
}

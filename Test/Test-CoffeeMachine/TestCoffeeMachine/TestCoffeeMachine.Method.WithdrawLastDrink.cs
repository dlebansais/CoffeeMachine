namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;
using System;
using System.Collections.Generic;

[TestFixture]
internal partial class TestCoffeeMachine
{
    [Test]
    public void TestMethodWithdrawLastDrink()
    {
        BasicCoffeeMachine CoffeeMachine = BasicCoffeeMachine.Create();

        IReadOnlyList<SelectableDrink> DrinkList = CoffeeMachine.DrinkList;

        for (int i = 0; i < DrinkList.Count; i++)
        {
            CoffeeMachine.RequestNewDrink(i);
            CoffeeMachine.WithdrawLastDrink();

            Assert.That(CoffeeMachine.LastSelection, Is.EqualTo(ICoffeeMachine.InvalidSelection));
            Assert.That(CoffeeMachine.HasDrink, Is.False);
            Assert.That(CoffeeMachine.LastDrink, Is.Null);
        }
    }

    [Test]
    public void TestMethodWithdrawLastDrinkWithInvalidState()
    {
        BasicCoffeeMachine CoffeeMachine = BasicCoffeeMachine.Create();

        Assert.Throws<CoffeeMachineException>(() => CoffeeMachine.WithdrawLastDrink());
    }

    [Test]
    public void TestMethodWithdrawLastDrinkRepeated()
    {
        BasicCoffeeMachine CoffeeMachine = BasicCoffeeMachine.Create();

        CoffeeMachine.RequestNewDrink(0);
        CoffeeMachine.WithdrawLastDrink();

        Assert.Throws<CoffeeMachineException>(() => CoffeeMachine.WithdrawLastDrink());
    }
}

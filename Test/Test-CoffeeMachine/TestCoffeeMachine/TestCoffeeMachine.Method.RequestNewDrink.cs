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

        IReadOnlyList<IRecipe> RecipeList = CoffeeMachine.RecipeList;

        for (int i = 0; i < RecipeList.Count; i++)
        {
            CoffeeMachine.RequestNewDrink(i);

            Assert.That(CoffeeMachine.LastSelection, Is.EqualTo(i));
            Assert.That(CoffeeMachine.HasDrink, Is.True);
            Assert.That(CoffeeMachine.LastDrink, Is.Not.Null);
            Assert.That(CoffeeMachine.LastDrink.Recipe, Is.EqualTo(RecipeList[i]));

            CoffeeMachine.WithdrawLastDrink();
        }
    }

    [Test]
    public void TestMethodRequestNewDrinkWithInvalidSelection()
    {
        BasicCoffeeMachine CoffeeMachine = BasicCoffeeMachine.Create();

        IReadOnlyList<IRecipe> RecipeList = CoffeeMachine.RecipeList;
        int InvalidSelection1 = -1;
        int InvalidSelection2 = int.MinValue;
        int InvalidSelection3 = RecipeList.Count;
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

        Assert.Throws<InvalidOperationException>(() => CoffeeMachine.RequestNewDrink(0));
    }
}

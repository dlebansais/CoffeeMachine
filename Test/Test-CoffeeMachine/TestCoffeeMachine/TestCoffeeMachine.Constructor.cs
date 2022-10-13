namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;

[TestFixture]
internal partial class TestCoffeeMachine
{
    [Test]
    public void TestCreateNewInstance()
    {
        BasicCoffeeMachine NewInstance = BasicCoffeeMachine.Create();

        Assert.That(NewInstance.LastSelection, Is.EqualTo(ICoffeeMachine.InvalidSelection));
        Assert.That(NewInstance.HasDrink, Is.False);
        Assert.That(NewInstance.LastDrink, Is.Null);

        Assert.That(NewInstance.DrinkList.Count, Is.EqualTo(5));
        Assert.That(NewInstance.DrinkList[0].Recipe, Is.EqualTo(WellKnownRecipe.Expresso));
        Assert.That(NewInstance.DrinkList[1].Recipe, Is.EqualTo(WellKnownRecipe.LongCoffee));
        Assert.That(NewInstance.DrinkList[2].Recipe, Is.EqualTo(WellKnownRecipe.Cappucino));
        Assert.That(NewInstance.DrinkList[3].Recipe, Is.EqualTo(WellKnownRecipe.Chocolate));
        Assert.That(NewInstance.DrinkList[4].Recipe, Is.EqualTo(WellKnownRecipe.Tea));
    }
}

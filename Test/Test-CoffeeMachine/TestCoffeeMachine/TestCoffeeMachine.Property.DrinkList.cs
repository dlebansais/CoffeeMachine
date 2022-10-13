namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;

[TestFixture]
internal partial class TestCoffeeMachine
{
    [Test]
    public void TestPropertyDrinkList()
    {
        BasicCoffeeMachine CoffeeMachine = BasicCoffeeMachine.Create();

        Assert.That(CoffeeMachine.DrinkList.Count, Is.EqualTo(5));
        Assert.That(CoffeeMachine.DrinkList[0].Recipe, Is.EqualTo(BasicRecipe.Expresso));
        Assert.That(CoffeeMachine.DrinkList[1].Recipe, Is.EqualTo(BasicRecipe.LongCoffee));
        Assert.That(CoffeeMachine.DrinkList[2].Recipe, Is.EqualTo(BasicRecipe.Cappucino));
        Assert.That(CoffeeMachine.DrinkList[3].Recipe, Is.EqualTo(BasicRecipe.Chocolate));
        Assert.That(CoffeeMachine.DrinkList[4].Recipe, Is.EqualTo(BasicRecipe.Tea));
    }
}

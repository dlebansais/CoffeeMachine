namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;

[TestFixture]
internal partial class TestBasicDrink
{
    [Test]
    public void TestCreateNewInstance()
    {
        IRecipe TestRecipe = BasicRecipe.Expresso;
        BasicDrink NewInstance = BasicDrink.Create(TestRecipe);

        Assert.That(NewInstance.Recipe, Is.EqualTo(TestRecipe));
    }
}

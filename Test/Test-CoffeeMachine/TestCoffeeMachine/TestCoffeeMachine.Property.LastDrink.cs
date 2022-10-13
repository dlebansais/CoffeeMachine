namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;

[TestFixture]
internal partial class TestCoffeeMachine
{
    [Test]
    public void TestPropertyLastDrink()
    {
        BasicCoffeeMachine NewInstance = BasicCoffeeMachine.Create();

        Assert.That(NewInstance.LastDrink, Is.Null);
    }
}

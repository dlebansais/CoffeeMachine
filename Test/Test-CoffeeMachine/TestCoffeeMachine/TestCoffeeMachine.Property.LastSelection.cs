namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;

[TestFixture]
internal partial class TestCoffeeMachine
{
    [Test]
    public void TestPropertyLastSelection()
    {
        BasicCoffeeMachine NewInstance = BasicCoffeeMachine.Create();

        Assert.That(NewInstance.LastSelection, Is.EqualTo(ICoffeeMachine.InvalidSelection));
    }
}

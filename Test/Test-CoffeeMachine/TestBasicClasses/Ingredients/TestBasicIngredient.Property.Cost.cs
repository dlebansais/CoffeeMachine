namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;

[TestFixture]
internal partial class TestBasicIngredient
{
    [Test]
    public void TestPropertyCost()
    {
        IIngredient Coffee = WellKnownIngredient.Coffee;
        double Cost = Coffee.Cost;

        Assert.That(Cost, Is.Not.NaN);
        Assert.That(Cost, Is.GreaterThanOrEqualTo(0));
    }
}

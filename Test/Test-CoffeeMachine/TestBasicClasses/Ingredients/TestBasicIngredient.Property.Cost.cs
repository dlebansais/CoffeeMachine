namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;

[TestFixture]
internal partial class TestBasicIngredient
{
    [Test]
    public void TestPropertyCost()
    {
        IIngredient TestIngredient = BasicIngredient.Coffee;
        double Cost = TestIngredient.Cost;

        Assert.That(Cost, Is.Not.NaN);
        Assert.That(Cost, Is.GreaterThanOrEqualTo(0));
    }
}

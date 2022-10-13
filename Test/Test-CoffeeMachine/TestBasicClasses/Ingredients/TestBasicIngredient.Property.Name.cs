namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;

[TestFixture]
internal partial class TestBasicIngredient
{
    [Test]
    public void TestPropertyName()
    {
        IIngredient Coffee = WellKnownIngredient.Coffee;
        string Name = Coffee.Name;

        Assert.That(Name, Is.Not.EqualTo(string.Empty));
    }
}

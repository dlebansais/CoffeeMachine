namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;

[TestFixture]
internal partial class TestBasicRecipe
{
    [Test]
    public void TestPropertyName()
    {
        IRecipe Expresso = WellKnownRecipe.Expresso;
        string Name = Expresso.Name;

        Assert.That(Name, Is.Not.EqualTo(string.Empty));
    }
}

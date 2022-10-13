namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;

[TestFixture]
internal partial class TestBasicIngredient
{
    [Test]
    public void TestPropertyName()
    {
        IIngredient TestIngredient = BasicIngredient.Coffee;
        string Name = TestIngredient.Name;

        Assert.That(Name, Is.Not.EqualTo(string.Empty));
    }
}

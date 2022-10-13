namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;

[TestFixture]
internal partial class TestBasicIngredient
{
    [Test]
    public void TestPropertyName()
    {
        IIngredient TestIngredient = new BasicIngredient("No name", 0);
        string Name = TestIngredient.Name;

        Assert.That(Name, Is.Not.EqualTo(string.Empty));
    }
}

namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
internal partial class TestBasicRecipe
{
    [Test]
    public void TestPropertyName()
    {
        IRecipe TestRecipe = BasicRecipe.Expresso;
        string Name = TestRecipe.Name;

        Assert.That(Name, Is.Not.EqualTo(string.Empty));
    }
}

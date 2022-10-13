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
        List<Dose> TestIngredients = new List<Dose>() { new Dose(new BasicIngredient("No name", 0)) };
        IRecipe TestRecipe = new BasicRecipe("No name", TestIngredients);
        string Name = TestRecipe.Name;

        Assert.That(Name, Is.Not.EqualTo(string.Empty));
    }
}

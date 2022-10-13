namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;

[TestFixture]
internal partial class TestBasicRecipe
{
    [Test]
    public void TestExpressoIsSupported()
    {
        IRecipe Expresso = WellKnownRecipe.Expresso;
        Assert.That(Expresso.Name, Is.EqualTo("Expresso"));
        Assert.That(Expresso.Ingredients.Count, Is.EqualTo(2));
        Assert.That(Expresso.Ingredients[0].Ingredient, Is.EqualTo(WellKnownIngredient.Coffee));
        Assert.That(Expresso.Ingredients[0].Quantity, Is.EqualTo(1));
        Assert.That(Expresso.Ingredients[1].Ingredient, Is.EqualTo(WellKnownIngredient.Water));
        Assert.That(Expresso.Ingredients[1].Quantity, Is.EqualTo(1));
    }

    [Test]
    public void TestLongCoffeeIsSupported()
    {
        IRecipe LongCoffee = WellKnownRecipe.LongCoffee;
        Assert.That(LongCoffee.Name, Is.EqualTo("Allongé"));
        Assert.That(LongCoffee.Ingredients.Count, Is.EqualTo(2));
        Assert.That(LongCoffee.Ingredients[0].Ingredient, Is.EqualTo(WellKnownIngredient.Coffee));
        Assert.That(LongCoffee.Ingredients[0].Quantity, Is.EqualTo(1));
        Assert.That(LongCoffee.Ingredients[1].Ingredient, Is.EqualTo(WellKnownIngredient.Water));
        Assert.That(LongCoffee.Ingredients[1].Quantity, Is.EqualTo(2));
    }

    [Test]
    public void TestCappucinoIsSupported()
    {
        IRecipe Cappucino = WellKnownRecipe.Cappucino;
        Assert.That(Cappucino.Name, Is.EqualTo("Cappucino"));
        Assert.That(Cappucino.Ingredients.Count, Is.EqualTo(4));
        Assert.That(Cappucino.Ingredients[0].Ingredient, Is.EqualTo(WellKnownIngredient.Coffee));
        Assert.That(Cappucino.Ingredients[0].Quantity, Is.EqualTo(1));
        Assert.That(Cappucino.Ingredients[1].Ingredient, Is.EqualTo(WellKnownIngredient.Chocolate));
        Assert.That(Cappucino.Ingredients[1].Quantity, Is.EqualTo(1));
        Assert.That(Cappucino.Ingredients[2].Ingredient, Is.EqualTo(WellKnownIngredient.Water));
        Assert.That(Cappucino.Ingredients[2].Quantity, Is.EqualTo(1));
        Assert.That(Cappucino.Ingredients[3].Ingredient, Is.EqualTo(WellKnownIngredient.Cream));
        Assert.That(Cappucino.Ingredients[3].Quantity, Is.EqualTo(1));
    }

    [Test]
    public void TestChocolateIsSupported()
    {
        IRecipe Chocolate = WellKnownRecipe.Chocolate;
        Assert.That(Chocolate.Name, Is.EqualTo("Chocolat"));
        Assert.That(Chocolate.Ingredients.Count, Is.EqualTo(4));
        Assert.That(Chocolate.Ingredients[0].Ingredient, Is.EqualTo(WellKnownIngredient.Chocolate));
        Assert.That(Chocolate.Ingredients[0].Quantity, Is.EqualTo(3));
        Assert.That(Chocolate.Ingredients[1].Ingredient, Is.EqualTo(WellKnownIngredient.Milk));
        Assert.That(Chocolate.Ingredients[1].Quantity, Is.EqualTo(2));
        Assert.That(Chocolate.Ingredients[2].Ingredient, Is.EqualTo(WellKnownIngredient.Water));
        Assert.That(Chocolate.Ingredients[2].Quantity, Is.EqualTo(1));
        Assert.That(Chocolate.Ingredients[3].Ingredient, Is.EqualTo(WellKnownIngredient.Sugar));
        Assert.That(Chocolate.Ingredients[3].Quantity, Is.EqualTo(1));
    }

    [Test]
    public void TestTeaIsSupported()
    {
        IRecipe Tea = WellKnownRecipe.Tea;
        Assert.That(Tea.Name, Is.EqualTo("Thé"));
        Assert.That(Tea.Ingredients.Count, Is.EqualTo(2));
        Assert.That(Tea.Ingredients[0].Ingredient, Is.EqualTo(WellKnownIngredient.Tea));
        Assert.That(Tea.Ingredients[0].Quantity, Is.EqualTo(1));
        Assert.That(Tea.Ingredients[1].Ingredient, Is.EqualTo(WellKnownIngredient.Water));
        Assert.That(Tea.Ingredients[1].Quantity, Is.EqualTo(2));
    }
}

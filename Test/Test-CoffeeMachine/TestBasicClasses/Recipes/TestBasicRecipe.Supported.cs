namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;

[TestFixture]
internal partial class TestBasicRecipe
{
    [Test]
    public void TestExpressoIsSupported()
    {
        IRecipe Expresso = BasicRecipe.Expresso;
        Assert.That(Expresso.Name, Is.EqualTo("Expresso"));
        Assert.That(Expresso.Ingredients.Count, Is.EqualTo(2));
        Assert.That(Expresso.Ingredients[0].Ingredient, Is.EqualTo(BasicIngredient.Coffee));
        Assert.That(Expresso.Ingredients[0].Quantity, Is.EqualTo(1));
        Assert.That(Expresso.Ingredients[1].Ingredient, Is.EqualTo(BasicIngredient.Water));
        Assert.That(Expresso.Ingredients[1].Quantity, Is.EqualTo(1));
    }

    [Test]
    public void TestLongCoffeeIsSupported()
    {
        IRecipe LongCoffee = BasicRecipe.LongCoffee;
        Assert.That(LongCoffee.Name, Is.EqualTo("Allongé"));
        Assert.That(LongCoffee.Ingredients.Count, Is.EqualTo(2));
        Assert.That(LongCoffee.Ingredients[0].Ingredient, Is.EqualTo(BasicIngredient.Coffee));
        Assert.That(LongCoffee.Ingredients[0].Quantity, Is.EqualTo(1));
        Assert.That(LongCoffee.Ingredients[1].Ingredient, Is.EqualTo(BasicIngredient.Water));
        Assert.That(LongCoffee.Ingredients[1].Quantity, Is.EqualTo(2));
    }

    [Test]
    public void TestCappucinoIsSupported()
    {
        IRecipe Cappucino = BasicRecipe.Cappucino;
        Assert.That(Cappucino.Name, Is.EqualTo("Cappucino"));
        Assert.That(Cappucino.Ingredients.Count, Is.EqualTo(4));
        Assert.That(Cappucino.Ingredients[0].Ingredient, Is.EqualTo(BasicIngredient.Coffee));
        Assert.That(Cappucino.Ingredients[0].Quantity, Is.EqualTo(1));
        Assert.That(Cappucino.Ingredients[1].Ingredient, Is.EqualTo(BasicIngredient.Chocolate));
        Assert.That(Cappucino.Ingredients[1].Quantity, Is.EqualTo(1));
        Assert.That(Cappucino.Ingredients[2].Ingredient, Is.EqualTo(BasicIngredient.Water));
        Assert.That(Cappucino.Ingredients[2].Quantity, Is.EqualTo(1));
        Assert.That(Cappucino.Ingredients[3].Ingredient, Is.EqualTo(BasicIngredient.Cream));
        Assert.That(Cappucino.Ingredients[3].Quantity, Is.EqualTo(1));
    }

    [Test]
    public void TestChocolateIsSupported()
    {
        IRecipe Chocolate = BasicRecipe.Chocolate;
        Assert.That(Chocolate.Name, Is.EqualTo("Chocolat"));
        Assert.That(Chocolate.Ingredients.Count, Is.EqualTo(4));
        Assert.That(Chocolate.Ingredients[0].Ingredient, Is.EqualTo(BasicIngredient.Chocolate));
        Assert.That(Chocolate.Ingredients[0].Quantity, Is.EqualTo(3));
        Assert.That(Chocolate.Ingredients[1].Ingredient, Is.EqualTo(BasicIngredient.Milk));
        Assert.That(Chocolate.Ingredients[1].Quantity, Is.EqualTo(2));
        Assert.That(Chocolate.Ingredients[2].Ingredient, Is.EqualTo(BasicIngredient.Water));
        Assert.That(Chocolate.Ingredients[2].Quantity, Is.EqualTo(1));
        Assert.That(Chocolate.Ingredients[3].Ingredient, Is.EqualTo(BasicIngredient.Sugar));
        Assert.That(Chocolate.Ingredients[3].Quantity, Is.EqualTo(1));
    }

    [Test]
    public void TestTeaIsSupported()
    {
        IRecipe Tea = BasicRecipe.Tea;
        Assert.That(Tea.Name, Is.EqualTo("Thé"));
        Assert.That(Tea.Ingredients.Count, Is.EqualTo(2));
        Assert.That(Tea.Ingredients[0].Ingredient, Is.EqualTo(BasicIngredient.Tea));
        Assert.That(Tea.Ingredients[0].Quantity, Is.EqualTo(1));
        Assert.That(Tea.Ingredients[1].Ingredient, Is.EqualTo(BasicIngredient.Water));
        Assert.That(Tea.Ingredients[1].Quantity, Is.EqualTo(2));
    }
}

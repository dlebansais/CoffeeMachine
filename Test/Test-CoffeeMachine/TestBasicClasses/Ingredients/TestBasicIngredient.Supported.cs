namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;

[TestFixture]
internal partial class TestBasicIngredient
{
    [Test]
    public void TestCoffeeIsSupported()
    {
        IIngredient Coffee = BasicIngredient.Coffee;
        Assert.That(Coffee.Name, Is.EqualTo("Café"));
        Assert.That(Coffee.Cost, Is.EqualTo(1.0));
    }

    [Test]
    public void TestSugarIsSupported()
    {
        IIngredient Sugar = BasicIngredient.Sugar;
        Assert.That(Sugar.Name, Is.EqualTo("Sucre"));
        Assert.That(Sugar.Cost, Is.EqualTo(0.1));
    }

    [Test]
    public void TestCreamIsSupported()
    {
        IIngredient Cream = BasicIngredient.Cream;
        Assert.That(Cream.Name, Is.EqualTo("Crème"));
        Assert.That(Cream.Cost, Is.EqualTo(0.5));
    }

    [Test]
    public void TestTeaIsSupported()
    {
        IIngredient Tea = BasicIngredient.Tea;
        Assert.That(Tea.Name, Is.EqualTo("Thé"));
        Assert.That(Tea.Cost, Is.EqualTo(2.0));
    }

    [Test]
    public void TestWaterIsSupported()
    {
        IIngredient Water = BasicIngredient.Water;
        Assert.That(Water.Name, Is.EqualTo("Eau"));
        Assert.That(Water.Cost, Is.EqualTo(0.2));
    }

    [Test]
    public void TestChocolateIsSupported()
    {
        IIngredient Chocolate = BasicIngredient.Chocolate;
        Assert.That(Chocolate.Name, Is.EqualTo("Chocolat"));
        Assert.That(Chocolate.Cost, Is.EqualTo(1.0));
    }

    [Test]
    public void TestMilkIsSupported()
    {
        IIngredient Milk = BasicIngredient.Milk;
        Assert.That(Milk.Name, Is.EqualTo("Lait"));
        Assert.That(Milk.Cost, Is.EqualTo(0.4));
    }
}

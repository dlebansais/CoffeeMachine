namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;

[TestFixture]
internal partial class TestBasicIngredient
{
    [Test]
    public void TestCoffeeIsSupported()
    {
        IIngredient Coffee = WellKnownIngredient.Coffee;
        Assert.That(Coffee.Name, Is.EqualTo("Café"));
        Assert.That(Coffee.Cost, Is.EqualTo(1.0));
    }

    [Test]
    public void TestSugarIsSupported()
    {
        IIngredient Sugar = WellKnownIngredient.Sugar;
        Assert.That(Sugar.Name, Is.EqualTo("Sucre"));
        Assert.That(Sugar.Cost, Is.EqualTo(0.1));
    }

    [Test]
    public void TestCreamIsSupported()
    {
        IIngredient Cream = WellKnownIngredient.Cream;
        Assert.That(Cream.Name, Is.EqualTo("Crème"));
        Assert.That(Cream.Cost, Is.EqualTo(0.5));
    }

    [Test]
    public void TestTeaIsSupported()
    {
        IIngredient Tea = WellKnownIngredient.Tea;
        Assert.That(Tea.Name, Is.EqualTo("Thé"));
        Assert.That(Tea.Cost, Is.EqualTo(2.0));
    }

    [Test]
    public void TestWaterIsSupported()
    {
        IIngredient Water = WellKnownIngredient.Water;
        Assert.That(Water.Name, Is.EqualTo("Eau"));
        Assert.That(Water.Cost, Is.EqualTo(0.2));
    }

    [Test]
    public void TestChocolateIsSupported()
    {
        IIngredient Chocolate = WellKnownIngredient.Chocolate;
        Assert.That(Chocolate.Name, Is.EqualTo("Chocolat"));
        Assert.That(Chocolate.Cost, Is.EqualTo(1.0));
    }

    [Test]
    public void TestMilkIsSupported()
    {
        IIngredient Milk = WellKnownIngredient.Milk;
        Assert.That(Milk.Name, Is.EqualTo("Lait"));
        Assert.That(Milk.Cost, Is.EqualTo(0.4));
    }
}

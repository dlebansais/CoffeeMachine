namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;
using System;

[TestFixture]
internal partial class TestDose
{
    [Test]
    public void TestCreateNewInstance()
    {
        IIngredient TestIngredient = new BasicIngredient("No name", 0);
        Dose NewInstance = new(TestIngredient);

        Assert.That(NewInstance.Ingredient, Is.EqualTo(TestIngredient));
        Assert.That(NewInstance.Quantity, Is.EqualTo(1));
    }

    [Test]
    public void TestCreateNewInstanceWithMinimalQuantity()
    {
        IIngredient TestIngredient = new BasicIngredient("No name", 0);
        int TestQuantity = 1;
        Dose NewInstance = new(TestIngredient, TestQuantity);

        Assert.That(NewInstance.Ingredient, Is.EqualTo(TestIngredient));
        Assert.That(NewInstance.Quantity, Is.EqualTo(TestQuantity));
    }

    [Test]
    public void TestCreateNewInstanceWithLargeQuantity()
    {
        IIngredient TestIngredient = new BasicIngredient("No name", 0);
        int TestQuantity = int.MaxValue;
        Dose NewInstance = new(TestIngredient, TestQuantity);

        Assert.That(NewInstance.Ingredient, Is.EqualTo(TestIngredient));
        Assert.That(NewInstance.Quantity, Is.EqualTo(TestQuantity));
    }

    [Test]
    public void TestInvalidIngredient()
    {
        IIngredient TestIngredient = null!;
        int TestQuantity = 1;

        Assert.Throws<ArgumentNullException>(() => new Dose(TestIngredient));
        Assert.Throws<ArgumentNullException>(() => new Dose(TestIngredient, TestQuantity));
    }

    [Test]
    public void TestInvalidQuantity()
    {
        IIngredient TestIngredient = new BasicIngredient("No name", 0);
        int TestQuantityInvalid1 = 0;
        int TestQuantityInvalid2 = -1;
        int TestQuantityInvalid3 = int.MinValue;

        Assert.Throws<ArgumentException>(() => new Dose(TestIngredient, TestQuantityInvalid1));
        Assert.Throws<ArgumentException>(() => new Dose(TestIngredient, TestQuantityInvalid2));
        Assert.Throws<ArgumentException>(() => new Dose(TestIngredient, TestQuantityInvalid3));
    }
}

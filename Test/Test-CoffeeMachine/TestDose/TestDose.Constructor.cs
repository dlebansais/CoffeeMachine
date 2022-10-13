namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;

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
}

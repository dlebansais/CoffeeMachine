namespace TestCoffeeMachine;

using CoffeeMachine;
using NUnit.Framework;

[TestFixture]
internal partial class TestResourceManager
{
    [Test]
    public void TestResourceFound()
    {
        string TestString = "Should not be used";
        string ReadResult = ResourceManagerHelper.ReadString(nameof(WellKnownIngredient.Coffee), TestString);

        Assert.That(ReadResult, Is.Not.EqualTo(TestString));
    }

    [Test]
    public void TestResourceNotFound()
    {
        string TestString = "Should be used";
        string ReadResult = ResourceManagerHelper.ReadString(string.Empty, TestString);

        Assert.That(ReadResult, Is.EqualTo(TestString));
    }
}

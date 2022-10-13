namespace CoffeeMachine;

/// <summary>
/// Well-known ingredients for a coffee machine.
/// </summary>
internal static class WellKnownIngredient
{
    /// <summary>
    /// Gets the default coffee ingredient.
    /// </summary>
    internal static BasicIngredient Coffee { get; } = new(ResourceManagerHelper.ReadString(nameof(Coffee), "Coffee"), 1.0);

    /// <summary>
    /// Gets the default sugar ingredient.
    /// </summary>
    internal static BasicIngredient Sugar { get; } = new(ResourceManagerHelper.ReadString(nameof(Sugar), "Sugar"), 0.1);

    /// <summary>
    /// Gets the default cream ingredient.
    /// </summary>
    internal static BasicIngredient Cream { get; } = new(ResourceManagerHelper.ReadString(nameof(Cream), "Cream"), 0.5);

    /// <summary>
    /// Gets the default tea ingredient.
    /// </summary>
    internal static BasicIngredient Tea { get; } = new(ResourceManagerHelper.ReadString(nameof(Tea), "Tea"), 2.0);

    /// <summary>
    /// Gets the default water ingredient.
    /// </summary>
    internal static BasicIngredient Water { get; } = new(ResourceManagerHelper.ReadString(nameof(Water), "Water"), 0.2);

    /// <summary>
    /// Gets the default chocolate ingredient.
    /// </summary>
    internal static BasicIngredient Chocolate { get; } = new(ResourceManagerHelper.ReadString(nameof(Chocolate), "Chocolate"), 1.0);

    /// <summary>
    /// Gets the default milk ingredient.
    /// </summary>
    internal static BasicIngredient Milk { get; } = new(ResourceManagerHelper.ReadString(nameof(Milk), "Milk"), 0.4);
}

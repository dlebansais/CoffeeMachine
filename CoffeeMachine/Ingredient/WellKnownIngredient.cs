namespace CoffeeMachine;

/// <summary>
/// Well-known ingredients for a coffee machine.
/// </summary>
internal static class WellKnownIngredient
{
    /// <summary>
    /// Gets the default coffee ingredient.
    /// </summary>
    internal static BasicIngredient Coffee { get; } = new("Café", 1.0);

    /// <summary>
    /// Gets the default sugar ingredient.
    /// </summary>
    internal static BasicIngredient Sugar { get; } = new("Sucre", 0.1);

    /// <summary>
    /// Gets the default cream ingredient.
    /// </summary>
    internal static BasicIngredient Cream { get; } = new("Crème", 0.5);

    /// <summary>
    /// Gets the default tea ingredient.
    /// </summary>
    internal static BasicIngredient Tea { get; } = new("Thé", 2.0);

    /// <summary>
    /// Gets the default water ingredient.
    /// </summary>
    internal static BasicIngredient Water { get; } = new("Eau", 0.2);

    /// <summary>
    /// Gets the default chocolate ingredient.
    /// </summary>
    internal static BasicIngredient Chocolate { get; } = new("Chocolat", 1.0);

    /// <summary>
    /// Gets the default milk ingredient.
    /// </summary>
    internal static BasicIngredient Milk { get; } = new("Lait", 0.4);
}

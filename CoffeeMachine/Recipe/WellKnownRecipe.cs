namespace CoffeeMachine;

using System.Collections.Generic;
using System.Diagnostics;

/// <summary>
/// Well-known recipes for a coffee machine.
/// </summary>
internal class WellKnownRecipe
{
    /// <summary>
    /// Gets the default Expresso recipe.
    /// </summary>
    internal static BasicRecipe Expresso { get; } = new("Expresso", new List<Dose>()
    {
        new Dose(WellKnownIngredient.Coffee),
        new Dose(WellKnownIngredient.Water),
    });

    /// <summary>
    /// Gets the default long coffee recipe.
    /// </summary>
    internal static BasicRecipe LongCoffee { get; } = new("Allongé", new List<Dose>()
    {
        new Dose(WellKnownIngredient.Coffee),
        new Dose(WellKnownIngredient.Water, 2),
    });

    /// <summary>
    /// Gets the default cappucino recipe.
    /// </summary>
    internal static BasicRecipe Cappucino { get; } = new("Cappucino", new List<Dose>()
    {
        new Dose(WellKnownIngredient.Coffee),
        new Dose(WellKnownIngredient.Chocolate),
        new Dose(WellKnownIngredient.Water),
        new Dose(WellKnownIngredient.Cream),
    });

    /// <summary>
    /// Gets the default chocolate recipe.
    /// </summary>
    internal static BasicRecipe Chocolate { get; } = new("Chocolat", new List<Dose>()
    {
        new Dose(WellKnownIngredient.Chocolate, 3),
        new Dose(WellKnownIngredient.Milk, 2),
        new Dose(WellKnownIngredient.Water),
        new Dose(WellKnownIngredient.Sugar),
    });

    /// <summary>
    /// Gets the default tea recipe.
    /// </summary>
    internal static BasicRecipe Tea { get; } = new("Thé", new List<Dose>()
    {
        new Dose(WellKnownIngredient.Tea),
        new Dose(WellKnownIngredient.Water, 2),
    });
}

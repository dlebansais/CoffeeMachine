namespace CoffeeMachine;

using System;

/// <summary>
/// Represents a drink with a price.
/// </summary>
public record SelectableDrink
{
    #region Init
    /// <summary>
    /// Initializes a new instance of the <see cref="SelectableDrink"/> class.
    /// </summary>
    /// <param name="recipe">The recipe for this drink.</param>
    /// <param name="costMultiplier">The multiplier to apply to the recipe cost.</param>
    /// <exception cref="ArgumentException">The cost multiplier is invalid.</exception>
    public SelectableDrink(IRecipe recipe, double costMultiplier)
    {
        Recipe = recipe;
        Price = Recipe.TotalCost * costMultiplier;
    }
    #endregion

    #region Properties
    /// <summary>
    /// Gets the recipe.
    /// </summary>
    public IRecipe Recipe { get; }

    /// <summary>
    /// Gets the price.
    /// </summary>
    public double Price { get; private set; }
    #endregion
}

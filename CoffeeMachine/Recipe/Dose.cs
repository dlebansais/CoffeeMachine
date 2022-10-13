namespace CoffeeMachine;

using System.Diagnostics;

/// <summary>
/// Represents a dose of ingredients.
/// </summary>
public record Dose
{
    #region Init
    /// <summary>
    /// Initializes a new instance of the <see cref="Dose"/> class.
    /// This constructor can be used when quantity is 1.
    /// </summary>
    /// <param name="ingredient">The ingredient for this dose.</param>
    public Dose(IIngredient ingredient)
        : this(ingredient, 1)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Dose"/> class.
    /// </summary>
    /// <param name="ingredient">The ingredient for this dose.</param>
    /// <param name="quantity">The quantity of ingredient in the dose. Must be 1 or greater.</param>
    public Dose(IIngredient ingredient, int quantity)
    {
        // Perform safety checks.
        Debug.Assert(quantity >= 1);

        Ingredient = ingredient;
        Quantity = quantity;
    }
    #endregion

    #region Properties
    /// <summary>
    /// Gets the ingredient.
    /// </summary>
    public IIngredient Ingredient { get; }

    /// <summary>
    /// Gets the quantity. This is always 1 or greater.
    /// </summary>
    public int Quantity { get; }
    #endregion
}

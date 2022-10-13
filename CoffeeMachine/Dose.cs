namespace CoffeeMachine;

using System;
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
    /// <exception cref="ArgumentException">The quantity of ingredient in the dose must be 1 or greater.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="ingredient"/> must not be null.</exception>
    public Dose(IIngredient ingredient, int quantity)
    {
        if (ingredient is null)
            throw new ArgumentNullException(nameof(ingredient));

        if (quantity < 1)
            throw new ArgumentException("The quantity of ingredient in the dose must be 1 or greater.", nameof(quantity));

        Ingredient = ingredient;
        Quantity = quantity;

        Debug.Assert(Quantity >= 1);
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

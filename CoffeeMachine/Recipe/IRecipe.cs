namespace CoffeeMachine;

using System.Collections.Generic;

/// <summary>
/// Recipe for a drink made of one or more ingredient.
/// </summary>
public interface IRecipe
{
    /// <summary>
    /// Gets the recipe name.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Gets the list of ingredients.
    /// </summary>
    IReadOnlyList<Dose> Ingredients { get; }

    /// <summary>
    /// Gets the recipe total cost. The cost is garanteed to be zero or greater.
    /// </summary>
    double TotalCost { get; }
}

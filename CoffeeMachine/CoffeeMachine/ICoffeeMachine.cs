namespace CoffeeMachine;

using System;
using System.Collections.Generic;

/// <summary>
/// Interface for a coffee machine that distributes drinks.
/// </summary>
public interface ICoffeeMachine
{
    /// <summary>
    /// The invalid value for a selection.
    /// </summary>
    public const int InvalidSelection = -1;

    /// <summary>
    /// Gets the list of available recipes.
    /// </summary>
    IReadOnlyList<IRecipe> RecipeList { get; }

    /// <summary>
    /// Gets the last selection, <see cref="InvalidSelection"/> if no drink has been distributed yet.
    /// </summary>
    int LastSelection { get; }

    /// <summary>
    /// Gets the last drink, null if not drink has been distributed yet.
    /// </summary>
    IDrink? LastDrink { get; }

    /// <summary>
    /// Gets a value indicating whether a drink has been distributed.
    /// </summary>
    bool HasDrink { get; }

    /// <summary>
    /// Requests another drink to be distributed.
    /// </summary>
    /// <param name="selectedRecipe">The selected drink. Must be greater than or equal to zero, and less than the number of available recipes.</param>
    void RequestNewDrink(int selectedRecipe);

    /// <summary>
    /// Withdraw the last distributed drink. This will reset <see cref="LastDrink"/>.
    /// </summary>
    void WithdrawLastDrink();
}

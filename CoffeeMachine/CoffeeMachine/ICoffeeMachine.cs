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
    /// Gets the list of available drinks.
    /// </summary>
    IReadOnlyList<SelectableDrink> DrinkList { get; }

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
    /// <exception cref="ArgumentException">The selected drink is not greater than or equal to zero and less than the number of available recipes.</exception>
    /// <exception cref="CoffeeMachineException">There is no drink to withdraw. Use <see cref="HasDrink"/> to detect if there is one before calling this method.</exception>
    void RequestNewDrink(int selectedRecipe);

    /// <summary>
    /// Withdraw the last distributed drink. This will reset <see cref="LastDrink"/>.
    /// </summary>
    /// <exception cref="CoffeeMachineException">There is no drink to withdraw. Use <see cref="HasDrink"/> to detect if there is one before calling this method.</exception>
    void WithdrawLastDrink();
}

namespace CoffeeMachine;

using System;
using System.Collections.Generic;

/// <summary>
/// Represents a coffee machine that distributes drinks.
/// </summary>
public class BasicCoffeeMachine : ICoffeeMachine
{
    #region Init
    /// <summary>
    /// Create a new instance of <see cref="BasicCoffeeMachine"/>.
    /// </summary>
    /// <returns>The new instance.</returns>
    public static BasicCoffeeMachine Create()
    {
        return new BasicCoffeeMachine();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BasicCoffeeMachine"/> class.
    /// </summary>
    protected BasicCoffeeMachine()
    {
        LastSelection = ICoffeeMachine.InvalidSelection;
        RecipeList = new List<IRecipe>().AsReadOnly();
    }
    #endregion

    #region Properties
    /// <summary>
    /// Gets the list of available recipes.
    /// </summary>
    public IReadOnlyList<IRecipe> RecipeList { get; }

    /// <summary>
    /// Gets the last selection, -1 if no drink has been distributed yet.
    /// </summary>
    public int LastSelection { get; private set; }

    /// <summary>
    /// Gets the last drink, null if not drink has been distributed yet.
    /// </summary>
    public IDrink? LastDrink { get; private set; }

    /// <summary>
    /// Gets a value indicating whether a drink has been distributed.
    /// </summary>
    public bool HasDrink { get { return LastDrink is not null; } }
    #endregion

    #region Client Interface
    /// <summary>
    /// Requests another drink to be distributed.
    /// </summary>
    /// <param name="selectedRecipe">The selected recipe. Must be greater than or equal to zero, and less than the number of available recipes.</param>
    public void RequestNewDrink(int selectedRecipe)
    {
    }

    /// <summary>
    /// Withdraws the last distributed drink. This will reset <see cref="LastSelection"/> and <see cref="LastDrink"/>.
    /// </summary>
    public void WithdrawLastDrink()
    {
    }
    #endregion
}

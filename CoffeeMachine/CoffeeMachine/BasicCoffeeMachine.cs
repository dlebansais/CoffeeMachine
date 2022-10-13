namespace CoffeeMachine;

using System;
using System.Collections.Generic;
using System.Diagnostics;

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
        InternalRecipeList = new();
        RecipeList = InitializedListOfSupportedRecipes();
    }

    // Create the default list of supported recipes.
    private IReadOnlyList<IRecipe> InitializedListOfSupportedRecipes()
    {
        List<IRecipe> DefaultRecipeList = new()
        {
            BasicRecipe.Expresso,
            BasicRecipe.LongCoffee,
            BasicRecipe.Cappucino,
            BasicRecipe.Chocolate,
            BasicRecipe.Tea,
        };

        // Add default recipes.
        InternalRecipeList.AddRange(DefaultRecipeList);

        return InternalRecipeList.AsReadOnly();
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
    /// <exception cref="ArgumentException">The selected recipe is not greater than or equal to zero and less than the number of available recipes.</exception>
    /// <exception cref="InvalidOperationException">There is a drink to withdraw. Use <see cref="WithdrawLastDrink"/> and try again.</exception>
    public void RequestNewDrink(int selectedRecipe)
    {
        if (HasDrink)
            throw new InvalidOperationException("There is a drink to withdraw. Use the WithdrawLastDrink() method and try again.");

        LastSelection = ValidatedSelection(selectedRecipe);
        LastDrink = CreateDrinkFromSelection();
    }

    /// <summary>
    /// Withdraws the last distributed drink. This will reset <see cref="LastSelection"/> and <see cref="LastDrink"/>.
    /// </summary>
    /// <exception cref="InvalidOperationException">There is no drink to withdraw. Use <see cref="HasDrink"/> to detect if there is one before calling this method.</exception>
    public void WithdrawLastDrink()
    {
        if (!HasDrink)
            throw new InvalidOperationException("There is no drink to withdraw. Use the HasDrink property to detect if there is one before calling this method.");

        ClearLastSelectionAndLastDrink();
    }
    #endregion

    #region Descendant Interface
    /// <summary>
    /// Validates a recipe selection.
    /// </summary>
    /// <param name="selectedRecipe">The selected recipe.</param>
    /// <returns>The value of <paramref name="selectedRecipe"/> if valid; otherwise, throws an exception.</returns>
    /// <exception cref="ArgumentException">The selected recipe is not greater than or equal to zero and less than the number of available recipes.</exception>
    protected virtual int ValidatedSelection(int selectedRecipe)
    {
        return IsSelectionValid(selectedRecipe) ? selectedRecipe : throw new ArgumentException("The selected recipe is not greater than or equal to zero and less than the number of available recipes.", nameof(selectedRecipe));
    }

    /// <summary>
    /// Checks whether a selection is valid. This method does not throw an exception.
    /// </summary>
    /// <param name="selectedRecipe">The selected recipe.</param>
    /// <returns>True if valid; otherwise, false.</returns>
    protected virtual bool IsSelectionValid(int selectedRecipe)
    {
        return selectedRecipe >= 0 && selectedRecipe < RecipeList.Count;
    }

    /// <summary>
    /// Set the new drink selection.
    /// </summary>
    /// <param name="selectedRecipe">The newly selected recipe for the drink.</param>
    protected virtual void SetNewSelection(int selectedRecipe)
    {
        Debug.Assert(IsSelectionValid(selectedRecipe));

        LastSelection = selectedRecipe;
    }

    /// <summary>
    /// Creates a drink from the selection in <see cref="LastSelection"/>.
    /// The selection in <see cref="LastSelection"/> must be valid.
    /// </summary>
    /// <returns>The new drink.</returns>
    protected virtual IDrink CreateDrinkFromSelection()
    {
        Debug.Assert(IsSelectionValid(LastSelection));

        IRecipe SelectedRecipe = RecipeList[LastSelection];
        BasicDrink NewDrink = BasicDrink.Create(SelectedRecipe);

        return NewDrink;
    }

    /// <summary>
    /// Clears the last selection and last drink.
    /// </summary>
    protected virtual void ClearLastSelectionAndLastDrink()
    {
        ClearLastSelection();
        ClearLastDrink();
    }

    /// <summary>
    /// Clears the last selection.
    /// </summary>
    protected virtual void ClearLastSelection()
    {
        LastSelection = ICoffeeMachine.InvalidSelection;
    }

    /// <summary>
    /// Clears the last drink.
    /// </summary>
    protected virtual void ClearLastDrink()
    {
        LastDrink = null;
    }

    /// <summary>
    /// Gets the internal list of recipes. This list can be extended by descendants.
    /// </summary>
    protected List<IRecipe> InternalRecipeList { get; }
    #endregion
}

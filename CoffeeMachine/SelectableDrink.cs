namespace CoffeeMachine;

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

/// <summary>
/// Represents a drink with a price.
/// </summary>
public record SelectableDrink : INotifyPropertyChanged
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
        if (recipe is null)
            throw new ArgumentNullException(nameof(recipe));

        ValidateCostMultiplier(costMultiplier, nameof(costMultiplier));

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

    #region Client Interface
    /// <summary>
    /// Updates the drink price.
    /// </summary>
    /// <param name="newCostMultiplier">The new multiplier to apply to the recipe cost.</param>
    /// <exception cref="ArgumentException">The cost multiplier is invalid.</exception>
    public void ChangePrice(double newCostMultiplier)
    {
        ValidateCostMultiplier(newCostMultiplier, nameof(newCostMultiplier));

        Price = Recipe.TotalCost * newCostMultiplier;
        NotifyPropertyChanged(nameof(Price));
    }
    #endregion

    #region Implementation
    private void ValidateCostMultiplier(double costMultiplier, string paramName)
    {
        if (double.IsNaN(costMultiplier))
            throw new ArgumentException("Invalid cost multiplier.", paramName);
    }
    #endregion

    #region Implementation of INotifyPropertyChanged
    /// <summary>
    /// Implements the PropertyChanged event.
    /// </summary>
#nullable disable annotations
    public event PropertyChangedEventHandler PropertyChanged;
#nullable restore annotations

    internal void NotifyPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion
}

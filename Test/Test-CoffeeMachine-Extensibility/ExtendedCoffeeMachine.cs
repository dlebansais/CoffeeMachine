using System.Collections.Generic;

namespace CoffeeMachine;

/// <summary>
/// Extended coffee machine.
/// </summary>
internal class ExtendedCoffeeMachine : BasicCoffeeMachine
{
    #region Init
    /// <summary>
    /// Create a new instance of <see cref="ExtendedCoffeeMachine"/>.
    /// </summary>
    /// <param name="manufacturerName">The manufacturer name.</param>
    /// <returns>The new instance.</returns>
    public static ExtendedCoffeeMachine Create(string manufacturerName)
    {
        return new ExtendedCoffeeMachine(manufacturerName);
    }

    /// <inheritdoc/>
    /// <param name="manufacturerName">The manufacturer name.</param>
    internal ExtendedCoffeeMachine(string manufacturerName)
    {
        ManufacturerName = manufacturerName;

        ExtendedIngredient Lemon = new ExtendedIngredient("Citron", 0.8, carbonCost: 3.0);
        List<Dose> TeaWithLemonIngredients = new() { new Dose(WellKnownIngredient.Tea, 2), new Dose(Lemon) };
        ExtendedRecipe TeaWithLemon = new ExtendedRecipe("Thé au citron", TeaWithLemonIngredients, "Boisson du jour");
        SelectableDrink TodaysSpecialDrink = new(TeaWithLemon, costMultiplier: 1.4);
        InternalDrinkList.Add(TodaysSpecialDrink);
    }
    #endregion

    #region Properties
    /// <summary>
    /// Gets the manufacturer name.
    /// </summary>
    public string ManufacturerName { get; }
    #endregion
}

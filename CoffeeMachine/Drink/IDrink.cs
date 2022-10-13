namespace CoffeeMachine;

/// <summary>
/// Interface for a drink distributed by a <see cref="ICoffeeMachine"/>.
/// </summary>
public interface IDrink
{
    /// <summary>
    /// Gets the recipe used to create this drink.
    /// </summary>
    IRecipe Recipe { get; }
}

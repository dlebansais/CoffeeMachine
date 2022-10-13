namespace CoffeeMachine;

/// <summary>
/// Represents a drink distributed by a <see cref="ICoffeeMachine"/>.
/// </summary>
internal class BasicDrink : IDrink
{
    /// <summary>
    /// Creates a new instance of <see cref="BasicDrink"/>.
    /// </summary>
    /// <param name="recipe">The recipe used to create the drink.</param>
    public static BasicDrink Create(IRecipe recipe)
    {
        return new BasicDrink(recipe);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BasicDrink"/> class.
    /// </summary>
    /// <param name="recipe">The recipe used to create the drink.</param>
    protected BasicDrink(IRecipe recipe)
    {
        Recipe = recipe;
    }

    /// <summary>
    /// Gets the recipe used to create this drink.
    /// </summary>
    public IRecipe Recipe { get; }
}

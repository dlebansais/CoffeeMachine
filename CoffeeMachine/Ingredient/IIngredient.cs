namespace CoffeeMachine;

/// <summary>
/// Ingredient for a coffee machine.
/// </summary>
public interface IIngredient
{
    /// <summary>
    /// Gets the ingredient name.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Gets the ingredient cost.
    /// </summary>
    double Cost { get; }
}

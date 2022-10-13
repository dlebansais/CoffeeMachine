namespace CoffeeMachine;

/// <summary>
/// Extended ingredient for a coffee machine.
/// </summary>
internal class ExtendedIngredient : BasicIngredient
{
    #region Init
    /// <inheritdoc/>
    /// <param name="name"><inheritdoc cref="BasicIngredient(string, double)" path="/param[@name='name']"/></param>
    /// <param name="cost"><inheritdoc cref="BasicIngredient(string, double)" path="/param[@name='cost']"/></param>
    /// <param name="carbonCost">Ingredient carbon cost.</param>
    internal ExtendedIngredient(string name, double cost, double carbonCost)
        : base(name, cost)
    {
        CarbonCost = carbonCost;
    }
    #endregion

    #region Properties
    /// <summary>
    /// Gets the ingredient carbon cost.
    /// </summary>
    public double CarbonCost { get; }
    #endregion
}

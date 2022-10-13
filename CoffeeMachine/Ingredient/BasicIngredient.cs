namespace CoffeeMachine;

using System.Diagnostics;

/// <summary>
/// Basic ingredient for a coffee machine, with only a name and a cost.
/// </summary>
internal class BasicIngredient : IIngredient
{
    #region Default Ingredients
    /// <summary>
    /// Gets the default coffee ingredient.
    /// </summary>
    internal static BasicIngredient Coffee { get; } = new("Café", 1.0);

    /// <summary>
    /// Gets the default sugar ingredient.
    /// </summary>
    internal static BasicIngredient Sugar { get; } = new("Sucre", 0.1);

    /// <summary>
    /// Gets the default cream ingredient.
    /// </summary>
    internal static BasicIngredient Cream { get; } = new("Crème", 0.5);

    /// <summary>
    /// Gets the default tea ingredient.
    /// </summary>
    internal static BasicIngredient Tea { get; } = new("Thé", 2.0);

    /// <summary>
    /// Gets the default water ingredient.
    /// </summary>
    internal static BasicIngredient Water { get; } = new("Eau", 0.2);

    /// <summary>
    /// Gets the default chocolate ingredient.
    /// </summary>
    internal static BasicIngredient Chocolate { get; } = new("Chocolat", 1.0);

    /// <summary>
    /// Gets the default milk ingredient.
    /// </summary>
    internal static BasicIngredient Milk { get; } = new("Lait", 0.4);
    #endregion

    #region Init
    /// <summary>
    /// Initializes a new instance of the <see cref="BasicIngredient"/> class.
    /// </summary>
    /// <param name="name">The ingredient name. The name must not empty or just blank.</param>
    /// <param name="cost">The ingredient cost. The cost must be a positive value or zero.</param>
    protected BasicIngredient(string name, double cost)
    {
        // Perform safety checks.
        Debug.Assert(name.Trim() != string.Empty);
        Debug.Assert(!double.IsNaN(cost));
        Debug.Assert(cost >= 0);

        Name = name;
        Cost = cost;
    }
    #endregion

    #region Properties
    /// <summary>
    /// Gets the ingredient name.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the ingredient cost.
    /// </summary>
    public double Cost { get; }
    #endregion
}

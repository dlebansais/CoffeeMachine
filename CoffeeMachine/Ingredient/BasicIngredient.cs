namespace CoffeeMachine;

using System.Diagnostics;

/// <summary>
/// Basic ingredient for a coffee machine, with only a name and a cost.
/// </summary>
internal class BasicIngredient : IIngredient
{
    #region Init
    /// <summary>
    /// Initializes a new instance of the <see cref="BasicIngredient"/> class.
    /// </summary>
    /// <param name="name">The ingredient name. The name must not empty or just blank.</param>
    /// <param name="cost">The ingredient cost. The cost must be a positive value or zero.</param>
    public BasicIngredient(string name, double cost)
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

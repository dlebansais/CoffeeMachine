namespace CoffeeMachine;

using System.Collections.Generic;

/// <summary>
/// Extended drink for a coffee machine.
/// </summary>
internal class ExtendedDrink : BasicDrink
{
    #region Init
    /// <inheritdoc/>
    /// <param name="recipe"><inheritdoc cref="BasicDrink(IRecipe)" path="/param[@name='recipe']"/></param>
    /// <param name="isSoldOut">A value indicating whether the drink is sold out.</param>
    internal ExtendedDrink(IRecipe recipe, bool isSoldOut)
        : base(recipe)
    {
        IsSoldOut = isSoldOut;
    }
    #endregion

    #region Properties
    /// <summary>
    /// Gets a value indicating whether the drink is sold out.
    /// </summary>
    public bool IsSoldOut { get; }
    #endregion
}

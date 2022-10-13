namespace CoffeeMachine;

using System.Collections.Generic;

/// <summary>
/// Extended recipe for a coffee machine.
/// </summary>
internal class ExtendedRecipe : BasicRecipe
{
    #region Init
    /// <inheritdoc/>
    /// <param name="name"><inheritdoc cref="BasicRecipe(string, IReadOnlyCollection{Dose})" path="/param[@name='name']"/></param>
    /// <param name="ingredients"><inheritdoc cref="BasicRecipe(string, IReadOnlyCollection{Dose})" path="/param[@name='ingredients']"/></param>
    /// <param name="comment">Recipe comment.</param>
    internal ExtendedRecipe(string name, IReadOnlyCollection<Dose> ingredients, string comment)
        : base(name, ingredients)
    {
        Comment = comment;
    }
    #endregion

    #region Properties
    /// <summary>
    /// Gets the comment.
    /// </summary>
    public string Comment { get; }
    #endregion
}

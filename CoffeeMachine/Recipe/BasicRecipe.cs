namespace CoffeeMachine;

using System.Collections.Generic;
using System.Diagnostics;

/// <summary>
/// Basic recipe for a coffee machine, with only a name and a list of ingredients.
/// </summary>
internal class BasicRecipe : IRecipe
{
    #region Default Recipes
    /// <summary>
    /// Gets the default Expresso recipe.
    /// </summary>
    internal static BasicRecipe Expresso { get; } = new("Expresso", new List<Dose>()
    {
        new Dose(BasicIngredient.Coffee),
        new Dose(BasicIngredient.Water),
    });

    /// <summary>
    /// Gets the default long coffee recipe.
    /// </summary>
    internal static BasicRecipe LongCoffee { get; } = new("Allongé", new List<Dose>()
    {
        new Dose(BasicIngredient.Coffee),
        new Dose(BasicIngredient.Water, 2),
    });

    /// <summary>
    /// Gets the default cappucino recipe.
    /// </summary>
    internal static BasicRecipe Cappucino { get; } = new("Cappucino", new List<Dose>()
    {
        new Dose(BasicIngredient.Coffee),
        new Dose(BasicIngredient.Chocolate),
        new Dose(BasicIngredient.Water),
        new Dose(BasicIngredient.Cream),
    });

    /// <summary>
    /// Gets the default chocolate recipe.
    /// </summary>
    internal static BasicRecipe Chocolate { get; } = new("Chocolat", new List<Dose>()
    {
        new Dose(BasicIngredient.Chocolate, 3),
        new Dose(BasicIngredient.Milk, 2),
        new Dose(BasicIngredient.Water),
        new Dose(BasicIngredient.Sugar),
    });

    /// <summary>
    /// Gets the default tea recipe.
    /// </summary>
    internal static BasicRecipe Tea { get; } = new("Thé", new List<Dose>()
    {
        new Dose(BasicIngredient.Tea),
        new Dose(BasicIngredient.Water, 2),
    });
    #endregion

    #region Init
    /// <summary>
    /// Initializes a new instance of the <see cref="BasicRecipe"/> class.
    /// </summary>
    /// <param name="name">The recipe name. The name must not empty or just blank.</param>
    /// <param name="ingredients">The list of ingredients. There must be at least one ingredient.</param>
    protected BasicRecipe(string name, IReadOnlyCollection<Dose> ingredients)
    {
        // Perform safety checks.
        Debug.Assert(name.Trim() != string.Empty);
        Debug.Assert(ingredients.Count > 0);

        Name = name;

        // Make a new copy of ingredients to keep it constant even if the caller changes the source list afterwards.
        List<Dose> IngredientListCopy = new(ingredients);
        Ingredients = IngredientListCopy.AsReadOnly();

        TotalCost = 0;
        foreach (Dose Item in Ingredients)
            TotalCost += Item.Ingredient.Cost * Item.Quantity;

        // All ingredients have a definite positive cost, and the sum of numbers all zero or greater is always zero or greater.
        Debug.Assert(!double.IsNaN(TotalCost));
        Debug.Assert(TotalCost >= 0);
    }
    #endregion

    #region Properties
    /// <summary>
    /// Gets the ingredient name.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the list of ingredients.
    /// </summary>
    public IReadOnlyList<Dose> Ingredients { get; }

    /// <summary>
    /// Gets the recipe total cost. The cost is garanteed to be zero or greater.
    /// </summary>
    public double TotalCost { get; }
    #endregion
}

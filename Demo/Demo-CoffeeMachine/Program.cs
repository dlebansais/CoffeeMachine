using System.Globalization;
using System;
using CoffeeMachine;

internal class Program
{
    internal static void Main(string[] args)
    {
        // Initializing the coffee machine.
        ICoffeeMachine CoffeeMachine = BasicCoffeeMachine.Create();

        // Display available drinks.
        Console.WriteLine("Veuillez choisir une boisson :");

        for (int Index = 0; Index < CoffeeMachine.DrinkList.Count; Index++)
        {
            SelectableDrink Item = CoffeeMachine.DrinkList[Index];
            IRecipe Recipe = Item.Recipe;
            string RecipeName = Recipe.Name;
            int SelectionIndex = Index + 1;
            string Line = $"{SelectionIndex} : {RecipeName}";

            Console.WriteLine(Line);
        }

        Console.WriteLine("Pour quitter, appuyez sur Ctrl+C.");

        // Perform selection until Ctrl+C.
        for (; ; )
        {
            // Read the next key from the console.
            ConsoleKeyInfo KeyInfo = Console.ReadKey();
            char KeyChar = KeyInfo.KeyChar;
            Console.WriteLine();

            // Translate the key to a selection.
            if (KeyChar >= '1' && KeyChar < '1' + CoffeeMachine.DrinkList.Count)
            {
                int SelectedIndex = KeyChar - '1';
                SelectableDrink SelectedDrink = CoffeeMachine.DrinkList[SelectedIndex];
                IRecipe selectedRecipe = CoffeeMachine.DrinkList[SelectedIndex].Recipe;
                double SalePrice = Math.Round(SelectedDrink.Price, 2);
                string PriceAsString = SalePrice.ToString(CultureInfo.InvariantCulture);

                string Line = $"Ce {selectedRecipe.Name} coûte {PriceAsString} euros.";

                Console.WriteLine(Line);
            }
            else
                Console.WriteLine("Désolé, cette sélection n'est pas disponible.");
        }
    }
}
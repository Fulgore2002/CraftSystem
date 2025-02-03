using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace CraftSystem
{
    public class Engine
    {
        private Person player = new Person("Anonymous Player");
        private List<Recipe> recipes = new List<Recipe>();

        public void Start()
        {
            Title = "Awesome Crafting System";
            WriteLine("Welcome to the Awesome Crafting System!");
            InitializeRecipes();
            ShowAllRecipes();
            SelectRecipeDetails();
            ReadKey();
        }

        private void InitializeRecipes()
        {
            // Example recipes
            Recipe hotChocolate = new Recipe("Hot Chocolate", "12 ounces", 3.50);
            hotChocolate.AddIngredient("Milk", "4 cups");
            hotChocolate.AddIngredient("Chocolate Chips", "1/2 cup");
            recipes.Add(hotChocolate);

            Recipe applePie = new Recipe("Apple Pie", "1 pie", 10.00);
            applePie.AddIngredient("Apples", "6 cups");
            applePie.AddIngredient("Sugar", "2 cups");
            recipes.Add(applePie);

            Recipe bread = new Recipe("Bread", "1 loaf", 5.00);
            bread.AddIngredient("Flour", "4 cups");
            bread.AddIngredient("Yeast", "1 tablespoon");
            recipes.Add(bread);
        }

        private void ShowAllRecipes()
        {
            WriteLine("\nAvailable Recipes:");
            foreach (var recipe in recipes)
            {
                WriteLine($"- {recipe.GetName()}");
            }
        }

        private void SelectRecipeDetails()
        {
            WriteLine("\nEnter the name of the recipe you want to see details for:");
            string recipeName = ReadLine();
            Recipe selectedRecipe = recipes.FirstOrDefault(r => r.GetName().Equals(recipeName, StringComparison.OrdinalIgnoreCase));

            if (selectedRecipe != null)
            {
                WriteLine($"\nRecipe: {selectedRecipe.GetName()}");
                WriteLine($"Amount: {selectedRecipe.GetOutputAmount()}");
                WriteLine($"Value: {selectedRecipe.GetValue():C}");
                WriteLine("Ingredients:");
                foreach (var ingredient in selectedRecipe.GetIngredients())
                {
                    WriteLine($"- {ingredient.Key}: {ingredient.Value}");
                }
            }
            else
            {
                WriteLine("Recipe not found.");
            }
        }
    }
}

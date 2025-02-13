using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace CraftSystem
{
    public class Engine
    {
        private Person player;
        private List<Recipe> recipes = new List<Recipe>();

        public Engine(Person player)
        {
            this.player = player;
        }

        public void Start()
        {
            Console.Title = "Awesome Crafting System";
            Console.WriteLine("Welcome to the Awesome Crafting System!");
            player.PrintStatus(); 
            InitializeRecipes();   
            ShowAllRecipes();
            SelectRecipeDetails();
            DisplayCredits();
            Console.ReadKey();
        }

        // Method to initialize recipes
        private void InitializeRecipes()
        {
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
            Console.WriteLine("\nAvailable Recipes:");
            foreach (var recipe in recipes)
            {
                Console.WriteLine($"- {recipe.GetName()}");
            }
        }

        private void SelectRecipeDetails()
        {
            Console.WriteLine("\nEnter the name of the recipe you want to see details for:");
            string recipeName = Console.ReadLine();
            Recipe selectedRecipe = recipes.FirstOrDefault(r => r.GetName().Equals(recipeName, StringComparison.OrdinalIgnoreCase));

            if (selectedRecipe != null)
            {
                Console.WriteLine($"\nRecipe: {selectedRecipe.GetName()}");
                Console.WriteLine($"Amount: {selectedRecipe.GetOutputAmount()}");
                Console.WriteLine($"Value: {selectedRecipe.GetValue():C}");
                Console.WriteLine("Ingredients:");
                foreach (var ingredient in selectedRecipe.GetIngredients())
                {
                    Console.WriteLine($"- {ingredient.Key}: {ingredient.Value}");
                }
            }
            else
            {
                Console.WriteLine("Recipe not found.");
            }
        }

        // Method to display credits at the end
        private void DisplayCredits()
        {
            Menu menu = new Menu();
            menu.DisplayCredits();
        }
    }

}

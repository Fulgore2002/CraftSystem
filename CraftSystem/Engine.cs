using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static CraftSystem.Library;

namespace CraftSystem
{
    public class Engine
    {
        Person Player = new Person();
        Person Vendor = new Person();
        public List<Recipe> Recipes = new List<Recipe>();
        private string applicationTitle = "Awesome Potion Crafting System";

        public void Start()
        {
            SetApplicationTitle(applicationTitle);
            Console.WriteLine(applicationTitle);

            Console.WriteLine(Player.Information());

            Console.WriteLine("Do you want to customize your name? Type y for yes, n for no:");
            string input = Library.GetInput();

            if (input.ToLower() == "y")
            {
                Console.WriteLine("Please enter your name:");
                Player.Name = Library.GetInput();
            }

            Recipes = Library.LoadRecipeFromXMLFile("../../../data/recipes.xml");
            Recipes.Add(new Recipe { Name = "recipe 2" });

            Run();
        }

        private void Run()
        {
            Console.WriteLine();
            Console.WriteLine(Player.Information());
            Console.WriteLine(ShowMenu());

            int number = Library.ConvertStringToInteger(Library.GetInput());

            if (number > 0)
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine(Player.ShowInventoryItems());
                        break;
                    case 2:
                        Console.WriteLine(ShowAllRecipes());
                        break;
                    case 3:
                        RecipeMenu();
                        break;
                    case 4:
                        CraftRecipe();
                        break;
                    case 5:
                        return;
                }
            }

            Run();
        }

        private string ShowMenu()
        {
            string output = "Choose an option:";
            output += "\n1. Show inventory";
            output += "\n2. Show recipes";
            output += "\n3. See recipe details";
            output += "\n4. Craft";
            output += "\n5. Exit";

            return output;
        }

        public string ShowAllRecipes()
        {
            StringBuilder output = new StringBuilder("Available Recipes:\n");
            int number = 1;

            foreach (Recipe recipe in Recipes)
            {
                output.AppendLine($"   {number}. {recipe.Information()}");
                number++;
            }

            return output.ToString();
        }

        public void RecipeMenu()
        {
            Console.WriteLine(ShowAllRecipes());
            Console.WriteLine("Enter the number of the recipe you would like to view:");
            string choice = Library.GetInput();
            int num = Library.ConvertStringToInteger(choice);

            if (num >= 1 && num <= Recipes.Count)
            {
                Console.WriteLine(Recipes[num - 1].Information());
            }
            else
            {
                Console.WriteLine("Invalid number. Please try again.");
                RecipeMenu();
            }
        }

        private void CraftRecipe()
        {
            Console.WriteLine(ShowAllRecipes());
            Console.WriteLine("Enter the number of the recipe you want to craft:");
            string choice = Library.GetInput();
            int num = Library.ConvertStringToInteger(choice);

            if (num >= 1 && num <= Recipes.Count)
            {
                Recipe recipeToCraft = Recipes[num - 1];
                Item craftedItem = Player.CraftItem(recipeToCraft);

                if (craftedItem != null)
                {
                    Console.WriteLine($"{craftedItem.Name} has been crafted and added to your inventory!");
                }
            }
            else
            {
                Console.WriteLine("Invalid number. Please try again.");
                CraftRecipe();
            }
        }
    }
}

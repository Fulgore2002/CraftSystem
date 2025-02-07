using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using CraftSystem.CraftingSystemMonday;
using static System.Console;
using static CraftSystem.Library;

namespace CraftSystem
{
    public class Engine

    {

        //player

        Person Player = new Person();
        Person Vendor = new Person();
        public List<Recipe> Recipes = new List<Recipe>();


        //name of my system

        private string name = "Awesome Potion Crafting System";

        public void Start()

        {

            Print(name);

            Print(Player.Information());

            Print("Do you want to customize your name? Type y for yes, n for no:");

            string input = Console.ReadLine();

            if (input.ToLower() == "y")

            {

                Print("Please enter your name:");

                Player.Name = Console.ReadLine();

            }

            Recipes.Add(

                new Recipe(

                    "Chamomile Tea",

                    "recipe description",

                    new List<Item>()

                    {

                        new Item(){Name ="Water", Amount = 1, Value = .0015, Description = "water", AmountType = "cup(s)"  },

                        new Item(){Name ="Chamomile", Amount = 1, Value = .0015, Description = "Matricaria recutita, dried", AmountType = "tsp(s)"  },




                    }

                )

                );

            Recipes.Add(new Recipe() { Name = "recipe 2" });




            Run();




        }

        private void Run()

        {

            Pause();

            Print(Player.Information());

            Print(showMenu());

            int number = ConvertStringToInteger(GetInput());

            if (number > 0)

            {

                //show the thing player chose

                switch (number)

                {

                    case 1:

                        Print(Player.ShowInventoryItems());

                        break;

                    case 2:

                        Print(ShowAllRecipes());

                        break;

                    case 3:

                        Print("week 3");

                        break;

                    case 4:

                        Print("week 3");

                        break;

                    case 5:

                        return;

                }

            }



            Run();

        }

        private string showMenu()

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

            string output = "Available Recipes:\n";

            int number = 1;

            foreach (Recipe recipe in Recipes)

            {

                output += $"   {number}. {recipe.Information()}\n";



                number++;

            }

            return output;

        }




        public void RecipeMenu()

        {

            ShowAllRecipes();

            Print("Enter the number of the recipe you would like to view:");

            string choice = GetInput();

            int num = ConvertStringToInteger(choice);

            if (num >= 1 && num < Recipes.Count)

            {

                //great - we got a good number

                Print(Recipes[num - 1].Information());

            }

            else

            {

                //print message saying enter right range as number

                //recursive RecipeMenu()

            }

        }




    }
}

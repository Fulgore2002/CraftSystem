using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace CraftSystem
{
    public static class Library
    {
        public static void SetApplicationTitle(string message)
        {
            Console.Title = message;
        }

        public static string LoadContentFromTextFile(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            return "Data not found";
        }

        public static List<Recipe> LoadRecipeFromXMLFile(string path)
        {
            List<Recipe> recipes = new List<Recipe>();
            if (File.Exists(path))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlNode root = doc.DocumentElement;
                XmlNodeList recipeList = root.SelectNodes("/recipes/recipe");

                foreach (XmlElement recipe in recipeList)
                {
                    Recipe recipeToAdd = new Recipe
                    {
                        Name = recipe.GetAttribute("name"),
                        Description = recipe.GetAttribute("description"),
                        yieldAmount = recipe.GetAttribute("yieldAmount"),
                        yieldType = recipe.GetAttribute("yieldType")
                    };

                    if (double.TryParse(recipe.GetAttribute("value"), out double value))
                    {
                        recipeToAdd.Value = value;
                    }

                    XmlNodeList ingredientsList = recipe.ChildNodes;
                    foreach (XmlElement i in ingredientsList)
                    {
                        Item ingredient = new Item
                        {
                            Name = i.GetAttribute("name"),
                            AmountType = i.GetAttribute("amountType")
                        };

                        if (double.TryParse(i.GetAttribute("amount"), out double amount))
                        {
                            ingredient.Amount = amount;
                        }

                        if (double.TryParse(i.GetAttribute("value"), out double ingValue))
                        {
                            ingredient.Value = ingValue;
                        }

                        recipeToAdd.Ingredients.Add(ingredient);
                    }
                    recipes.Add(recipeToAdd);
                }
            }
            return recipes;
        }

        public static int ConvertStringToInteger(string s)
        {
            if (int.TryParse(s, out int result))
            {
                return result;
            }
            return 0;
        }

        public static string GetInput()
        {
            return Console.ReadLine();
        }

        public static double ConvertToTeaspoons(double amount, string unit)
        {
            switch (unit.ToLower())
            {
                case "tablespoon":
                case "tablespoons":
                    return amount * 3;
                case "cup":
                case "cups":
                    return amount * 48;
                case "pint":
                case "pints":
                    return amount * 96;
                default:
                    return amount;
            }
        }
    }
}

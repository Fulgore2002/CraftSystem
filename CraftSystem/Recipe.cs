using System;
using System.Collections.Generic;
using System.Text;

namespace CraftSystem
{
    public class Recipe
    {
        public string Name { get; set; }
        public string OutputAmount { get; set; }
        public double Value { get; set; }
        public Dictionary<string, string> Ingredients { get; set; }

        public Recipe(string name, string outputAmount, double value)
        {
            Name = name;
            OutputAmount = outputAmount;
            Value = value;
            Ingredients = new Dictionary<string, string>();
        }

        // Method to add an ingredient and its amount
        public void AddIngredient(string item, string amount)
        {
            Ingredients[item] = amount;
        }

        // Getter methods
        public string GetName()
        {
            return Name;
        }

        public string GetOutputAmount()
        {
            return OutputAmount;
        }

        public double GetValue()
        {
            return Value;
        }

        public Dictionary<string, string> GetIngredients()
        {
            return Ingredients;
        }

        // Method to get the recipe details
        public string GetDetails()
        {
            var details = new StringBuilder();
            details.AppendLine($"Recipe: {Name}");
            details.AppendLine($"Amount: {OutputAmount}");
            details.AppendLine($"Value: {Value:C}");
            details.AppendLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                details.AppendLine($"- {ingredient.Key}: {ingredient.Value}");
            }
            return details.ToString();
        }
    }
}
